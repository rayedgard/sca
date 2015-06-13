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
    public partial class frmLicencia : Form
    {
      

        CValidacion ValidarDatos;
        CConection ConexionBD;
      
        ArrayList ListaMenuDiasPermiso;
        object[] ParametrosRecuperarDiasConPermiso = {"pDNI","pMes","pAnio"};
        object[] DatosRecuperarDiasConPermiso = { "DNI",01, 2011 };
        string string_ArchivoConfiguracion;

        public frmLicencia(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            ListaMenuDiasPermiso = new ArrayList();
            CargarDatosPersonalYPermisos();

            calend_CalendarioDiasConPermisos.MesAnioFecha_Changed += new ClaseCalendario.Calendario.MesCambiadoCambiadaEventHandler(ValorMesAnioFechaCambiado);

            calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] { DateTime.Now.Month, DateTime.Now.Year };


            calend_CalendarioDiasConPermisos.FechaActualHoy = DateTime.Now;
       
      

        }


        public void CargarDatosPersonalYPermisos()
        {

            CargarDatos();

        }

        public void ValorMesAnioFechaCambiado(int NuevoMes, int NuevoAnio, int OldMes, int OldAnio)
        {
            CargarPermisosEmpleadoMesCalendario();
        }

        private void CargarDatos()
        {
            //CargarTiposDePermiso();
            CargarListaMenuPaCalendarioPermisos();
            CargarPermisosEmpleadoMesCalendario();
            
        }

        public void CargarPermisosEmpleadoMesCalendario()
        {
            if (tbDNI.Text != "")
            {
                //ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
                DatosRecuperarDiasConPermiso[0] = tbDNI.Text.Trim();
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


        DataSet pds_TiposDePermiso;
        public void CargarListaMenuPaCalendarioPermisos()
        {
            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            string ParamName = "pValor";
            string ParamValue = "L";// L DE LICENCIA
            pds_TiposDePermiso = ConexionBD.EjecutarProcedimientoReturnDataSet("spupri_ListarTiposDePermiso", ParamName, ParamValue);

            ListaMenuDiasPermiso = new ArrayList();
         
            object[] Opcion = new object[4];

            for (int i = 0; i < pds_TiposDePermiso.Tables[0].Rows.Count; i++)
            {
                Opcion[0] = pds_TiposDePermiso.Tables[0].Rows[i][0];
                Opcion[1] = pds_TiposDePermiso.Tables[0].Rows[i][1];
                if (Opcion[0].ToString().Trim() == "1")
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
                Opcion[3] = (System.Drawing.Image)(asistencia.Properties.Resources._11);
                ListaMenuDiasPermiso.Add(Opcion.Clone());
            }

            calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ListaMenuDiasPermiso;

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

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbDNI.Text.Length == 8)
            {
                lbNombre.Text = "";
                BuscarDatosPersonal(tbDNI.Text);
                CargarDatosPersonalYPermisos();
            }
            else
            {
                tipo = Tipo.ninguno;
                habilitaBoton();
                lbNombre.Text = "";
                
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

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }




        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }
        private void validaNumeros(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }




        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNumeroDocumento.Text != "")
            {
                GuardarPermisosEmpleado();
                calend_CalendarioDiasConPermisos.ActualizarDiasCalendario();
                CargarPermisosEmpleadoMesCalendario();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR EL NUMERO O CODIGO DEL DOCUMENTO PARA ASIGNAR LA LICENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumeroDocumento.Focus();
                tbNumeroDocumento.Select();

            }
        }

        bool bandera = false;//variable para indicar que se esta modificaindo
        private void GuardarPermisosEmpleado()
        {


            if (tbDNI.Text.Length == 8)
            {
                if (tbNumeroDocumento.Text != "")
                {
                    object[] DatosGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };
                    object[] ValuesGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };


                    //---------PARTA LAS LIMITACIONES-------------// 
                    object[] ValoresLimite = { "pDNI", "pIdTipoPermiso", "pTipo", "pAnno" };
                    object[] DatosLimite = { "pDNI", "pIdTipoPermiso", "pTipo","pAnno" };
                    //----------fin limite---------///
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

                    ValuesGuardarDiaConPermiso[0] = tbDNI.Text.Trim();
                    ValoresLimite[0] = tbDNI.Text.Trim();//para la consulta de los limites
                    ValoresIndividual[0] = tbDNI.Text.Trim();//para la consulta de los limites



                    try
                    {
                        for (int i = 0; i < i_NroDiasMes; i++)
                        {
                            /*--------AQUI VERIFICAMOS CUANTOS EL MILITE DE LICENCIAS------*/
                            ValoresLimite[1] = sa_DiasMesOpciones[i];
                            ValoresLimite[2] = "L";//L de LICENCIA
                            ValoresLimite[3] = pAnio;//año actual

                            /*-----------fin limites---------*/

                            /*--------PARA LA AVERIFICACION INDIVIDUAL------*/
                            ValoresIndividual[1] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1);
                            ValoresIndividual[2] = sa_DiasMesOpciones[i];
                            ValoresIndividual[3] = "L";//L de LICENCIA
                            ;
                            /*-----------fin VERIFICACION---------*/


                            /*CAPTURAMOS EL LIMITE DE LAS LICENCIAS*/
                            int limite = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimiteLicenciaTope", "pIdTipoPermiso", sa_DiasMesOpciones[i]);
                            /*--------FIN LIC------*/
                            /*CAPTURAMOS EL nombre DE LAS LICENCIAS*/
                            string nombreLicencia = ConexionBD.EjecutarProcedimientoReturnMensaje("Nuevo_NombreLicencia", "pIdTipoPermiso", sa_DiasMesOpciones[i]);
                            /*--------FIN LIC------*/
                            /*------consultamos el numero de permisos ya realizados----------*/
                            int verifica = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimitarLicencia", DatosLimite, ValoresLimite);
                            /*--------fin consulta numero de permisos----------*/

                            ValuesGuardarDiaConPermiso[1] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1);
                            ValuesGuardarDiaConPermiso[2] = sa_DiasMesOpciones[i];
                            ValuesGuardarDiaConPermiso[3] = "00:00:00";
                            ValuesGuardarDiaConPermiso[4] = "23:59:59";
                            ValuesGuardarDiaConPermiso[5] = "L";//L de LICENCIA
                            ValuesGuardarDiaConPermiso[6] = tbNumeroDocumento.Text;


                            if (bandera)
                            {
                                if (Convert.ToInt32(sa_DiasMesOpciones[i]) == 1)
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

                                        if (verifica < limite)
                                        {
                                            ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasPermisoEmpleado", DatosGuardarDiaConPermiso, ValuesGuardarDiaConPermiso);
                                        }
                                        else
                                        {
                                            MessageBox.Show("EL LIMITE DE: " + nombreLicencia + " ES DE: " + limite + " DIAS, EL USUSARIO YA EXCEDIO ESTE LIMITE...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //i = i_NroDiasMes-1;//forzamos la salida del bucleS

                                        }


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

                                    if (verifica < limite)
                                    {
                                        ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasPermisoEmpleado", DatosGuardarDiaConPermiso, ValuesGuardarDiaConPermiso);
                                    }
                                    else
                                    {
                                        MessageBox.Show("EL LIMITE DE: " + nombreLicencia + " ES DE: " + limite + " DIAS, EL USUSARIO YA EXCEDIO ESTE LIMITE...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //i = i_NroDiasMes-1;//forzamos la salida del bucleS

                                    }


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
                        MessageBox.Show("LICENIAS DEL EMPLEADO GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNumeroDocumento.Text = "";
                    }
                    else
                        MessageBox.Show("NO SE PUDO GUARDAR LAS LICENCIAS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("DEBE ASIGNAR UN DOCUMENTO DE REFERENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ANTES DE GUARDAR LOS VALORES, PREVIAMENTE DEBE SELECCIONAR UN TRABAJADOR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDNI.Focus();
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

        private void btnGrupales_Click(object sender, EventArgs e)
        {
            frmLicenciasGrupales grupales = new frmLicenciasGrupales(string_ArchivoConfiguracion);
            grupales.ShowDialog();
        }

       


    }
}
