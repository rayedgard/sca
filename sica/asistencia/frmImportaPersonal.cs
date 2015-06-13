using clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class frmImportaPersonal : Form
    {

        cLeeXls ClaseExcel = new cLeeXls();


        CConection ConexionBD;
        string string_ArchivoConfiguracion;



        string CodigoTarjetaIden = "";
        object[] VariablesPersonal = { "pDocumentoDNI", "pCodigoTarjeta", "pNombres", "pPaterno", "pMaterno", "pSexo", "pFoto", "pFechaNacimiento", "pEmail", "pDireccion", "pIdProvincia", "pIdDistrito", "pTelefono", "pCelular", "pOcupacion", "pUsuario", "pContrasenia" };
        object[] DatosPersonal = new object[17];

        //para las vacaciones
        //-----para vacaciones--------
        object[] VariablesVacaciones = { "pDocumentoDNI", "pNumeroVacaciones", "pPeriodo" };
        object[] DatosVacaciones = new object[3];
        //----finc vacaciones



        //-----------variables para contrato personal----------//
        object[] VariablesContrato = { "pDocumentoDNI", "pIdCodPersonalEmpresa", "pIdAgencia", "pIdArea", "pIdCargo", "pIdTipoHorario", "pFechaInicio", "pFechaFin", "pSueldo", "pEmailEmpresa", "pCelularEmpresa", "pTelefonoEmpresa", "pEnableSINO", "pIdModalidad" };
        object[] DatosContrato = new object[14];













        public frmImportaPersonal(string ArchivoConfig)
        {
            InitializeComponent();
            string_ArchivoConfiguracion = ArchivoConfig;
            ConexionBD = new CConection();
        }









        /// <summary>
        /// METODO QUE LEE EXCEL SOLO COLUMNAS BIEN DEFINIDAS--- LANZA ERROR AL LEER CELDAS NULAS Y COMBINADAS
        /// </summary>
        private void AbreXLS()
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Archivo Excel"; // Default file name
            dlg.DefaultExt = ".xlsx"; // Default file extension
            dlg.Filter = "Text documents (.xlsx)|*.xlsx"; // Filter files by extension


            // Process open file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                tbNomabreArchivo.Text = filename;


                //DataTable datos = cLeeXls.ReadAsDataTable(filename);
                DataTable datos = cLeeXls.ExtractExcelSheetValuesToDataTable(filename, null);
                dgvExcel.DataSource = datos;

            }
        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            AbreXLS();
        }












        public void guardaPersonal()
        {
            MessageBox.Show("COLUMNAS:   " + dgvExcel.Rows.Count, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Guardar los datos
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool TransaccionCompletada = false;
            string Mensaje = "";
            try
            {

                

                for (int i = 0; i < dgvExcel.Rows.Count; i++)//PARA DETERMINAR EL NUMERO DE FILAS
                {


                    object[] VariablesPersonal = { "pDocumentoDNI", "pCodigoTarjeta", "pNombres", "pPaterno", "pMaterno", "pSexo", "pFoto", "pFechaNacimiento", "pEmail", "pDireccion", "pIdProvincia", "pIdDistrito", "pTelefono", "pCelular", "pOcupacion", "pUsuario", "pContrasenia" };

                    DatosPersonal = new object[17];
                    DatosPersonal[0] = dgvExcel.Rows[i].Cells[0].Value.ToString(); //dni
                    DatosPersonal[1] = "";
                    DatosPersonal[2] = dgvExcel.Rows[i].Cells[1].Value.ToString();//nombres
                    DatosPersonal[3] = dgvExcel.Rows[i].Cells[2].Value.ToString();//paterno
                    DatosPersonal[4] = dgvExcel.Rows[i].Cells[3].Value.ToString(); //materno
                    DatosPersonal[5] = dgvExcel.Rows[i].Cells[4].Value.ToString(); ;//sexo
                    DatosPersonal[6] = ConexionBD.Image2Bytes(pbFoto.Image);//FOTO
                    DatosPersonal[7] = "1990-04-01";
                    DatosPersonal[8] = "";
                    DatosPersonal[9] = "";
                    DatosPersonal[10] = 2;
                    DatosPersonal[11] = 3;
                    DatosPersonal[12] = "";
                    DatosPersonal[13] = "";
                    DatosPersonal[14] = "";
                    DatosPersonal[15] = dgvExcel.Rows[i].Cells[0].Value.ToString();//celda 1
                    DatosPersonal[16] = "1";

                    //carga los datos de vacaciones

                    DatosVacaciones[0] = dgvExcel.Rows[i].Cells[0].Value.ToString();//celda 1;
                    DatosVacaciones[1] = 0;
                    DatosVacaciones[2] = "";
                    //----------------------------






                    // Cargar los datos de contrato
                    // VariablesContrato ={"DocumentoDNI","IdCodPersonalEmpresa","IdAgencia","IdArea","IdCargo","IdTipoHorario",
                    // "FechaInicio","FechaFin","Sueldo","EmailEmpresa","celularEmpresa","TelefonoEmpresa","EnableSINO" };
                    DatosContrato = new object[14];
                    DatosContrato[0] = dgvExcel.Rows[i].Cells[0].Value.ToString();//celda 1
                    DatosContrato[1] = "0001"; //celda 8 para adjuntar el DNI
                    DatosContrato[2] = 1;
                    DatosContrato[3] = dgvExcel.Rows[i].Cells[5].Value.ToString(); //areas 6
                    DatosContrato[4] = 1;
                    DatosContrato[5] = 2;
                    DatosContrato[6] = "2015-01-01";  //celda 7 formato ----> "2013-01-01";
                    DatosContrato[7] = "2015-12-31"; // celda 8 formato------>"2013-01-01";
                    DatosContrato[8] = 0;
                    DatosContrato[9] = "";
                    DatosContrato[10] = "";
                    DatosContrato[11] = "";
                    DatosContrato[12] = 0;//celda 7 para determinar el estado del trabajador
                    DatosContrato[13] = dgvExcel.Rows[i].Cells[6].Value.ToString(); //modalidades 6;



                    ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_GuardarDatosPersonal", VariablesPersonal, DatosPersonal);
                    //para vacaciones
                    ConexionBD.EjecutarProcedimientoReturnVoid("spuRep_GuardarVacaciones", VariablesVacaciones, DatosVacaciones);
                    //-------------fin para cvacaciones-----------
                    ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_GuardarContratoPersonal", VariablesContrato, DatosContrato);

                    //-----------------codigo para guardar los valores en la table de horarios rotativos------//



                }


                ConexionBD.COMMIT();
                TransaccionCompletada = true;
            }
            catch (Exception ex)
            {
                ConexionBD.ROLLBACK();
                TransaccionCompletada = false;
                Mensaje = ex.Message;
            }
            finally
            {
                ConexionBD.Desconectar();
            }


            if (TransaccionCompletada)
            {
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("NO SE PUDO GUARDAR LOS DATOS, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardaPersonal();
        }

        private void tbNomabreArchivo_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }












    }
}
