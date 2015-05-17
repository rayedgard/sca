using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    public partial class frmHabilitaPersonal : Form
    {
        CConection ConexionBD;
        string string_ArchivoConfiguracion;

        public frmHabilitaPersonal(string ArchivoCOnfig)
        {
            InitializeComponent();
            string_ArchivoConfiguracion = ArchivoCOnfig;
            ConexionBD = new CConection();

            lbNombre.Text= clases.Cfunciones.Globales.NombresYapellidos;
            lbDNI.Text = clases.Cfunciones.Globales.dni;

            if (clases.Cfunciones.Globales.estado == 0)
            {
                rbtHabilitadoBiometrico.Checked = true;
            }
            if (clases.Cfunciones.Globales.estado == 1)
            {
                rbtHabilitadoManual.Checked = true;
            }
            if (clases.Cfunciones.Globales.estado == 2)
            {
                rbtDeshabilitado.Checked = true;
            }

        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }


        private void GuardarDatos()
        {
          
        

            object[] NombresHabilitacion = { "pDNI", "pEnableSINO"};
            object[] datosHabilitacion = { "pDNI", "pEnableSINO" };

            datosHabilitacion[0]=clases.Cfunciones.Globales.dni;
            if (rbtHabilitadoBiometrico.Checked)
            {
                datosHabilitacion[1] = 0;
            }
            if (rbtHabilitadoManual.Checked)
            {
                datosHabilitacion[1] = 1;
            }
            if (rbtDeshabilitado.Checked)
            {
                datosHabilitacion[1] = 2;
            }

            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_HabilitaEstado", NombresHabilitacion, datosHabilitacion);
                ConexionBD.COMMIT();
                SeGuardo = true;
            }
            catch//(Exception ex)
            {
                ConexionBD.ROLLBACK();
                SeGuardo = false;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.Desconectar();
            }

            if (SeGuardo)
            {
                MessageBox.Show("EL ESTADO DEL PERSONAL SE CAMBIO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("HIUBO UN ERROR AL INTENTAR CAMBIAR EL ESTADODEL PERSONAL", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }






    }
}
