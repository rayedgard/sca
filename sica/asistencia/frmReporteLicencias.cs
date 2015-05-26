using clases;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class frmReporteLicencias : Form
    {


        CConection ConexionBD;
        CValidacion ValidarDatos;
        string NombreMunicipalidad;
        string string_ArchivoConfiguracion;
        public frmReporteLicencias(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            /*dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            cbTipoDeReporte.SelectedIndex = 0;*/
            CargarDatosReporte();

        }

        public void CargarDatosReporte()
        {

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            NombreMunicipalidad = ConexionBD.EjecutarProcedimientoReturnMensaje("spuGeo_RecuperarNombreMunicipalidad"); ;
            ConexionBD.Desconectar();

        }


        private void tbDNIPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void tbDNIPersonal_TextChanged(object sender, EventArgs e)
        {
            lbNombreUsuario.Text = "";
            BuscarDatosPersonal(tbDNIPersonal.Text);
        }

        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                object[] DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    lbNombreUsuario.Text = DatosPersonal[2].ToString() + " " + DatosPersonal[3].ToString() + " " + DatosPersonal[4].ToString();
                }
                else
                {
                    lbNombreUsuario.Text = "";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDNI busca = new frmBuscarDNI(string_ArchivoConfiguracion);
            busca.ShowDialog();

            if (busca.pDNI.ToString().Length < 8)
            {
                if (busca.pDNI.ToString().Length == 5)
                {
                    tbDNIPersonal.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 6)
                {
                    tbDNIPersonal.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 7)
                {
                    tbDNIPersonal.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNIPersonal.Text = busca.pDNI;
            }

        }

        bool pBoolMostrarResumen = false;

        private void btnVerReportePersonal_Click(object sender, EventArgs e)
        {


            pBoolMostrarResumen = false;
            int dni = 0;
            int.TryParse(tbDNIPersonal.Text.Trim(), out dni);
            dgvReportePersonal.Rows.Clear();

            if (dni != 0)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                try
                {
                    pBoolMostrarResumen = true;
                    CargarReporteEnGrid(dni.ToString(), true);
                }
                catch
                {
                }
                finally
                {
                    ConexionBD.Desconectar();
                }
             

            }
            else
            {
                if (tbDNIPersonal.Text.Trim() == "")
                {
                   vertodoslosusuarios(false, false);
                }
            }
       
        }








        private void CargarReporteEnGrid(string pDNI, bool MostrarSumatorias)
        {
            object[] ParamNames = { "pFechaConsulta", "pDocumentoDNI", "pTipo" };
            object[] ParamValues = { "2005-05-05", "45659875", "L" };

            //para determinar la seleccion de los check
            char chek = 'n';
            if (rbLicencias.Checked)
            {
                chek = 'L';
            }
            if (rbPermisos.Checked)
            {
                chek = 'P';
            }
            //---------------------


            ParamValues[1] = pDNI;
            ParamValues[0] = string.Format("{0}-{1}-{2}", dtpFechaInicioPersonal.Value.Year, dtpFechaInicioPersonal.Value.Month, dtpFechaInicioPersonal.Value.Day);
            ParamValues[2] = chek;
            string Consulta = "nuevo_ListarLicencias";
            DateTime dtFechaInicioAnterior = dtpFechaInicioPersonal.Value;
            try
            {
                for (int i = 0; dtFechaInicioAnterior.Date <= dtpFechaFInPersonal.Value.Date; i++)
                {
                    ParamValues[0] = string.Format("{0}-{1}-{2}", dtFechaInicioAnterior.Year, dtFechaInicioAnterior.Month, dtFechaInicioAnterior.Day);
                    dtFechaInicioAnterior = dtFechaInicioAnterior.AddDays(1);
                    DataSet Reporte = ConexionBD.EjecutarProcedimientoReturnDataSet(Consulta, ParamNames, ParamValues);
                    if (Reporte != null && Reporte.Tables != null && Reporte.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < Reporte.Tables[0].Rows.Count; j++)
                        {

                            dgvReportePersonal.Rows.Add(Reporte.Tables[0].Rows[j].ItemArray);
                       
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // dtpFechaInicioPersonal.Value = dtFechaInicioAnterior;
            }
        }







        private void vertodoslosusuarios(bool bSoloTardanzas, bool MostrarSumatoria)
        {
            DataSet ListaDnis = null;
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            try
            {
                ListaDnis = ConexionBD.EjecutarProcedimientoReturnDataSet("spuRep_ListaDNIsPersonal");
                if (ListaDnis != null && ListaDnis.Tables != null && ListaDnis.Tables[0] != null && ListaDnis.Tables[0].Rows != null && ListaDnis.Tables[0].Rows.Count > 0)
                {
                    int NroDNIs = ListaDnis.Tables[0].Rows.Count;
                    object[] dnipersonal = { "" };



                    /*para el progresbar*/
                    //aqui cargamos los valores del progresbar
                    prbCarga.Visible = true;
                    prbCarga.Minimum = 0;
                    // PARA HACER LA DIFERENCIA ENTRE LAS FECHAS
                    TimeSpan ts = (dtpFechaFInPersonal.Value.Date - dtpFechaInicioPersonal.Value.Date);

                    // DESPUES DE HACER LA DIFERENCIA LO CONVERTIMOS EN DIAS.
                    prbCarga.Maximum = NroDNIs;
                    prbCarga.Step = 1;
                    //------fin progresbar---------






                    for (int j = 0; j < NroDNIs; j = j + prbCarga.Step)
                    {
                        dnipersonal = ListaDnis.Tables[0].Rows[j].ItemArray;
                        CargarReporteEnGrid(dnipersonal[0].ToString().Trim(), MostrarSumatoria);
                        prbCarga.PerformStep();
                    }
                    prbCarga.Value = 0;
                    prbCarga.Visible = false;
                }
            }
            catch
            {

            }
            finally
            {
                ConexionBD.Desconectar();
            }
        }

        private void btnPDFModalidad_Click(object sender, EventArgs e)
        {
            generaPdf();
        }

        public void generaPdf()
        {
            if (dgvReportePersonal.Rows.Count > 0)
            {
                //Código para exportar DataGridView a PDF usando iTextSharp
                //Evento clic del Botón Exporta
                try
                {

                    Document doc = new Document(PageSize.A4.Rotate(), 12, 12, 12, 15);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string filename = saveFileDialog.FileName;
                        if (filename.Trim() != "")
                        {
                            FileStream file = new FileStream(filename,
                            FileMode.OpenOrCreate,
                            FileAccess.ReadWrite,
                            FileShare.ReadWrite);
                            PdfWriter.GetInstance(doc, file);
                            doc.Open();

                            string remito = string.Format("Periodo del Reporte: Desde {0} hasta {1}", dtpFechaInicioPersonal.Text, dtpFechaFInPersonal.Text);
                            DateTime fechahoy = DateTime.Now;
                            string envio = string.Format("Fecha del Reporte :{0}", fechahoy.ToLongDateString());
                            remito = remito + "      --     " + envio;
                            string proveedor = "";

                            //aca se agregan parrafos de cabecera antes del DataaGridView 
                            Chunk chunk21 = new Chunk(NombreMunicipalidad, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
                            doc.Add(new Paragraph(chunk21));
                            Chunk chunk = null;
                            if (rbLicencias.Checked)
                                chunk = new Chunk("REPORTE GENERAL DE LICENCIAS", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD));
                            if (rbPermisos.Checked)
                                chunk = new Chunk("REPORTE GENERAL DE PERMISOS", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD));

                            doc.Add(new Paragraph(chunk));

                            iTextSharp.text.Font FuenteTexto = FontFactory.GetFont("ARIAL", 8, BaseColor.ORANGE);
                            FuenteTexto.Color = BaseColor.BLUE;
                            doc.Add(new Paragraph(proveedor, FuenteTexto));
                            doc.Add(new Paragraph(remito, FuenteTexto));

                            // doc.Add(new Paragraph(envio, FuenteTexto));
                            FuenteTexto.Color = BaseColor.ORANGE;

                            doc.Add(new Paragraph("________________________________________________________________________", FuenteTexto));
                            DataGridView ParaReporte = dgvReportePersonal; // GenerarDataGridParaReporte(dgvReportePersonal);

                            /*--------para determinar las tablas -----------*/
                            GenerarDocumento(doc, ParaReporte);

                            if (pBoolMostrarResumen)
                            {
                                iTextSharp.text.Font FuenteResumen = FontFactory.GetFont("ARIAL", 15, BaseColor.ORANGE);
                                FuenteResumen.Color = BaseColor.RED;
                                doc.Add(new Paragraph("-------------------------", FuenteResumen));
                                //FuenteTexto.Color = BaseColor.BLUE;
                                //if (rbLicencias.Checked)//para saber sis es liccencia o permiso
                                //    doc.Add(new Paragraph("Total Licencias por periodo: " + pLicencias.ToString(), FuenteTexto));
                                //if (rbPermisos.Checked)//para saber sis es liccencia o permiso
                                //    doc.Add(new Paragraph("Total Permisos por periodo: " + pLicencias.ToString(), FuenteTexto));


                            }

                            FuenteTexto.Color = BaseColor.BLUE;


                            doc.Close();

                            Process.Start(filename);

                        }

                        else
                        {

                            MessageBox.Show("Ingrese nombre del archivo");

                        }

                    }

                }

                finally { }


            }
        }




        public void GenerarDocumento(Document document, DataGridView dgvReporte)
        {
            iTextSharp.text.Font FuenteTexto = FontFactory.GetFont("ARIAL", 7, BaseColor.BLACK);
            iTextSharp.text.Font FuenteTextoTarde = FontFactory.GetFont("ARIAL", 7, BaseColor.RED);
            iTextSharp.text.Font FuenteTextoEntrada = FontFactory.GetFont("ARIAL", 7, BaseColor.BLUE);

            int i, j;

            //se crea un objeto PdfTable con el numero de columnas del dataGridView

            PdfPTable datatable = new PdfPTable(dgvReporte.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf

            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetTamañoColumnas(dgvReporte);
            //cambios para el nuevo reporte
            float[] AnchosColumnas = { 7.0f, 7.0f, 30.0f, 15.0f, 15.0f, 15.0f, 8.0f, 8.0f, 8.0f };
            datatable.SetWidths(AnchosColumnas);

            datatable.WidthPercentage = 95;

            datatable.DefaultCell.BorderWidth = 2;

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


            datatable.DefaultCell.BorderColor = BaseColor.DARK_GRAY;


            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF

            for (i = 0; i < dgvReporte.ColumnCount; i++)
            {
                Phrase NuevaFrase = new Phrase(dgvReporte.Columns[i].HeaderText, FuenteTexto);
                datatable.AddCell(NuevaFrase);
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF

            for (i = 0; i < dgvReporte.RowCount; i++)
            {

                for (j = 0; j < dgvReporte.ColumnCount; j++)
                {
                    Phrase NuevaFrase = new Phrase("");
                    if (dgvReporte[j, i].Value == null || dgvReporte[j, i].Value.ToString().Trim().Replace("\r\n", "") == "")
                        NuevaFrase = new Phrase("", FuenteTexto);
                    else
                    {
                        if (j == 3 || j == 6 || j == 7 || j == 8)
                        {
                            NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTextoEntrada);
                        }
                        else
                        {
                            if (j == 13)
                            {
                                NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTextoTarde);
                            }
                            else
                            {
                                NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTexto);
                            }
                        }
                    }
                    if (j == 2 || j == 14)
                    {
                        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    }
                    else
                    {
                        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    datatable.AddCell(NuevaFrase);
                }
                datatable.CompleteRow();
            }

            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO

            document.Add(datatable);

        }




        //Función que obtiene los tamaños de las columnas del grid

        public float[] GetTamañoColumnas(DataGridView dg)
        {

            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)
            {

                values[i] = (float)dg.Columns[i].Width + 10;

            }

            return values;

        }

        private void btnExcelModalidad_Click(object sender, EventArgs e)
        {
            exportaExcel(dgvReportePersonal);
        }

        public void exportaExcel(DataGridView datos)
        {

            string MyDocumentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string TargetFilename = System.IO.Path.Combine(MyDocumentsPath, "Sample.xlsx");
            //  Step 1: Create a DataSet, and put some sample data in it
            DataTable dt = new DataTable();
           
            dt = agregadatos(datos);
         
            //DataTable dt = ((DataTable)dgvReportePersonal.DataSource);
            //  Step 2: Create the Excel file
            try
            {
                CreateExcelFile.CreateExcelDocument(dt, TargetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            }
            //  Step 3:  Let's open our new Excel file and shut down this application.
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(TargetFilename);
            p.Start();

            MessageBox.Show("DOCUMENTO EXPORTADO CON EXITO", "EXPORTACION DE XMLX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// ADJUNTA DATOS A UNA DATATABLE DE UN DATAGRIDVIEW
        /// </summary>
        /// <param name="datos">GDVREPORTEGENERAL</param>
        /// <returns></returns>
        public DataTable agregadatos(DataGridView datos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha", typeof(System.String));
            dt.Columns.Add("DNI", typeof(System.String));
            dt.Columns.Add("Nombres", typeof(System.String));
            dt.Columns.Add("Licencia / Permiso", typeof(System.String));
            dt.Columns.Add("Goce de Haber", typeof(System.String));
            dt.Columns.Add("Cod/Documento", typeof(System.String));
            dt.Columns.Add("Hora Salida", typeof(System.String));
            dt.Columns.Add("Hora Retorno", typeof(System.String));
            dt.Columns.Add("Total Horas", typeof(System.String));


            foreach (DataGridViewRow rowGrid in datos.Rows)
            {
                DataRow row = dt.NewRow();

                row["Fecha"] = rowGrid.Cells[0].Value.ToString();
                row["DNI"] = rowGrid.Cells[1].Value.ToString();
                if (rowGrid.Cells[2].Value == null)
                { row["Nombres"] = ""; }
                else
                { row["Nombres"] = rowGrid.Cells[2].Value.ToString(); }

                if (rowGrid.Cells[3].Value == null)
                { row["Licencia / Permiso"] = ""; }
                else
                { row["Licencia / Permiso"] = rowGrid.Cells[3].Value.ToString(); }

                if (rowGrid.Cells[4].Value == null)
                { row["Goce de Haber"] = ""; }
                else
                { row["Goce de Haber"] = rowGrid.Cells[4].Value.ToString(); }

                if (rowGrid.Cells[5].Value == null)
                { row["Cod/Documento"] = ""; }
                else
                { row["Cod/Documento"] = rowGrid.Cells[5].Value.ToString(); }

                if (rowGrid.Cells[6].Value == null)
                { row["Hora Salida"] = ""; }
                else
                { row["Hora Salida"] = rowGrid.Cells[6].Value.ToString(); }

                if (rowGrid.Cells[7].Value == null)
                { row["Hora Retorno"] = ""; }
                else
                { row["Hora Retorno"] = rowGrid.Cells[7].Value.ToString(); }

                if (rowGrid.Cells[8].Value == null)
                { row["Total Horas"] = ""; }
                else
                { row["Total Horas"] = rowGrid.Cells[8].Value.ToString(); }

              


                dt.Rows.Add(row);
            }

            return dt;
        }









   
    }
}
