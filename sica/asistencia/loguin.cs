using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Net.Mail;

namespace asistencia
{
    public partial class loguin : Form
    {


        /// <summary>
        /// Propiedad de login Ok
        /// </summary>
        int login;

        public int Login
        {
            get { return login; }
            set { login = value; }
        }
        
        CConection ConexionBD;
        Correos EnviarCorreo;
        string string_ArchivoConfiguracion;
        object area, privilegio, usuario, clave;




        public loguin()
        {
            InitializeComponent();
            ConexionBD = new CConection();
            EnviarCorreo = new Correos();
            string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
           

        }

        private void pbSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pbentrar_Click(object sender, EventArgs e)
        {
            object[] Variables = { tbUsuario.Text, tbPass.Text };
            object[] Paramentros = { "pIdUsuario", "pPassword" };

            string Mensaje = "false";
            try
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuadm_VerificarAdministrador", Paramentros, Variables);
                if (Mensaje == "true")
                {
                    DataTable tabla = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_VerificarUsuario", Paramentros, Variables).Tables[0];
                    area = tabla.Rows[0][0]; //obteniendo el id de área
                    privilegio = tabla.Rows[0][1]; //obteniendo el tipo de privilegio
                    usuario = tabla.Rows[0][2];// obteniendo el usuario de acceso
                    clave = tbPass.Text;
                }
            }
            catch
            {
                Mensaje = "false";
            }
            finally
            {
                ConexionBD.Desconectar();
            }
            tbUsuario.Text = "";
            tbPass.Text = "";
            if (Mensaje.Trim().ToLower() == "false")
            {
                MessageBox.Show("Usuario o Clave Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsuario.Focus();
            }
            else
            {
                try
                {

                   clases.Cfunciones.Globales.nameUser = usuario.ToString();

                    if ((int)privilegio == 0)
                    {
                        this.Close();

                    }
                    else { MessageBox.Show("Usuario no Autorizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }

            }
        }





        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.pbentrar_Click(sender, new EventArgs());

            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                pbentrar_Click(sender, new EventArgs());
            }


        }



      

        private void label1_Click(object sender, EventArgs e)
        {
            frmCambiarIP cambias = new frmCambiarIP(string_ArchivoConfiguracion);
            cambias.ShowDialog();
        }

        private void lbOlvide_Click(object sender, EventArgs e)
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet dsMensaje = null;
            try
            {
                dsMensaje = ConexionBD.EjecutarProcedimientoReturnDataSet("spuadm_CorreoAdministrador");
            }
            catch
            {
                dsMensaje = null;
            }
            finally
            {
                ConexionBD.Desconectar();
            }

            if (dsMensaje != null && dsMensaje.Tables != null && dsMensaje.Tables[0] != null && dsMensaje.Tables[0].Rows != null && dsMensaje.Tables[0].Rows.Count > 0)
            {
                try
                {
                    Correos Cr = new Correos();
                    MailMessage mnsj = new MailMessage();

                    mnsj.Subject = "ENVIO DE USUARIO Y PASSWORD";

                    mnsj.To.Add(new MailAddress(dsMensaje.Tables[0].Rows[0]["CORREO"].ToString()));

                    mnsj.From = new MailAddress("informes@itdecsa.com", "Sistema Control Asistencia");

                    /* Si deseamos Adjuntar algún archivo*/
                    //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                    mnsj.Body = string.Format("Se le envia su usuario y password: \r\n\r\n----------------------------\r\nUSUARIO:{0}\r\nPASSWORD:{1}\r\n----------------------------", dsMensaje.Tables[0].Rows[0]["ADMIN"].ToString(), dsMensaje.Tables[0].Rows[0]["CLAVE"].ToString());

                    /* Enviar */
                    Cr.MandarCorreo((System.Net.Mail.MailMessage)mnsj);

                    MessageBox.Show("Se ha enviado un Mail con su usuario y contraseña\r\nRevise su E-mail, si no lo encuentra revise también en correo no deseado o Spam", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void frmAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            login = 1;
        }

        private void lbCambiarcuenta_Click(object sender, EventArgs e)
        {
            frmCambiarCuenta cambio = new frmCambiarCuenta(string_ArchivoConfiguracion);
            cambio.ShowDialog();
        }

    }
}
