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
    public partial class frmPermiso : Form
    {
      


        CValidacion ValidarDatos;
        CConection ConexionBD;
       
        ArrayList ListaMenuDiasPermisoReales;
        object[] ParametrosRecuperarDiasConPermiso = { "pDNI", "pMes", "pAnio" };
        object[] DatosRecuperarDiasConPermiso = { "DNI", 01, 2011 };
     
        string string_ArchivoConfiguracion;
        public frmPermiso(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            ListaMenuDiasPermisoReales = new ArrayList();
            CargarDatosPersonalYPermisosReales();

           
            calend_CalendarioDiasConPermisos.MesAnioFecha_Changed += new ClaseCalendario.Calendario.MesCambiadoCambiadaEventHandler(ValorMesAnioFechaCambiado);
            
            calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] { DateTime.Now.Month, DateTime.Now.Year };

            calend_CalendarioDiasConPermisos.FechaActualHoy = DateTime.Now;
        }


        public void CargarDatosPersonalYPermisosReales()
        {

            CargarDatos();

        }
        public void CargarDatos()
        {
            //CargarTiposDePermiso();
            CargarListaMenuPaCalendarioPermisos();
            CargarPermisosEmpleadoMesCalendario();
            
        }
        public void ValorMesAnioFechaCambiado(int NuevoMes, int NuevoAnio, int OldMes, int OldAnio)
        {
            CargarPermisosEmpleadoMesCalendario();
        }



        public void CargarPermisosEmpleadoMesCalendario()
        {
            if (tbDNIper.Text.Trim() != "")
            {
                //ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
                DatosRecuperarDiasConPermiso[0] = tbDNIper.Text.Trim();
                DatosRecuperarDiasConPermiso[1] = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
                DatosRecuperarDiasConPermiso[2] = calend_CalendarioDiasConPermisos.MesAnioFecha[1];


                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DataSet DiasConPermisos = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_DiasConPermisoEmpleadoMesAnio", ParametrosRecuperarDiasConPermiso, DatosRecuperarDiasConPermiso);
                // Recupera DIA | MES | ANÑO | TIPODIA NOLABORAL            
                for (int i = 0; i < DiasConPermisos.Tables[0].Rows.Count; i++)
                {
                    calend_CalendarioDiasConPermisos.CambiarOpcionDia(DiasConPermisos.Tables[0].Rows[i][3].ToString(), int.Parse(DiasConPermisos.Tables[0].Rows[i][0].ToString()));
                }
                ConexionBD.Desconectar();
            }
        }
       
        DataSet pds_TiposDePermiso;//decalramos el data set para guardar las configuraciones de color del calendario
        public void CargarListaMenuPaCalendarioPermisos()
        {
        ;
            object[] Opcion = new object[4];

            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            string ParamName = "pValor";
            string ParamValue = "P";// P DE PERMISO
            pds_TiposDePermiso = ConexionBD.EjecutarProcedimientoReturnDataSet("spupri_ListarTiposDePermiso", ParamName, ParamValue);



             for (int i = 0; i < pds_TiposDePermiso.Tables[0].Rows.Count; i++)
            {
                Opcion[0] = pds_TiposDePermiso.Tables[0].Rows[i][0];
                Opcion[1] = pds_TiposDePermiso.Tables[0].Rows[i][1];
                if (Opcion[0].ToString().Trim() == "2")
                    Opcion[2] = Color.White;
                else
                {
                    if (Convert.ToInt32(pds_TiposDePermiso.Tables[0].Rows[i][2]) == 0)
                    {
                        Opcion[2] = Color.Firebrick;
                    }
                    if (Convert.ToInt32(pds_TiposDePermiso.Tables[0].Rows[i][2]) == 1)
                    {
                        Opcion[2] = Color.SkyBlue;
                    }

                }
                Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);
                ListaMenuDiasPermisoReales.Add(Opcion.Clone());
            }

            calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ListaMenuDiasPermisoReales;
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
                    CargarDatosPersonalYPermisosReales();
                }
                else
                {
                    MessageBox.Show("UD. NO PUEDE HACER CAMBIOS DE ESTE USUARIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDNIper.Text = "";
                    lbNombre.Text = "";
                }
            }
            else
            {
                tipo = Tipo.ninguno;
                habilitaBoton();
                limpiar();
            }
        }


        private void limpiar()
        {
            tbNumeroDocumento1.Text = "";
            nudHoraFIn1.Value = 0;
            nudHoraInicio1.Value = 0;
            nudMInutoFin1.Value = 0;
            nudMinutoIni1.Value = 0;
            tbDNIper.Focus();
            tbDNIper.Select();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbDNIper.Text.Length == 8)
            {
                int HoraInicioAux = ((int)nudHoraInicio1.Value) * 60 + (int)nudMinutoIni1.Value;
                int HoraFinAux = ((int)nudHoraFIn1.Value) * 60 + (int)nudMInutoFin1.Value;
                if (HoraInicioAux < HoraFinAux)
                {
                    if (tbNumeroDocumento1.Text != "")
                    {
                        GuardarPermisosEmpleado();
                        calend_CalendarioDiasConPermisos.ActualizarDiasCalendario();
                        CargarPermisosEmpleadoMesCalendario();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("DEBE INGRESAR EL NUMERO O CODIGO DE LA PAPELETA PARA ASIGNAR EL PERMISO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNumeroDocumento1.Focus();
                        nudHoraFIn1.Value = 0;
                        nudHoraInicio1.Value = 0;
                        nudMinutoIni1.Value = 0;
                        nudMInutoFin1.Value = 0;

                    }
                }
                else
                {
                    MessageBox.Show("LA HORA INICIO O MINUTO INICIO DEBE SER MAYOR QUE HORA FIN O MINUTO FIN", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumeroDocumento1.Focus();

                }
            }
            else
            {
                MessageBox.Show("ANTES DE GUARDAR LOS VALORES, PREVIAMENTE DEBE SELECCIONAR UN TRABAJADOR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDNIper.Focus();

            }
        }





        bool bandera = false;//variable para indicar que se esta modificaindo
        private void GuardarPermisosEmpleado()
        {
            if (tbDNIper.Text.Trim() != "")
            {
                object[] DatosGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };
                object[] ValuesGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };


                //---------PARTA LA VERIFICACION INDIVIDUAL DE UNA LICENCIA-------------// 
                object[] DatosIndividual = { "pDNI", "pFechaPermiso", "pIdTipoPermiso", "pTipo" };
                object[] ValoresIndividual = { "pDNI", "pFechaPermiso", "pIdTipoPermiso", "pTipo" };
                //----------fin LIMITACION INDIVIDUAL---------///


                int pMes = calend_CalendarioDiasConPermisos.MesAnioFecha[0];
                int pAnio = calend_CalendarioDiasConPermisos.MesAnioFecha[1];

                string[] sa_DiasMesOpciones = calend_CalendarioDiasConPermisos.DiasMesConOpciones;
                int i_NroDiasMes = calend_CalendarioDiasConPermisos.i_NroDiasMes;

                bool boolHecho = false;
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);


                ValoresIndividual[0] = tbDNIper.Text.Trim();//para la consulta de los limites
                ValuesGuardarDiaConPermiso[0] = tbDNIper.Text.Trim();

                try
                {
                    for (int i = 0; i < i_NroDiasMes; i++)
                    {
                        /*--------PARA LA AVERIFICACION INDIVIDUAL------*/
                        ValoresIndividual[1] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1);
                        ValoresIndividual[2] = sa_DiasMesOpciones[i];
                        ValoresIndividual[3] = "P";//L de LICENCIA
                        ;
                        /*-----------fin VERIFICACION---------*/

                        ValuesGuardarDiaConPermiso[1] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1); ;
                        ValuesGuardarDiaConPermiso[2] = sa_DiasMesOpciones[i];
                        ValuesGuardarDiaConPermiso[3] = nudHoraInicio1.Value.ToString().Trim() + ":" + nudMinutoIni1.Value.ToString().Trim() + ":00";
                        ValuesGuardarDiaConPermiso[4] = nudHoraFIn1.Value.ToString().Trim() + ":" + nudMInutoFin1.Value.ToString().Trim() + ":00";
                        ValuesGuardarDiaConPermiso[5] = "P";//P DE PERMISO
                        ValuesGuardarDiaConPermiso[6] = tbNumeroDocumento1.Text;


                        if (bandera)
                        {
                            if (Convert.ToInt32(sa_DiasMesOpciones[i]) == 2)
                            {
                                /*con esta verificacion podremos saber si hubo o no cambios en el calendartios por dia 
                        ejemplo: si al dia 2 se le asisna otro valos que el que tenia inicialmente se denorta cambio 
                        si no ocurre ningun cambio se le denota sin cambios:
                        la respuesta de ---verificacionIndividual--- sera: 
                        0 = SI NO SE VERIFICA CAMBIO ALGUNO
                        1 = SI SE VERIFICA CAMBIO ALGUNO
                        */
                                int verificacionIndividual = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimiteIndividual", DatosIndividual, ValoresIndividual);
                                /*--- FIN VERIFICACION CAMBIOS---------*/
                                if (verificacionIndividual == 1)
                                {
                                    ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasPermisoEmpleado", DatosGuardarDiaConPermiso, ValuesGuardarDiaConPermiso);
                                }
                            }
                            else
                                MessageBox.Show("ERROR EN EL DIA: " + (i + 1) + "\n EL BOTON MODIFICAR SOLO QUITA LAS LICENCIAS, PARA CAMBIAR A OTRA LICENCIA DIFERENTE DEL QUE YA ASIGNO ANTERIORMENTE, UTILICE EL BOTON GUARDAR, DEBIDO A QUE TAMBIEN DEBE MODIFIACAR O PRESERVAR EL NÚMERO DEL DOCUMENTO O PAPELETA ASIGNADA AL PERSONAL", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            /*con esta verificacion podremos saber si hubo o no cambios en el calendartios por dia 
                        ejemplo: si al dia 2 se le asisna otro valos que el que tenia inicialmente se denorta cambio 
                        si no ocurre ningun cambio se le denota sin cambios:
                        la respuesta de ---verificacionIndividual--- sera: 
                        0 = SI NO SE VERIFICA CAMBIO ALGUNO
                        1 = SI SE VERIFICA CAMBIO ALGUNO
                        */
                            int verificacionIndividual = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimiteIndividual", DatosIndividual, ValoresIndividual);
                            /*--- FIN VERIFICACION CAMBIOS---------*/
                            if (verificacionIndividual == 1)
                            {
                                ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasPermisoEmpleado", DatosGuardarDiaConPermiso, ValuesGuardarDiaConPermiso);
                            }
                        }





                    }

                    bandera = false;
                    ConexionBD.COMMIT();
                    boolHecho = true;
                }
                catch
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
                    MessageBox.Show("PERMISOS DEL EMPLEADO GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumeroDocumento1.Text = "";
                }
                else
                    MessageBox.Show("NO SE PUDO GUARDAR LOS PERMISOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("DEBE SELECCIONAR A UN EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    }
}
