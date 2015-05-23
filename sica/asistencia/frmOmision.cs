using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Collections;

namespace asistencia
{
    public partial class frmOmision : Form
    {
      

        CValidacion ValidarDatos;
        CConection ConexionBD;

        ArrayList ListaMenuDiasOmision;
        object[] ParametrosRecuperarDiasConOmision = { "pDNI", "pMes", "pAnio" };
        object[] DatosRecuperarDiasConOmision = { "DNI", 01, 2011 };
        string string_ArchivoConfiguracion;
        public frmOmision(string ArchivoCOnfig)
        {
           
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            
            ConexionBD = new CConection();
            ListaMenuDiasOmision = new ArrayList();
            CargarDatosOmision();


            cbTipoOmision.Items.Add("ENTRADA");
            cbTipoOmision.Items.Add("SALIDA");
            cbTipoOmision.Items.Add("ENTRADA DE REFRIGERIO");
            cbTipoOmision.Items.Add("SALIDA DE REFRIGERIO");
            cbTipoOmision.SelectedIndex = 1;
           
            calend_CalendarioDiasConPermisos.MesAnioFecha_Changed += new ClaseCalendario.Calendario.MesCambiadoCambiadaEventHandler(ValorMesAnioFechaCambiado);
            
            calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] { DateTime.Now.Month, DateTime.Now.Year };


            // /*para los filtrados */
            //cbFiltrado.Items.Add("AREAS");
            //cbFiltrado.Items.Add("CARGOS");
            //cbFiltrado.Items.Add("SEXO");
            //cbFiltrado.Items.Add("MODALIDAD");

            //cbFiltrado.SelectedIndex = 0;

            calend_CalendarioDiasConPermisos.FechaActualHoy=DateTime.Now;
            limpiar();
        }

        public void CargarDatosOmision()
        {

            CargarDatos();

        }

        public void CargarDatos()
        {
            CargarsListaMenuPaCalendarioOmision();
            CargarOmisionEmpleadoMesCalendario();
        }
        //PARA ACTUALIZAR LOS CAMBIOS 
        public void ValorMesAnioFechaCambiado(int NuevoMes, int NuevoAnio, int OldMes, int OldAnio)
        {
            CargarOmisionEmpleadoMesCalendario();
        }

        //CARGA LAS OMISIONES DESDE LA BASE DE DATOS EN LAS FECHAS CORRESPONDIENTES
        public void CargarOmisionEmpleadoMesCalendario()
        {
            if (tbDNIper.Text.Trim() != "")
            {
                //ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
                DatosRecuperarDiasConOmision[0] = tbDNIper.Text.Trim();
                DatosRecuperarDiasConOmision[1] = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
                DatosRecuperarDiasConOmision[2] = calend_CalendarioDiasConPermisos.MesAnioFecha[1];


                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DataSet DiasConOmision = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_DiasConOmision", ParametrosRecuperarDiasConOmision, DatosRecuperarDiasConOmision);
                // Recupera DIA | MES | ANÑO | TIPODIA NOLABORAL
                //para determinara el tipo de omision



                for (int i = 0; i < DiasConOmision.Tables[0].Rows.Count; i++)
                {
                    string conOmision = "0";
                    string valorOmision=DiasConOmision.Tables[0].Rows[i][3].ToString();
                    if (valorOmision == "ENTRADA")
                    {
                        conOmision = "1";
                    }
                    if (valorOmision == "SALIDA DE REFRIGERIO")
                    {
                        conOmision = "2";
                    }
                    if (valorOmision =="ENTRADA DE REFRIGERIO")
                    {
                        conOmision = "3";
                    }
                    if (valorOmision == "SALIDA")
                    {
                        conOmision = "4";
                    }
                    calend_CalendarioDiasConPermisos.CambiarOpcionDia(conOmision, int.Parse(DiasConOmision.Tables[0].Rows[i][0].ToString()));
                }
                ConexionBD.Desconectar();
            }
        }

