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
    public partial class frmVisorFotos : Form
    {
        string string_NOmbreArchivoConfiguracion = "";
        private CConection ConexionBD;

        public frmVisorFotos(string pstring_NOmbreArchivoConfiguracion)
        {
            InitializeComponent();
            ConexionBD = new CConection();
            string_NOmbreArchivoConfiguracion = pstring_NOmbreArchivoConfiguracion;
        }

        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            paVisorFotos.Controls.Clear();
            object[] VariablesNames = { "pDNI","pFechaInicio", "pFechaFin" };
            string pDNI = tbDNI.Text;
            if (pDNI.Trim() == "")
                pDNI = "-1";
            object[] VariablesValues = { pDNI, string.Format("{0}-{1}-{2}", dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day), string.Format("{0}-{1}-{2}", dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day) };

            try
            {
                ConexionBD.Conectar(false, string_NOmbreArchivoConfiguracion);
                DataSet dsFotografias = ConexionBD.EjecutarProcedimientoReturnDataSet("spuReg_RecuperarFotosSistema", VariablesNames, VariablesValues);
                if (dsFotografias != null && dsFotografias.Tables[0] != null && dsFotografias.Tables[0].Rows != null && dsFotografias.Tables[0].Rows.Count > 0)
                {
                    int NroFotos = dsFotografias.Tables[0].Rows.Count;
                    int FotosCargadas = 0;
                    int posY = 4;
                    int posX = 4;

                    for (int i = 0; i < NroFotos; i++)
                    {
                        foto NuevaFoto = new foto();
                        Image fotoCapturada = null;
                        try
                        {
                            fotoCapturada = ConexionBD.Bytes2Image((byte[])dsFotografias.Tables[0].Rows[i][0]);
                        }
                        catch
                        {
                            fotoCapturada = (System.Drawing.Image)(asistencia.Properties.Resources.user_male);
                        }

                        string pDNIRecuperado = dsFotografias.Tables[0].Rows[i][1].ToString();
                        string pNombres = dsFotografias.Tables[0].Rows[i][2].ToString();
                        string pFecha = dsFotografias.Tables[0].Rows[i][3].ToString();

                        NuevaFoto.AsignarFoto(pDNIRecuperado, pNombres, pFecha, fotoCapturada);

                        paVisorFotos.Controls.Add(NuevaFoto);
                        NuevaFoto.Left = posX;
                        NuevaFoto.Top = posY;

                        posX = posX + 157;
                        FotosCargadas++;

                        if (FotosCargadas == 3)
                        {
                            posX = 4;
                            FotosCargadas = 0;
                            posY = posY + 234;
                        }


                    }
                }
            }
            catch
            {                
            }
            finally
            {                
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarDatosPersonal(tbDNI.Text);
        }

        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 4)
            {
                ConexionBD.Conectar(false, string_NOmbreArchivoConfiguracion);
                object[] DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    tbNombreUsuario.Text = DatosPersonal[2].ToString() + " " + DatosPersonal[3].ToString() + " " + DatosPersonal[4].ToString();
                    try
                    {
                        pbFoto.Image = ConexionBD.Bytes2Image((byte[])DatosPersonal[6]);
                    }
                    catch
                    {
                        pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.user_male);
                    }
                }
                else
                {
                    tbDNI.Text = "";
                    pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.user_male);
                    tbNombreUsuario.Text = "";
                }
            }
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.user_male);
            tbNombreUsuario.Text = "";
            BuscarDatosPersonal(tbDNI.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarDNI busca = new frmBuscarDNI(string_NOmbreArchivoConfiguracion);
            busca.ShowDialog();
            
            if (busca.pDNI.ToString().Length < 4)
            {
                if (busca.pDNI.ToString().Length == 1)
                {
                    tbDNI.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 2)
                {
                    tbDNI.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 3)
                {
                    tbDNI.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNI.Text = busca.pDNI;
            }
        }
    }
}

