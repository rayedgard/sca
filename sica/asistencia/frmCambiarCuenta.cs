using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    public partial class frmCambiarCuenta : Form
    {
        CConection ConexionBD;
        string string_ArchivoConfiguracion;
        public frmCambiarCuenta(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            object[] Variables = { tbUsuario.Text, tbPassword.Text ,tbNewUser.Text,tbNewClave.Text,tbNuevoCorreo.Text};
            object[] Paramentros = { "pIdUsuario", "pPassword","pNuevoUser","pNuevaClave","pNuevoMail" };
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuadm_CambiarAdministrador", Paramentros, Variables);
                ConexionBD.COMMIT();
            }
            catch
            {
                ConexionBD.ROLLBACK();
            }
            finally
            {
                ConexionBD.Desconectar();
            }            
            this.Close();
        }
    }
}