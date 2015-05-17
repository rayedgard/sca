using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using clases;


namespace asistencia
{
    public partial class frmNuevoVacaciones : Form
    {

        CValidacion ValidarDatos;
        CConection ConexionBD;
        //bool HuellaCargada = false;

        string string_ArchivoConfiguracion;
        public frmNuevoVacaciones(string ArchivoCOnfig)
        {
            InitializeComponent();
            string_ArchivoConfiguracion = ArchivoCOnfig;
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            cargarDatos();
        }



        //-----fin vacaciones--------
        object[] VariablesVacaciones = { "pDocumentoDNI", "pNumeroVacaciones","pPeriodo" };
        object[] DatosVacaciones = new object[3];

        object[] DatosRecuperados = new object[2];
        private void cargarDatos()
        {
            ////obtener datos de la base de datos para vacaciones


            lbEmpleado.Text = clases.Cfunciones.Globales.NombresYapellidos;
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            DatosRecuperados = ConexionBD.RecuperaDatoVacaciones("spuRep_numeroVacaciones", "pDNI", clases.Cfunciones.Globales.dni);
            ConexionBD.Desconectar();

            tbNumeroVacaciones.Text=DatosRecuperados[0].ToString();
            tbPeriodoVacacional.Text = DatosRecuperados[1].ToString();

        }
        
        
        
        
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DatosVacaciones[0] = clases.Cfunciones.Globales.dni;
            DatosVacaciones[1] = tbNumeroVacaciones.Text.Trim();
            DatosVacaciones[2] = tbPeriodoVacacional.Text;
            

            // Guardar los datos
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool TransaccionCompletada = false;
            string Mensaje = "";
            try
            {
             
                ConexionBD.EjecutarProcedimientoReturnVoid("spuRep_GuardarVacaciones", VariablesVacaciones, DatosVacaciones);
            
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
                this.Close();

            }
            else
                MessageBox.Show("NO SE PUDO GUARDAR LOS DATOS, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        
        
        }


        public void LimpiarDatos()
        {
            DatosVacaciones[0] = "";
            DatosVacaciones[1] = "";
            DatosVacaciones[2] = "";

            tbNumeroVacaciones.Text = "";
            tbPeriodoVacacional.Text = "";
            lbEmpleado.Text = "";
        }








    }
}