        // CARGA LAS OMISIONES DE CADA DIA ASIGNA LOS COLORES A LOS DIAS CON O SIN OMISION
        public void CargarsListaMenuPaCalendarioOmision()
        {
            ListaMenuDiasOmision = new ArrayList();
            object[] Opcion = new object[4];

            Opcion[0] = "0";
            Opcion[1] = "SIN OMISIÓN";
            Opcion[2] = Color.White;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            ListaMenuDiasOmision.Add(Opcion.Clone());


            Opcion[0] = "1";
            Opcion[1] = "OMISIÓN De ENTRADA";
            Opcion[2] = Color.OrangeRed;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            ListaMenuDiasOmision.Add(Opcion.Clone());

            Opcion[0] = "2";
            Opcion[1] = "OMISIÓN DE SALIDA A REFRIGERIOO";
            Opcion[2] = Color.DeepSkyBlue;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            ListaMenuDiasOmision.Add(Opcion.Clone());

            Opcion[0] = "3";
            Opcion[1] = "OMISIÓN DE ENTRADA DE REFRIGERIO";
            Opcion[2] = Color.YellowGreen;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            ListaMenuDiasOmision.Add(Opcion.Clone());

            Opcion[0] = "4";
            Opcion[1] = "OMISIÓN DE SALIDA";
            Opcion[2] = Color.Green;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            ListaMenuDiasOmision.Add(Opcion.Clone());


            calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ListaMenuDiasOmision;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDNI busca = new frmBuscarDNI(string_ArchivoConfiguracion);
            busca.ShowDialog();

            if (busca.pDNI.ToString().Length < 8)
            {
                if (busca.pDNI.ToString().Length == 5)
                {
                    tbDNIper.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 6)
                {
                    tbDNIper.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 7)
                {
                    tbDNIper.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNIper.Text = busca.pDNI;
            }
        }

        private void tbDNIper_TextChanged(object sender, EventArgs e)
        {
            /*PARA EL FILTRADO POR MODALIDADES*/
            object[] ParamNames = { "pDocumentoDNI", "pIdModalidad" };
            object[] ParamValues = { "pDocumentoDNI", "pIdModalidad" };

            ParamValues[0] = tbDNIper.Text;
            ParamValues[1] = clases.Cfunciones.Globales.privilegio;
            //CARGA DATOS PARA EL COMBO DE AREAS, PARA LAS ASIGNACIONES GRUPALES DE LICENCIAS
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            int filtraModalidad = ConexionBD.EjecutarProcedimientoReturnEntero("nuevo_verificaModalidad", ParamNames, ParamValues);
            ConexionBD.Desconectar();
            //FIN ASIGNACION GRUPAL

            if (tbDNIper.Text.Length == 8)
            {
                if (filtraModalidad == 1)
                {
                    lbNombre.Text = "";
                    BuscarDatosPersonal(tbDNIper.Text);
                    CargarDatosOmision();
                    numeroOmisiones();
                }
                else
                {
                    MessageBox.Show("UD. NO PUEDE HACER CAMBIOS DE ESTE USUARIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbNombre.Text = "";
                    tbDNIper.Text = "";
                }

            }
            else
            {
                tipo = Tipo.ninguno;
                habilitaBoton();
                limpiar();
            }
        }

        //determina elo numero de omisiones tomadas tiene una persona 
        public void numeroOmisiones()
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet datos = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_numeroOmisiones", "pDocumentoDNI", tbDNIper.Text.Trim());
            if (datos.Tables[0].Rows.Count > 0)
            {
                lbTomadas.Text = datos.Tables[0].Rows[0][0].ToString();
                ConexionBD.Desconectar();
            }
            else
            {
                lbTomadas.Text = "";
            }
        }


        private void limpiar()
        {
            
            tbNumeroDocumento.Text = "";
            lbNombre.Text = "";
            lbTomadas.Text = "";
            tbDNIper.Focus();
            tbDNIper.Select();
        }

        private void tbDNIper_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        //METODO BUSCAR
        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                object[] DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    lbNombre.Text = DatosPersonal[2].ToString() + " " + DatosPersonal[3].ToString() + " " + DatosPersonal[4].ToString();
                    tipo = Tipo.guardar;
                    habilitaBoton();          
                }
                else
                {
                    lbNombre.Text = "";
                }
            }
        }


        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar, ninguno
        }
        private Tipo tipo;




        private void habilitaBoton()
        {
            btnGuardar.Enabled = tipo == Tipo.guardar;
            calend_CalendarioDiasConPermisos.Enabled = tipo == Tipo.guardar;
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNumeroDocumento.Text != "")
            {
                GuardarOmisionEmpleado();
                calend_CalendarioDiasConPermisos.ActualizarDiasCalendario();
                CargarOmisionEmpleadoMesCalendario();
                tbNumeroDocumento.Text = "";
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR EL NUMERO O CODIGO DEL DOCUMENTO PARA GUARDAR LAS OMISIONES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumeroDocumento.Focus();

            }


        }

        //METODO PARA GUARDAR LOS VALORES DE LA OMISION
        private void GuardarOmisionEmpleado()
        {
            if (tbDNIper.Text.Length == 8)
            {

                object[] DatosGuardarDiaConOmision = { "pDNI", "pTipoOmision", "pFechaOmision", "pDocumento", "idTipoOmision" };
                object[] ValuesGuardarDiaConOmision = { "pDNI", "pTipoOmision", "pFechaOmision", "pDocumento", "idTipoOmision" };

                int pMes = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
                int pAnio = calend_CalendarioDiasConPermisos.MesAnioFecha[1];

                string[] sa_DiasMesOpciones = calend_CalendarioDiasConPermisos.DiasMesConOpciones;
                int i_NroDiasMes = calend_CalendarioDiasConPermisos.i_NroDiasMes;

                bool boolHecho = false;
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);

                ValuesGuardarDiaConOmision[0] = tbDNIper.Text.Trim();

                try
                {
                    for (int i = 0; i < i_NroDiasMes; i++)
                    {
                        ValuesGuardarDiaConOmision[1] = cbTipoOmision.SelectedItem;
                        ValuesGuardarDiaConOmision[2] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1);
                        ValuesGuardarDiaConOmision[3] = tbNumeroDocumento.Text;
                        ValuesGuardarDiaConOmision[4] = sa_DiasMesOpciones[i];
                        ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_guardarOmision", DatosGuardarDiaConOmision, ValuesGuardarDiaConOmision);
                    }
                    ConexionBD.COMMIT();
                    boolHecho = true;
                }
                catch (Exception ex)
                {
                    ConexionBD.ROLLBACK();
                    boolHecho = false;
                }
                finally
                {
                    ConexionBD.Desconectar();
                }
                if (boolHecho)
                {
                    MessageBox.Show("OMISIONES DEL EMPLEADO GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumeroDocumento.Text = "";
                }
                else
                    MessageBox.Show("NO SE PUDO GUARDAR LAS OMISIONES DEL PERSONAL", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ANTES DE GUARDAR LOS VALORES, PREVIAMENTE DEBE SELECCIONAR UN TRABAJADOR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDNIper.Focus();
            }

        }

        private void btnGrupales_Click(object sender, EventArgs e)
        {
            frmOmisionesGrupales omisionesG = new frmOmisionesGrupales(string_ArchivoConfiguracion);
            omisionesG.ShowDialog();
        }





    }
}
