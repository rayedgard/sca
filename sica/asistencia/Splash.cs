using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using clases;
using System.IO;
using System.Diagnostics;

namespace asistencia
{
    public partial class Splash : Form
    {

        string string_ArchivoConfiguracion;
        public Splash()
        {



            string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
            InitializeComponent();

            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
            int b_CargoMySQL = configXml_ArchivoConfiguracion.GetValue("principal", "instaloMySQL", 0);

            if (b_CargoMySQL == 0)
            {
                Registar_Dlls(System.Environment.CurrentDirectory + @"\zkemkeeper.dll");
                RegistrarZKEmmperDLL();
                CrearBATInstalacionMySQL();
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

           


            tiempo.Enabled = true;
            tiempo.Interval = 3000;
        }


             
        private void tiempo_Tick(object sender, EventArgs e)
        {
            tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
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






        public void RegistrarZKEmmperDLL()
        {
            try
            {
                System.Environment.SpecialFolder folderSistema = System.Environment.SpecialFolder.System;
                string ZkeemkeeperDLLFolder = Environment.GetFolderPath(folderSistema) + @"\zkemkeeper.dll";
                //'/s' : Specifies regsvr32 to run silently and to not display any message boxes.
                string arg_fileinfo = "/s " + ZkeemkeeperDLLFolder;
                Process reg = new Process();
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
                MessageBox.Show(ex.Message);
            }
        }


        public void CrearBATInstalacionMySQL()
        {
            System.IO.DirectoryInfo infoCarpeta = new DirectoryInfo(string_ArchivoConfiguracion);
            string folderAplicsssacion = infoCarpeta.Parent.FullName;
            string InstalerBAT = folderAplicsssacion + @"\InstallMySQL.bat";
            string mysqlmsi = folderAplicsssacion + @"\mysql-5.5.14-win32.msi";

            if (File.Exists(InstalerBAT))
                File.Delete(InstalerBAT);

            StreamWriter writer = File.CreateText(InstalerBAT);
            writer.WriteLine("echo on");
            writer.WriteLine("cls");
            writer.WriteLine("echo Starting Install...");
            writer.WriteLine(string.Format(@"set mysql_msi=""{0}""", mysqlmsi));
            writer.WriteLine("set mysql_svname=MySQL");

            System.Environment.SpecialFolder folderProgramas = System.Environment.SpecialFolder.ProgramFiles;
            System.Environment.SpecialFolder folderUsuarios = System.Environment.SpecialFolder.CommonApplicationData;
            string ProgramMySQL = Environment.GetFolderPath(folderProgramas) + @"\MySQL\MySQL Server 5.5";
            string UsuarioMySQL = Environment.GetFolderPath(folderUsuarios) + @"\MySQL\MySQL Server 5.5";
            string DiscoProgramFiles = Environment.GetFolderPath(folderProgramas).Substring(0, 1) + @":\MSI-MySQL-Log.txt";
            string MySQLODBC = Environment.GetFolderPath(folderProgramas).Substring(0, 1) + @":\MSI-MySQL-ODBC-Log.txt";
            string MySQLGUI = Environment.GetFolderPath(folderProgramas).Substring(0, 1) + @":\MSI-MySQL-GUI-Log.txt";

            writer.WriteLine(string.Format(@"set mysql_datadir=""{0}\data""", UsuarioMySQL));
            writer.WriteLine(string.Format(@"set mysql_data2=""{0}\data""", ProgramMySQL));
            writer.WriteLine(@"set mysql_cmd=""GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' IDENTIFIED BY 'mysql' WITH GRANT OPTION;""");
            writer.WriteLine("");
            writer.WriteLine(string.Format(@"msiexec /i %mysql_msi% /qn INSTALLDIR=""{0}\"" /L* {1}", ProgramMySQL, DiscoProgramFiles));
            writer.WriteLine("echo MySQL Version 5.5.14 installed...");
            writer.WriteLine("md %mysql_data2%");
            writer.WriteLine("");
            writer.WriteLine(string.Format(@"""{0}\bin\mysqlinstanceconfig.exe"" -i -q ServiceName=MySQRayme RootPassword=mysql ServerType=DEVELOPMENT DatabaseType=MYISAM Port=3306 RootCurrentPassword=mysql", ProgramMySQL));
            writer.WriteLine("echo MySQL Instance Configured...Service started...");
            writer.WriteLine("");
            writer.WriteLine("rem Uncomment next line to allow root access from any pc...");
            writer.WriteLine(string.Format(@"""{0}\bin\mysql.exe"" -uroot -pmysql -e %mysql_cmd%", ProgramMySQL));
            writer.WriteLine("");
            writer.WriteLine(string.Format(@"""{0}\bin\mysql.exe"" -uroot -pmysql -e ""drop database asistencia""", ProgramMySQL));
            writer.WriteLine(string.Format(@"""{0}\bin\mysql.exe"" -uroot -pmysql -e ""create database asistencia""", ProgramMySQL));
            writer.WriteLine("");
            writer.WriteLine("msiexec /qn /i %mysql_odbc% /L* " + MySQLODBC);
            writer.WriteLine("echo ODBC Connector installed...");
            writer.WriteLine("");
            writer.WriteLine("msiexec /qn /i %mysql_gui% /L* " + MySQLGUI);
            writer.WriteLine("echo MySQL GUI Tools installed...");
            writer.WriteLine("");
            writer.WriteLine("echo on");
            //writer.WriteLine("");
            //writer.WriteLine(string.Format(@"explorer ""{0}\bin""",ProgramMySQL));

            writer.Close();

            // Guardar Algunas configuraciones
            //System.Environment.SpecialFolder folderXML = System.Environment.CurrentDirectory;
            //string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
            configXml_ArchivoConfiguracion.SetValue("principal", "servidor", "localhost");
            configXml_ArchivoConfiguracion.SetValue("principal", "database", "asistencia");
            configXml_ArchivoConfiguracion.SetValue("principal", "usuario", "root");
            configXml_ArchivoConfiguracion.SetValue("principal", "contrasenia", "mysql");
            configXml_ArchivoConfiguracion.SetValue("principal", "mysqldump", string.Format(@"{0}\bin\mysqldump.exe", ProgramMySQL));
            configXml_ArchivoConfiguracion.SetValue("principal", "mysql", string.Format(@"{0}\bin\mysql.exe", ProgramMySQL));
            configXml_ArchivoConfiguracion.SetValue("principal", "instaloMySQL", 1);

            

        }





    }
}
