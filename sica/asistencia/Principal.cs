using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using System.Diagnostics;
using System.IO;
using clases;
using System.Collections;


namespace asistencia
{
    public partial class Principal : Form
    {


        string a_IPMaquina;
        int a_Puerto;
        string string_ArchivoConfiguracion;


        CValidacion ValidarDatos;
        CConection ConexionBD;

        public Principal()
        {
            string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
            ConexionBD = new CConection();
            InitializeComponent();
            CargarConfiguracionEquipo();
            cargaReloj();
        }
       
        
        
        public void CargarConfiguracionEquipo()
        {
            
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);

            a_IPMaquina = configXml_ArchivoConfiguracion.GetValue("principal", "ipmaquina", "192.168.1.201");
            a_Puerto = configXml_ArchivoConfiguracion.GetValue("principal", "nropuerto", 4370);

         
        }

        private void cargaReloj()
        {
            //Cargar Provincias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbIPreloj, true, "nuevo_listarReloj");
            ConexionBD.Desconectar();
        }
        
        private void pbPersonal_Click(object sender, EventArgs e)
        {
            
            frmPersonal1 per = new frmPersonal1(a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
             per.MdiParent = this;
            per.Show();
          
        }

        private void lbTurnos_Click(object sender, EventArgs e)
        {
            frmTurno turno = new frmTurno(string_ArchivoConfiguracion);
            turno.MdiParent = this;
            turno.Show();
        }

        private void lbLicencias_Click(object sender, EventArgs e)
        {
            frmLicencia licencia = new frmLicencia(string_ArchivoConfiguracion);
            licencia.MdiParent = this;
            licencia.Show();
        }

        private void pbTiposPersonal_Click(object sender, EventArgs e)
        {
            frmTipoPersonal tipoPer = new frmTipoPersonal(string_ArchivoConfiguracion);
            tipoPer.MdiParent = this;
            tipoPer.Show();
        }

        private void lbHorarios_Click(object sender, EventArgs e)
        {
            frmHorario horario = new frmHorario(string_ArchivoConfiguracion);
            horario.MdiParent = this;
            horario.Show();
        }

        private void áREASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAreas area = new frmAreas(string_ArchivoConfiguracion);
            area.MdiParent = this;
            area.Show();
        }

