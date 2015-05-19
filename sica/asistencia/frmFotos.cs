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
    public partial class frmFotos : Form
    {
        string string_ArchivoConfiguracion;
        private CConection ConexionBD;

        public frmFotos(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            dtpFechaInicio.Value = DateTime.Now.AddDays(-730);
            dtpFechaFin.Value = DateTime.Now.AddDays(-365);
            ConexionBD = new CConection();
        }

        private void btnCargarFotos_Click(object sender, EventArgs e)
        {
            fbd_ExaminarCarpeta = new FolderBrowserDialog();
            if (fbd_ExaminarCarpeta.ShowDialog() == DialogResult.OK)
            {
                object[] VariablesNames = { "pDNI", "pFechaMarcacion", "pHoraMarcacion", "pFotoRegistro" };
                object[] VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion", "pFotoRegistro" };
                
                string[] FotosEnCarpeta = System.IO.Directory.GetFiles(fbd_ExaminarCarpeta.SelectedPath);
                if (FotosEnCarpeta != null && FotosEnCarpeta.Length > 0)
                {                    
                    bool SeRegistro = false;
                    try
                    {
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        int NroArchivos = FotosEnCarpeta.Length;
                        string Mensaje = "HECHO";

                        for (int i = 0; i < NroArchivos; i++)
                        {
                            VariablesValues = DevolverVariablesNombreFoto(FotosEnCarpeta[i]);
                            if (VariablesValues != null)
                            {
                                Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuReg_GuardarFotoEmpleadoReloj", VariablesNames, VariablesValues);
                                if (Mensaje == "ERROR")
                                    break;
                            }
                        }
                        ConexionBD.COMMIT();
                        SeRegistro = true;
                    }
                    catch (Exception ex)
                    {
                        ConexionBD.ROLLBACK();
                        MessageBox.Show("Operacion Cancelada " + ex.Message);
                        SeRegistro = false;
                    }
                    finally
                    {
                        ConexionBD.Desconectar();
                    }
                    if (SeRegistro)
                        MessageBox.Show("Fotos Cargadas Correctamente");
                }
                else
                    MessageBox.Show("No hubo ninguna foto para cargar");
            }
        }

        private object[] DevolverVariablesNombreFoto(string UbicacionArchivo)
        {
            Image pFotoDefault = (System.Drawing.Image)(asistencia.Properties.Resources.anonymous);
            Image pFotoRegistro = pFotoDefault;
            //object[] VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion", "pFotoRegistro" };                
            //20111010203904-56756577.jpg
            string DNI = "";
            int Anio = -1;
            int Mes = -1;
            int Dia = -1;
            int Hora = -1;
            int Minuto = -1;
            int Segundo = -1;
            bool EsFotoDeReloj = false;
            object[] VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion", "pFotoRegistro" };

            if (UbicacionArchivo.EndsWith(".jpg") || UbicacionArchivo.EndsWith(".jpeg") || UbicacionArchivo.EndsWith(".png"))
            {
                string NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(UbicacionArchivo);
                if (NombreArchivo.Contains("-"))
                {
                    string[] fechadni = NombreArchivo.Split('-');
                    if (fechadni != null && fechadni.Length == 2 && fechadni[0].Length==14)
                    {
                        DNI = fechadni[1];
                        string panio = fechadni[0].Substring(0, 4);
                        int.TryParse(panio, out Anio);

                        string pmes = fechadni[0].Substring(4,2);
                        int.TryParse(pmes, out Mes);

                        string pdia = fechadni[0].Substring(6, 2);
                        int.TryParse(pdia, out Dia);

                        if (Anio > 2010 && Mes > 0 && Mes<13 && Dia > 0 && Dia<32)
                        {
                            string phora = fechadni[0].Substring(8, 2);
                            int.TryParse(phora,out Hora);

                            string pminuto = fechadni[0].Substring(10, 2);
                            int.TryParse(pminuto, out Minuto);

                            string psegundo = fechadni[0].Substring(12, 2);
                            int.TryParse(psegundo, out Segundo);

                            if (Hora >= 0 && Hora < 24 && Minuto >= 0 && Minuto < 60 && Segundo >= 0 && Segundo < 60)
                            {                                
                                try
                                {
                                    pFotoRegistro = Image.FromFile(UbicacionArchivo);
                                    EsFotoDeReloj = true;
                                }
                                catch
                                {
                                    EsFotoDeReloj = false;
                                    pFotoRegistro = pFotoDefault;
                                }
                            }
                        }
                    }
                }
            }

            if (EsFotoDeReloj)
            {
                //VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion", "pFotoRegistro" };                
                VariablesValues[0] = DNI;
                VariablesValues[1] = string.Format("{0}-{1}-{2}",Anio,Mes,Dia);
                VariablesValues[2] = string.Format("{0}:{1}:{2}", Hora, Minuto, Segundo);
                VariablesValues[3] = ConexionBD.Image2Bytes(pFotoRegistro);
                return VariablesValues;
            }
            else
                return null;
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTA SEGURO QUE QUIERE ELIMINAR LOS REGISTROS DE ASISTENCIA,\r\n PERMISOS Y FOTOS CARGADAS", "CUIDADO!!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                object[] VariablesNames = { "pFechaInicio", "pFechaFin" };
                object[] VariablesValues = { string.Format("{0}-{1}-{2}", dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day), string.Format("{0}-{1}-{2}", dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day) };

                bool SeRegistro = false;
                try
                {
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    string Mensaje = "HECHO";
                    Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuReg_EliminarRegistrosBaseDatos", VariablesNames, VariablesValues);
                    ConexionBD.COMMIT();
                    SeRegistro = true;
                }
                catch (Exception ex)
                {
                    ConexionBD.ROLLBACK();
                    MessageBox.Show("Operacion Cancelada " + ex.Message);
                    SeRegistro = false;
                }
                finally
                {
                    ConexionBD.Desconectar();
                }
                if (SeRegistro)
                    MessageBox.Show("Registros Eliminados Correctamente");
            }
        }

        private void btnVisualizarFotos_Click(object sender, EventArgs e)
        {
            frmVisorFotos formVisor = new frmVisorFotos(string_ArchivoConfiguracion);
            formVisor.ShowDialog();
        }
    }
}
