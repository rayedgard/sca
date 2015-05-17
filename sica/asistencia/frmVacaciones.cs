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
    public partial class frmVacaciones : Form
    {
        CValidacion ValidarDatos;
        CConection ConexionBD;
        ArrayList ListaMenuDiasPermiso;
        object[] ParametrosRecuperarDiasConPermiso = { "pDNI", "pMes", "pAnio" };
        object[] DatosRecuperarDiasConPermiso = { "DNI", 01, 2012 };
        string string_ArchivoConfiguracion;
        public frmVacaciones(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            ListaMenuDiasPermiso = new ArrayList();
            CargarDatosPersonalYPermisos();

            calend_CalendarioDiasConPermisos.MesAnioFecha_Changed += new ClaseCalendario.Calendario.MesCambiadoCambiadaEventHandler(ValorMesAnioFechaCambiado);

            calend_CalendarioDiasConPermisos.FechaActualHoy = DateTime.Now;
        }


        public void CargarDatosPersonalYPermisos()
        {
            
            CargarDatos();

            calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] { DateTime.Now.Month, DateTime.Now.Year };

        }
        private void CargarDatos()
        {
            CargarPermisosEmpleadoMesCalendario();
            CargarTiposDePermisos();
        }

        public void ValorMesAnioFechaCambiado(int NuevoMes, int NuevoAnio, int OldMes, int OldAnio)
        {
            CargarPermisosEmpleadoMesCalendario();
        }

        public void CargarPermisosEmpleadoMesCalendario()
        {
            calend_CalendarioDiasConPermisos.ColorearTodoDiaLaboral();
            //if (cbEmpleado.Text != "" && cbEmpleado.SelectedValue != null && cbEmpleado.SelectedIndex >= 0)
            //{
            //ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
            DatosRecuperarDiasConPermiso[0] = tbDNI.Text.Trim();
            DatosRecuperarDiasConPermiso[1] = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
            DatosRecuperarDiasConPermiso[2] = calend_CalendarioDiasConPermisos.MesAnioFecha[1];

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet DiasConPermisos = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_DiasConVacacionEmpleadoMesAnio", ParametrosRecuperarDiasConPermiso, DatosRecuperarDiasConPermiso);
            // Recupera DIA | MES | ANÑO | TIPODIA NOLABORAL            
            for (int i = 0; i < DiasConPermisos.Tables[0].Rows.Count; i++)
            {
                calend_CalendarioDiasConPermisos.CambiarOpcionDia(DiasConPermisos.Tables[0].Rows[i][3].ToString(), int.Parse(DiasConPermisos.Tables[0].Rows[i][0].ToString()));
            }
            ConexionBD.Desconectar();
            //}
        }


        private void CargarTiposDePermisos()
        {
            CargarsListaMenuPaCalendarioPermisos();
        }
        public void CargarsListaMenuPaCalendarioPermisos()
        {
            ListaMenuDiasPermiso = new ArrayList();
            object[] Opcion = new object[4];

            Opcion[0] = "0";
            Opcion[1] = "TRABAJO";
            Opcion[2] = Color.White;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Calender);

            ListaMenuDiasPermiso.Add(Opcion.Clone());


            Opcion[0] = "1";
            Opcion[1] = "VACACION";
            Opcion[2] = Color.Green;
            Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Calender);

            ListaMenuDiasPermiso.Add(Opcion.Clone());


            calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ListaMenuDiasPermiso;
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

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
         
            /*PARA EL FILTRADO POR MODALIDADES*/
            object[] ParamNames = { "pDocumentoDNI", "pIdModalidad" };
            object[] ParamValues = { "pDocumentoDNI", "pIdModalidad" };

            ParamValues[0] = tbDNI.Text;
            ParamValues[1] = clases.Cfunciones.Globales.privilegio;///2 PARA LOS PRIVILEGIOS DE NOMBRADOS Y CAS// 1 PARA LOS PRIVILEGIOS DE INVERSION // 0 PARA LOS PRIVILEGIOS TOTALES
            //CARGA DATOS PARA EL COMBO DE AREAS, PARA LAS ASIGNACIONES GRUPALES DE LICENCIAS
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            int filtraModalidad = ConexionBD.EjecutarProcedimientoReturnEntero("nuevo_verificaModalidad", ParamNames, ParamValues);
            ConexionBD.Desconectar();
            //FIN ASIGNACION GRUPAL

            if (tbDNI.Text.Length == 8)
            {
                if (filtraModalidad == 1)
                {
                    lbNombre.Text = "";
                    BuscarDatosPersonal(tbDNI.Text);
                    CargarDatosPersonalYPermisos();
                    listaVacacion();
                    btnAsignar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("UD. NO PUEDE HACER CAMBIOS DE ESTE USUARIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDNI.Text = "";
                    lbNombre.Text = "";
                }

            }
            else
            {
                tipo = Tipo.ninguno;
                habilitaBoton();
                lbNombre.Text = "";

            }

        }


        public void listaVacacion()
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet datos = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_listaVacacion", "pDocumentoDNI", tbDNI.Text.Trim());
            if (datos.Tables[0].Rows.Count > 0)
            {
                lbTomadas.Text = datos.Tables[0].Rows[0][1].ToString();
                lbRestantes.Text = (Convert.ToInt32(datos.Tables[0].Rows[0][0]) - Convert.ToInt32(datos.Tables[0].Rows[0][1])).ToString();
                ConexionBD.Desconectar();
            }
            else
            {
                lbRestantes.Text = "";
                lbTomadas.Text = "";
            }
        }


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDNI busca = new frmBuscarDNI(string_ArchivoConfiguracion);
            busca.ShowDialog();

            if (busca.pDNI.ToString().Length < 8)
            {
                if (busca.pDNI.ToString().Length == 5)
                {
                    tbDNI.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 6)
                {
                    tbDNI.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 7)
                {
                    tbDNI.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNI.Text = busca.pDNI;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNumeroDocumento.Text != "")
            {
                GuardarPermisosEmpleado();
                calend_CalendarioDiasConPermisos.ActualizarDiasCalendario();
                CargarPermisosEmpleadoMesCalendario();
                listaVacacion();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR EL NUMERO O CODIGO DEL DOCUMENTO PARA ASIGNAR LAS VACACIONES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumeroDocumento.Focus();
            }
        }


        private void GuardarPermisosEmpleado()
        {
            if (tbDNI.Text != "")
            {
                object[] DatosGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoVacacion", "pDocumento" };
                object[] ValuesGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoVacacion", "pDocumento" };

                int pMes = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
                int pAnio = calend_CalendarioDiasConPermisos.MesAnioFecha[1];

                string[] sa_DiasMesOpciones = calend_CalendarioDiasConPermisos.DiasMesConOpciones;
                int i_NroDiasMes = calend_CalendarioDiasConPermisos.i_NroDiasMes;

                bool boolHecho = false;
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);

                ValuesGuardarDiaConPermiso[0] = tbDNI.Text.Trim();

                try
                {
                    for (int i = 0; i < i_NroDiasMes; i++)
                    {
                        ValuesGuardarDiaConPermiso[1] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1);
                        ValuesGuardarDiaConPermiso[2] = sa_DiasMesOpciones[i];
                        ValuesGuardarDiaConPermiso[3] = tbNumeroDocumento.Text;
                        ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasVacacionEmpleado", DatosGuardarDiaConPermiso, ValuesGuardarDiaConPermiso);
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
                    MessageBox.Show("VACACIONES DEL EMPLEADO GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumeroDocumento.Text = "";
                }
                else
                    MessageBox.Show("NO SE PUDO GUARDAR LAS VACACIONES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("DEBE SELECCIONAR A UN EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            clases.Cfunciones.Globales.dni = tbDNI.Text;
            clases.Cfunciones.Globales.NombresYapellidos = lbNombre.Text;
            frmNuevoVacaciones vaca = new frmNuevoVacaciones(string_ArchivoConfiguracion);
            vaca.ShowDialog();
            listaVacacion();
        }


    }
}
