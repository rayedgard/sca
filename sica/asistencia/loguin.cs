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
            string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
            InitializeComponent();

            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
            int b_CargoMySQL = configXml_ArchivoConfiguracion.GetValue("principal", "instaloMySQL", 0);

            if (b_CargoMySQL == 0)
            {
                frmCambiarIP cambiaIP = new frmCambiarIP(string_ArchivoConfiguracion);
                Registar_Dlls(System.Environment.CurrentDirectory + @"\zkemkeeper.dll");
                cambiaIP.RegistrarZKEmmperDLL();
                cambiaIP.CrearBATInstalacionMySQL();
                configXml_ArchivoConfiguracion.SetValue("principal", "instaloMySQL", 1);
                System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory);

                MessageBox.Show("Por Favor Ejecute como administrador el archivo InstallMySQL.bat\r\nubicado en la Carpeta " + System.Environment.CurrentDirectory);

                MessageBox.Show("Si ya termino la instalacion de la Base de Datos Haga Click en Aceptar, de lo Contrario espere por favor");

                //System.Environment.SpecialFolder folder = System.Environment.CurrentDirectory;
                //string string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
                string Servidor = configXml_ArchivoConfiguracion.GetValue("principal", "servidor", "localhost");
                string DB = configXml_ArchivoConfiguracion.GetValue("principal", "database", "asistencia");
                string usuario = configXml_ArchivoConfiguracion.GetValue("principal", "usuario", "root");
                string contrasenia = configXml_ArchivoConfiguracion.GetValue("principal", "contrasenia", "mysql");
                System.Environment.SpecialFolder folderProgramas = System.Environment.SpecialFolder.ProgramFiles;
                System.Environment.SpecialFolder folderUsuarios = System.Environment.SpecialFolder.CommonApplicationData;
                string ProgramMySQL = Environment.GetFolderPath(folderProgramas) + @"\MySQL\MySQL Server 5.5";
                string mysqldump = configXml_ArchivoConfiguracion.GetValue("principal", "mysqldump", string.Format(@"{0}\bin\mysqldump.exe", ProgramMySQL));
                string mysqlrestore = configXml_ArchivoConfiguracion.GetValue("principal", "mysql", string.Format(@"{0}\bin\mysql.exe", ProgramMySQL));
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(System.Environment.CurrentDirectory + @"\asistencia_dos.sql");
                    System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                    string cmdArgs = string.Format(@"-u{0} -p{1} -h{2} {3}", usuario, contrasenia, Servidor, DB);
                    proc.FileName = mysqlrestore;
                    proc.RedirectStandardInput = true;
                    proc.RedirectStandardOutput = false;
                    proc.Arguments = cmdArgs;
                    proc.UseShellExecute = false;
                    System.Diagnostics.Process p = System.Diagnostics.Process.Start(proc);
                    string res = file.ReadToEnd();
                    file.Close();
                    p.StandardInput.WriteLine(res);
                    p.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ConexionBD = new CConection();
            EnviarCorreo = new Correos();
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



        public static void Registar_Dlls(string filePath)
        {
            try
            {
                //'/s' : Specifies regsvr32 to run silently and to not display any message boxes.
                string arg_fileinfo = "/s" + " " + "\"" + filePath + "\"";
                System.Diagnostics.Process reg = new System.Diagnostics.Process();
                //This file registers .dll files as command components in the registry.
                reg.StartInfo.FileName = "regsvr32.exe";
                reg.StartInfo.Arguments = arg_fileinfo;
                reg.StartInfo.UseShellExecute = false;
                reg.StartInfo.CreateNoWindow = true;
                reg.StartInfo.RedirectStandardOutput = true;
                reg.Start();
                reg.WaitForExit();
                reg.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
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

                    mnsj.From = new MailAddress("soporte@itdecsa.com", "Sistema Control Asistencia");

                    /* Si deseamos Adjuntar algún archivo*/
                    //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                    mnsj.Body = string.Format("Se le envia su usuario y password: \r\n\r\n----------------------------\r\nUSUARIO:{0}\r\nPASSWORD:{1}\r\n----------------------------", dsMensaje.Tables[0].Rows[0]["ADMIN"].ToString(), dsMensaje.Tables[0].Rows[0]["CLAVE"].ToString());

                    /* Enviar */
                    Cr.MandarCorreo((System.Net.Mail.MailMessage)mnsj);

                    MessageBox.Show("Se ha enviado un Mail con su usuario y contraseña\r\nRevise Correo No deseado o Spam", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

    }
}