        private void aGENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgencia agencia = new frmAgencia(string_ArchivoConfiguracion);
            agencia.MdiParent = this;
            agencia.Show();
        }

        private void cIUDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudad = new frmCiudades(string_ArchivoConfiguracion);
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void mODALIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModalidad modalidad = new frmModalidad(string_ArchivoConfiguracion);
            modalidad.MdiParent = this;
            modalidad.Show();
        }

        private void dIASNOLABORABLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiasNoLaborables nolaborables = new frmDiasNoLaborables(string_ArchivoConfiguracion);
            nolaborables.MdiParent = this;
            nolaborables.Show();
        }

        private void lbCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario calendario = new frmCalendario(string_ArchivoConfiguracion);
            calendario.MdiParent = this;
            calendario.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios(string_ArchivoConfiguracion);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void rELOJESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReloj reloj = new frmReloj(string_ArchivoConfiguracion);
            reloj.MdiParent = this;
            reloj.Show();
        }

        private void tOLERANCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoToletancia tolerancia = new frmNuevoToletancia(string_ArchivoConfiguracion);
            tolerancia.MdiParent = this;
            tolerancia.Show();
        }

        private void tIPOSDELICENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoLIcencia tipolicencia = new frmTipoLIcencia(string_ArchivoConfiguracion);
            tipolicencia.MdiParent = this;
            tipolicencia.Show();
        }

        private void tIPOSDEPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoPermiso tipopermiso = new frmTipoPermiso(string_ArchivoConfiguracion);
            tipopermiso.MdiParent = this;
            tipopermiso.Show();
        }

        private void lbPermisos_Click(object sender, EventArgs e)
        {
            frmPermiso permiso = new frmPermiso(string_ArchivoConfiguracion);
            permiso.MdiParent = this;
            permiso.Show();
        }

        private void lbOmisiones_Click(object sender, EventArgs e)
        {
            frmOmision omision = new frmOmision(string_ArchivoConfiguracion);
            omision.MdiParent = this;
            omision.Show();
        }

        private void lbVacaciones_Click(object sender, EventArgs e)
        {
            frmVacaciones vaca = new frmVacaciones(string_ArchivoConfiguracion);
            vaca.MdiParent = this;
            vaca.Show();
        }

   


        private void cbIPreloj_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCambiaReloj.Enabled = true; 
        }

        private void btnCambiaReloj_Click(object sender, EventArgs e)
        {
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);

            configXml_ArchivoConfiguracion.SetValue("principal", "ipmaquina", cbIPreloj.SelectedValue.ToString());


            frmCambiarIP ip = new frmCambiarIP(string_ArchivoConfiguracion);
            ip.CargarConfiguracionEquipo();
            MessageBox.Show("Ud Cambio la conexión del RELOJ con IP:" + cbIPreloj.SelectedValue.ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbVolcar_Click(object sender, EventArgs e)
        {
            CargarConfiguracionEquipo();
            frmVolcarDatos volcar = new frmVolcarDatos(1, a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
            if (volcar != null && volcar.bIsConnected)
                volcar.ShowDialog();
        }

    
        private void lbVolvar_Click(object sender, EventArgs e)
        {
            CargarConfiguracionEquipo();
            frmVolcarDatos volcar = new frmVolcarDatos(1, a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
            if (volcar != null && volcar.bIsConnected)
                volcar.ShowDialog();
        }

        private void gESTIONDEFOTOGRAFICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFotos fotos = new frmFotos(string_ArchivoConfiguracion);
            fotos.MdiParent = this;
            fotos.Show();
        }

        private void tOLERANCIASEVENTUALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToleranciaEventual tole = new frmToleranciaEventual(string_ArchivoConfiguracion);
            tole.MdiParent = this;
            tole.Show();
        }

        private void rEPORTEGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteGeneral reporte= new frmReporteGeneral(string_ArchivoConfiguracion);
            reporte.MdiParent=this;
            reporte.Show();
        }

        private void rESPALDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MysqlBackup())
                {
                    MessageBox.Show("RESPALDO DE DATOS CON EXITO", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("HUBO UN PROBLEMA AL RESPALDAR LA DATA, POR FAVOR INTENTELO NUEVAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool MysqlBackup()
        {
            try
            {
                SaveFileDialog fd;
                fd = new SaveFileDialog();
                fd.Filter = "sql Files (*.sql)|*.sql";
                fd.FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BKAsistencias" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".sql";

                DialogResult dialogo;
                dialogo = fd.ShowDialog();



                if (dialogo == DialogResult.OK)
                {

                    if (File.Exists("BDConfig.ini"))
                    {  //Existe archivo de configuracion de base de datos
                        FileStream stream = new FileStream("BDConfig.ini", FileMode.Open, FileAccess.ReadWrite);
                        StreamReader reader = new StreamReader(stream);
                        reader.ReadLine();
                        string Servidor = reader.ReadLine();
                        string DB = reader.ReadLine();
                        string usuario = reader.ReadLine();
                        string contrasenia = reader.ReadLine();
                        string mysqldump = reader.ReadLine();
                        string mysqlrestore = reader.ReadLine();
                        reader.Close();
                        if (fd.FileName != String.Empty)
                        {
                            try
                            {
                                String linea;
                                string fichero = fd.FileName;
                                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                                proc.EnableRaisingEvents = false;
                                proc.StartInfo.UseShellExecute = false;
                                proc.StartInfo.RedirectStandardOutput = true;
                                proc.StartInfo.FileName = mysqldump;
                                string argumentos = "--opt --hex-blob --routines " + DB + "  --single-transaction --host=" + Servidor + " --user=" + usuario + "  --password=" + contrasenia + "";
                                proc.StartInfo.Arguments = argumentos;
                                Process miProceso;
                                miProceso = Process.Start(proc.StartInfo);
                                StreamReader sr = miProceso.StandardOutput;
                                TextWriter tw = new StreamWriter(fd.FileName, false, Encoding.UTF8);
                                while ((linea = sr.ReadLine()) != null)
                                {
                                    tw.WriteLine(linea);
                                }
                                tw.Close();
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                            return false;
                    }
                    else
                    {

                                          
                        CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
                        string Servidor = configXml_ArchivoConfiguracion.GetValue("principal", "servidor", "localhost");
                        string DB = configXml_ArchivoConfiguracion.GetValue("principal", "database", "dbcontrolasistencia");
                        string usuario = configXml_ArchivoConfiguracion.GetValue("principal", "usuario", "root");
                        string contrasenia = configXml_ArchivoConfiguracion.GetValue("principal", "contrasenia", "mysql");
                        System.Environment.SpecialFolder folderProgramas = System.Environment.SpecialFolder.ProgramFiles;
                        System.Environment.SpecialFolder folderUsuarios = System.Environment.SpecialFolder.CommonApplicationData;
                        string ProgramMySQL = Environment.GetFolderPath(folderProgramas) + @"\MySQL\MySQL Server 5.5";
                        string mysqldump = configXml_ArchivoConfiguracion.GetValue("principal", "mysqldump", string.Format(@"{0}\bin\mysqldump.exe", ProgramMySQL));
                        string mysqlrestore = configXml_ArchivoConfiguracion.GetValue("principal", "mysql", string.Format(@"{0}\bin\mysql.exe", ProgramMySQL));


                        try
                        {
                            String linea;
                            string fichero = fd.FileName;
                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.EnableRaisingEvents = false;
                            proc.StartInfo.UseShellExecute = false;
                            proc.StartInfo.RedirectStandardOutput = true;
                            proc.StartInfo.FileName = mysqldump;
                            string argumentos = "--opt --hex-blob --routines=" + DB + "  --single-transaction --host=" + Servidor + " --user=" + usuario + "  --password=" + contrasenia + "";
                            proc.StartInfo.Arguments = argumentos;
                            Process miProceso;
                            miProceso = Process.Start(proc.StartInfo);
                            StreamReader sr = miProceso.StandardOutput;
                            TextWriter tw = new StreamWriter(fd.FileName, false, Encoding.UTF8);
                            while ((linea = sr.ReadLine()) != null)
                            {
                                tw.WriteLine(linea);
                            }
                            tw.Close();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }

                    }
                }
                else
                    return false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        private void rESTAURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MysqlRestore())
                {
                    MessageBox.Show("Restaurado de la Base de Datos realizado correctamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Hubo problemas al tratar de restaurar la Base de Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool MysqlRestore()
        {
            try
            {
                OpenFileDialog fd;
                fd = new OpenFileDialog();
                fd.Filter = "sql Files (*.sql)|*.sql";
                fd.FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                DialogResult dialogo;
                dialogo = fd.ShowDialog();

                if (dialogo == DialogResult.OK)
                {
                    if (fd.FileName != String.Empty)
                    {
                        if (File.Exists("BDConfig.ini"))
                        {  //Existe archivo de configuracion de base de datos
                            FileStream stream = new FileStream("BDConfig.ini", FileMode.Open, FileAccess.ReadWrite);
                            StreamReader reader = new StreamReader(stream);
                            reader.ReadLine();
                            string Servidor = reader.ReadLine();
                            string DB = reader.ReadLine();
                            string usuario = reader.ReadLine();
                            string contrasenia = reader.ReadLine();
                            string mysqldump = reader.ReadLine();
                            string mysqlrestore = reader.ReadLine();
                            reader.Close();
                            try
                            {
                                StreamReader file = new StreamReader(fd.FileName);
                                ProcessStartInfo proc = new ProcessStartInfo();
                                string cmdArgs = string.Format(@"-u{0} -p{1} -h{2} {3}", usuario, contrasenia, Servidor, DB);
                                proc.FileName = mysqlrestore;
                                proc.RedirectStandardInput = true;
                                proc.RedirectStandardOutput = false;
                                proc.Arguments = cmdArgs;
                                proc.UseShellExecute = false;
                                Process p = Process.Start(proc);
                                string res = file.ReadToEnd();
                                file.Close();
                                p.StandardInput.WriteLine(res);
                                p.Close();
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                        {
                            //System.Environment.SpecialFolder folder = System.Environment.CurrentDirectory;
                            //string string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
                            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
                            string Servidor = configXml_ArchivoConfiguracion.GetValue("principal", "servidor", "localhost");
                            string DB = configXml_ArchivoConfiguracion.GetValue("principal", "database", "dbcontrolasistencia");
                            string usuario = configXml_ArchivoConfiguracion.GetValue("principal", "usuario", "root");
                            string contrasenia = configXml_ArchivoConfiguracion.GetValue("principal", "contrasenia", "mysql");
                            System.Environment.SpecialFolder folderProgramas = System.Environment.SpecialFolder.ProgramFiles;
                            System.Environment.SpecialFolder folderUsuarios = System.Environment.SpecialFolder.CommonApplicationData;
                            string ProgramMySQL = Environment.GetFolderPath(folderProgramas) + @"\MySQL\MySQL Server 5.5";
                            string mysqldump = configXml_ArchivoConfiguracion.GetValue("principal", "mysqldump", string.Format(@"{0}\bin\mysqldump.exe", ProgramMySQL));
                            string mysqlrestore = configXml_ArchivoConfiguracion.GetValue("principal", "mysql", string.Format(@"{0}\bin\mysql.exe", ProgramMySQL));

                            try
                            {
                                StreamReader file = new StreamReader(fd.FileName);
                                ProcessStartInfo proc = new ProcessStartInfo();
                                string cmdArgs = string.Format(@"-u{0} -p{1} -h{2} {3}", usuario, contrasenia, Servidor, DB);
                                proc.FileName = mysqlrestore;
                                proc.RedirectStandardInput = true;
                                proc.RedirectStandardOutput = false;
                                proc.Arguments = cmdArgs;
                                proc.UseShellExecute = false;
                                Process p = Process.Start(proc);
                                string res = file.ReadToEnd();
                                file.Close();
                                p.StandardInput.WriteLine(res);
                                p.Close();
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        private void rEPORTEDELICENCIASYOPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteLicencias licen = new frmReporteLicencias(string_ArchivoConfiguracion);
            licen.MdiParent = this;
            licen.Show();
        }

        private void dATOSUSBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usb();
        }


        string string_DireccionProyecto;
        string string_NombreArchivo;
        public void usb()
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            // Displays an OpenFileDialog so the user can select a Cursor.

            
                openFileDialog1.Filter = "*.dat|*.dat";
                openFileDialog1.Title = "archivo";
                string_NombreArchivo = "1_attlog.bat";
                openFileDialog1.InitialDirectory = "E:\\";
               
                object[] VariablesNames = { "pDNI", "pFechaMarcacion", "pHoraMarcacion" };
                object[] VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion" };
                bool SeRegistro = false;
                bool SeHizoRollBack = false;
                string Mensaje = "";

                try
                {

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string_DireccionProyecto = openFileDialog1.FileName;

                        StreamReader objReader = new StreamReader(string_DireccionProyecto);
                        string sLine = "";
                        ArrayList arrText = new ArrayList();

                        while (sLine != null)
                        {
                            sLine = objReader.ReadLine();
                            if (sLine != null)
                                arrText.Add(sLine);
                        }
                        objReader.Close();

                        foreach (string sOutput in arrText)
                        {
                            char[] delimitadores = { ' ', ',', '.', '\t' };
                            string texto = sOutput.Trim();
                            string[] termino = texto.Split(delimitadores);


                            for (int i = 0; i < 3; i++)
                            {

                                VariablesValues[i] = termino[i];
                            }

                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuReg_RegistrarAsistenciaEmpleadoReloj", VariablesNames, VariablesValues);

                        }

                        ConexionBD.COMMIT();
                        SeRegistro = true;

                    }
                }

                catch (Exception ex)
                {
                    ConexionBD.ROLLBACK();
                    MessageBox.Show("Operacion Cancelada " + ex.Message);
                    SeRegistro = false;
                    SeHizoRollBack = true;
                }
                finally
                {
                    ConexionBD.Desconectar();
                }
                if (SeRegistro)
                    MessageBox.Show("Datos Importados Correctamente");
           
        }

        private void dATOSEXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportExcel excel = new frmImportExcel();
            excel.MdiParent = this;
            excel.Show();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItdecsa itdecsa = new frmItdecsa();
            itdecsa.ShowDialog();
        }








        
        
    }
}
