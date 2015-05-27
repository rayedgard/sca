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
    public partial class frmReporteVacaciones : Form
    {


        CValidacion ValidarDatos;
        CConection ConexionBD;
        string NombreModalidad;
        string NombreMunicipalidad;
        string string_ArchivoConfiguracion;

        public frmReporteVacaciones(string ArchivoCOnfig)
        {
            
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
       

            CargarModalidad();

        }

        private void btnExcelModalidad_Click(object sender, EventArgs e)
        {
            exportaExcel(dgvDatos);
        }



        public void exportaExcel(DataGridView datos)
        {

            string MyDocumentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string TargetFilename = System.IO.Path.Combine(MyDocumentsPath, "Sample.xlsx");
            //  Step 1: Create a DataSet, and put some sample data in it
           DataTable dt = new DataTable();
           
           dt = agregadatos(datos);
        
            //dt = dgvDatos.DataSource;
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





        public DataTable agregadatos(DataGridView datos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DNI", typeof(System.String));
            dt.Columns.Add("APELLIDO PATERNO", typeof(System.String));
            dt.Columns.Add("APELLIDO MATERNO", typeof(System.String));
            dt.Columns.Add("NOMBRES", typeof(System.String));
            if (rbtGeneral.Checked)
            {
                dt.Columns.Add("FECHA VACACIÓN", typeof(System.String));
                dt.Columns.Add("DOCUMENTO", typeof(System.String));
            }
            if (rbtResumen.Checked)
            {
                dt.Columns.Add("VACACION ASIGNADA", typeof(System.String));
                dt.Columns.Add("VACACION TOMADA", typeof(System.String));
                dt.Columns.Add("PERIODO VACACIONAL", typeof(System.String));
            }
            
          

            foreach (DataGridViewRow rowGrid in datos.Rows)
            {
                DataRow row = dt.NewRow();

                ;
                if (rowGrid.Cells[0].Value == null)
                { row["DNI"] = ""; }
                else
                { row["DNI"] = rowGrid.Cells[1].Value.ToString(); }

                if (rowGrid.Cells[1].Value == null)
                { row["APELLIDO PATERNO"] = ""; }
                else
                { row["APELLIDO PATERNO"] = rowGrid.Cells[1].Value.ToString(); }

                if (rowGrid.Cells[2].Value == null)
                { row["APELLIDO MATERNO"] = ""; }
                else
                { row["APELLIDO MATERNO"] = rowGrid.Cells[2].Value.ToString(); }

                if (rowGrid.Cells[3].Value == null)
                { row["NOMBRES"] = ""; }
                else
                { row["NOMBRES"] = rowGrid.Cells[3].Value.ToString(); }

                if (rbtGeneral.Checked)
                {
                    if (rowGrid.Cells[4].Value == null)
                    { row["FECHA VACACIÓN"] = ""; }
                    else
                    { row["FECHA VACACIÓN"] = rowGrid.Cells[4].Value.ToString(); }

                    if (rowGrid.Cells[5].Value == null)
                    { row["DOCUMENTO"] = ""; }
                    else
                    { row["DOCUMENTO"] = rowGrid.Cells[5].Value.ToString(); }
                    
                }
                if (rbtResumen.Checked)
                {
                    if (rowGrid.Cells[4].Value == null)
                    { row["VACACION ASIGNADA"] = ""; }
                    else
                    { row["VACACION ASIGNADA"] = rowGrid.Cells[4].Value.ToString(); }

                    if (rowGrid.Cells[5].Value == null)
                    { row["VACACION TOMADA"] = ""; }
                    else
                    { row["VACACION TOMADA"] = rowGrid.Cells[5].Value.ToString(); }

                    if (rowGrid.Cells[6].Value == null)
                    { row["PERIODO VACACIONAL"] = ""; }
                    else
                    { row["PERIODO VACACIONAL"] = rowGrid.Cells[6].Value.ToString(); }
                }

                dt.Rows.Add(row);
            }

            return dt;
        }







        private void btnNuevo_Click(object sender, EventArgs e)
        {
            object[] ParamNames = { "pIdModalidad", "pTipo"};
            object[] ParamValues = { "pIdModalidad", "pTipo" };
            
            int tipo=0;
            if(rbtGeneral.Checked)
                tipo=1;
            if(rbtResumen.Checked)
                tipo=2;


            ParamValues[0] = cbFiltrado.SelectedValue;
            ParamValues[1] = tipo;
            try
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DataSet Reporte = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_reporteVacaciones", ParamNames, ParamValues);
                

                dgvDatos.DataSource = Reporte.Tables[0];
                ConexionBD.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarModalidad()
        {
            //Cargar POR MODALIDAD
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbFiltrado, true, "spuGeo_ListarModalidades");
            ConexionBD.Desconectar();
            //Cargar Distritos
        }

        private void btnPDFModalidad_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (rbtGeneral.Checked)
                tipo = 1;
            if (rbtResumen.Checked)
                tipo = 2;
            generaPDF(dgvDatos, tipo);
        }


        /// <summary>
        /// METODO PARA GENERAR EL REPORTE EN PDF
        /// </summary>
        /// <param name="grid">DATAGRIDVIEW QUE CONTIENE LOS DATOS DEL PERSONAL </param>
        private void generaPDF(DataGridView grid, int tipo)
        {
            if (dgvDatos.Rows.Count > 0)
            {
             
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

                               

                                DateTime fechahoy = DateTime.Now;

                                string envio = string.Format("Fecha del Reporte :{0}", fechahoy.ToLongDateString());

                             

                                string proveedor = "";


                                //aca se agregan parrafos de cabecera antes del DataaGridView 
                                Chunk chunk21 = new Chunk(NombreMunicipalidad, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));

                                doc.Add(new Paragraph(chunk21));
                                Chunk chunk = null;
                                if (rbtGeneral.Checked == true)
                                {
                                    chunk = new Chunk("REPORTE GENERAL DE VACACIONES POR PERSONA", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD));
                                }
                                if (rbtResumen.Checked == true)
                                {
                                    chunk = new Chunk("REPORTE DE VACACIONES RESUMEN", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD));
                                }
                                doc.Add(new Paragraph(chunk));

                                /*ESTA PARTE DE CODIGO SE INCREMENTA PARA GENERAR EL TEXTO PARA LOS MESAJES DE REPORETES DE DESCUENTOS Y REGISTROS IRREGULARES*/
                                if (tipo == 1)
                                {
                                    Chunk chunk10 = new Chunk("REPORTE DE VACACIONES POR PERSONA, FILTRADO POR FECHAS EN EL QUE EL PERSONAL TOMO SUS VACACIONES", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
                                    doc.Add(new Paragraph(chunk10));
                                }
                                if (tipo == 2)
                                {
                                    Chunk chunk10 = new Chunk("RESUMEN VACACIONAL DE TODO EL PERSONAL POR NUMERO TOTAL DE VACACIONES", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
                                    doc.Add(new Paragraph(chunk10));
                                }
                                /*-------------------------FIN VALORES------------*/


                                iTextSharp.text.Font FuenteTexto = FontFactory.GetFont("ARIAL", 8, BaseColor.ORANGE);

                                FuenteTexto.Color = BaseColor.BLUE;
                                doc.Add(new Paragraph(proveedor, FuenteTexto));

                                doc.Add(new Paragraph(envio, FuenteTexto));

                                // doc.Add(new Paragraph(envio, FuenteTexto));
                                FuenteTexto.Color = BaseColor.ORANGE;

                                doc.Add(new Paragraph("________________________________________________________________________", FuenteTexto));
                                //DataGridView ParaReporte = dgvReportePersonal; // GenerarDataGridParaReporte(dgvReportePersonal);

                                GenerarDocumento(doc, grid, tipo);


                               
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






        public void GenerarDocumento(Document document, DataGridView dgvReporte, int tipo)
        {
            iTextSharp.text.Font FuenteTexto = FontFactory.GetFont("ARIAL", 8, BaseColor.BLACK);
            iTextSharp.text.Font FuenteTextoTarde = FontFactory.GetFont("ARIAL", 8, BaseColor.RED);
            iTextSharp.text.Font FuenteTextoEntrada = FontFactory.GetFont("ARIAL", 8, BaseColor.BLUE);

            int i, j;

            //se crea un objeto PdfTable con el numero de columnas del dataGridView

            PdfPTable datatable = new PdfPTable(dgvReporte.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf

            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetTamañoColumnas(dgvReporte);
            //cambios para el nuevo reporte
            float[] AnchosColumnas = { };

            if (tipo == 1)
            {

                float[] mon = { 7.0f, 7.0f, 7.0f, 7.0f, 7.0f, 20.0f };
                AnchosColumnas = mon;
            }
            if (tipo == 2)
            {
                float[] mon = { 7.0f, 7.0f, 7.0f, 7.0f, 7.0f, 7.0f, 20.0f };
                AnchosColumnas = mon;
            }
          
            datatable.SetWidths(AnchosColumnas);

            datatable.WidthPercentage = 95;

            datatable.DefaultCell.BorderWidth = 2;

            if (tipo == 1)
            {
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            }
            else
            {
                datatable.DefaultCell.VerticalAlignment = Element.ALIGN_JUSTIFIED;
            }

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
                        if (j == 3 || j == 6 || j == 12)
                        {
                            NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTextoEntrada);
                        }
                        else
                        {
                            if (j == 4 || j == 7 || j == 13)
                            {
                                NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTextoTarde);
                            }
                            else
                            {
                                NuevaFrase = new Phrase(dgvReporte[j, i].Value.ToString(), FuenteTexto);
                            }
                        }
                    }
                    if (j == 0 || j == 1 || j == 2 || j == 15)
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















    }
}
