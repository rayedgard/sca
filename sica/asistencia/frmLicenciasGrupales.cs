using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    public partial class frmLicenciasGrupales : Form
    {



          string string_ArchivoConfiguracion;
          CValidacion ValidarDatos;
          CConection ConexionBD;



        public frmLicenciasGrupales(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();

            //para los filtrados 
            cbFiltrado.Items.Add("AREAS");
            cbFiltrado.Items.Add("CARGOS");
            cbFiltrado.Items.Add("SEXO");
            cbFiltrado.Items.Add("MODALIDAD");

            cbFiltrado.SelectedIndex = 0;

            cargardatos();
            dtpFechaIni.Value=DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        public void cargardatos()
        {

           
            //cargamos combo para las omisiones grupales SEXO
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbLicencias, true, "nuevo_listaLicenciasGrupal");
            ConexionBD.Desconectar();


        }

        private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrado.SelectedItem.ToString().Trim() == "MODALIDAD")/*CAMBIAR PARA LOS FOLTRADOS POR SEDES O AREAS*/
            {

                //Cargar POR MODALIDAD
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbCargos, true, "spuGeo_ListarModalidades");
                ConexionBD.Desconectar();
                //Cargar Distritos


            }
            if (cbFiltrado.SelectedItem.ToString().Trim() == "AREAS")
            {
                //Cargar POR AREAS
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbCargos, true, "spuGeo_ListarAreas");
                ConexionBD.Desconectar();
                //Cargar Distritos
            }
            //fin filtrado
            if (cbFiltrado.SelectedItem.ToString().Trim() == "CARGOS")
            {
                //cargamos combo para las omisiones grupales POR CARGOS
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbCargos, true, "spuGeo_ListarCargos");
                ConexionBD.Desconectar();
            }


            if (cbFiltrado.SelectedItem.ToString().Trim() == "SEXO")
            {

                //cargamos combo para las omisiones grupales SEXO
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbCargos, true, "spuGeo_ListarSexo");
                ConexionBD.Desconectar();

            }
        }


        bool boolHecho1 = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbDetalle.Text != "")
            {

                object[] ParametrosListaDNI = { "pIdFiltro", "pValorFiltro" };
                object[] DatosListaDNI = { "pIdFiltro", "pValorFiltro" };


                DatosListaDNI[0] = cbCargos.SelectedValue.ToString().Trim();
                DatosListaDNI[1] = cbFiltrado.SelectedItem.ToString().Trim();


                string idCargo = "";
                idCargo = cbCargos.SelectedValue.ToString().Trim();
                string Consulta = "nuevo_fintraDniValor";/**/

                DataSet FiltroPersonal = ConexionBD.EjecutarProcedimientoReturnDataSet(Consulta, ParametrosListaDNI, DatosListaDNI);//par los dnis

                MessageBox.Show(FiltroPersonal.Tables[0].Rows.Count.ToString());

                 // Difference in days, hours, and minutes.
            TimeSpan ts = dtpFechaFin.Value - dtpFechaIni.Value;

                // Difference in days.
                int dias = ts.Days;
                for (int j = 0; j <= dias; j++)
                {
                    // convertimos el control datetimepiker a datetime.
                    DateTime fechai = dtpFechaIni.Value;
                    //creamos un repositorio de la fecha bueva
                    DateTime fecha = new DateTime();
                    //agregamos el numero de dias de la iteracion a la fecha de inicio
                    fecha = fechai.AddDays(j);

                    for (int i = 0; i < FiltroPersonal.Tables[0].Rows.Count; i++)
                    {
                        GuardaLicenciaGrupal(FiltroPersonal.Tables[0].Rows[i].ItemArray[0].ToString(), fecha);
                    }
                }

                if (boolHecho1)
                {
                    MessageBox.Show("LICENIAS DEL EMPLEADO GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDetalle.Text = "";
                    tipo = Tipo.ninguno;
                    habilitaBoton();

                }
                else
                    MessageBox.Show("NO SE PUDO GUARDAR LAS LICENCIAS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("DEBE ASIGNAR UN DOCUMENTO DE REFERENCIA O DETALLE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipo = Tipo.ninguno;
                habilitaBoton();
            }

        }


        bool bandera = false;//variable para indicar que se esta modificaindo
        private void GuardaLicenciaGrupal(string DNI, DateTime fecha)
        {



            object[] DatosGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };
            object[] ValuesGuardarDiaConPermiso = { "pDNI", "pDiaMesAnio", "pIdTipoPermiso", "pHoraInicio", "pHoraFin", "pTipo", "pDocumento" };


            //---------PARTA LAS LIMITACIONES-------------// 
            object[] DatosLimite = { "pDNI", "pIdTipoPermiso", "pTipo" };
            object[] ValoresLimite = { "pDNI", "pIdTipoPermiso", "pTipo" };
            //----------fin limite---------///
            //---------PARTA LA VERIFICACION INDIVIDUAL DE UNA LICENCIA-------------// 
            object[] DatosIndividual = { "pDNI", "pFechaPermiso", "pIdTipoPermiso", "pTipo" };
            object[] ValoresIndividual = { "pDNI", "pFechaPermiso", "pIdTipoPermiso", "pTipo" };
            //----------fin LIMITACION INDIVIDUAL---------///







            ConexionBD.Conectar(true, string_ArchivoConfiguracion);

            ValuesGuardarDiaConPermiso[0] = DNI.Trim();
            ValoresLimite[0] = DNI.Trim();//para la consulta de los limites
            ValoresIndividual[0] = DNI.Trim();//para la consulta de los limites



            try
            {

                /*--------AQUI VERIFICAMOS CUANTOS EL MILITE DE LICENCIAS------*/
                ValoresLimite[1] = cbLicencias.SelectedValue.ToString();
                ValoresLimite[2] = "L";//L de LICENCIA
                /*-----------fin limites---------*/

                /*--------PARA LA AVERIFICACION INDIVIDUAL------*/
                ValoresIndividual[1] = ConexionBD.FechaFormatoMySQL(fecha, 0);
                ValoresIndividual[2] = cbLicencias.SelectedValue.ToString();
                ValoresIndividual[3] = "L";//L de LICENCIA
                ;
                /*-----------fin VERIFICACION---------*/


                /*CAPTURAMOS EL LIMITE DE LAS LICENCIAS*/
                int limite = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimiteLicenciaTope", "pIdTipoPermiso", cbLicencias.SelectedValue.ToString());
                /*--------FIN LIC------*/
                /*CAPTURAMOS EL nombre DE LAS LICENCIAS*/
                string nombreLicencia = ConexionBD.EjecutarProcedimientoReturnMensaje("Nuevo_NombreLicencia", "pIdTipoPermiso", cbLicencias.SelectedValue.ToString());
                /*--------FIN LIC------*/
                /*------consultamos el numero de permisos ya realizados----------*/
                int verifica = ConexionBD.EjecutarProcedimientoReturnEntero("Nuevo_LimitarLicencia", DatosLimite, ValoresLimite);
                /*--------fin consulta numero de permisos----------*/

                ValuesGuardarDiaConPermiso[1] = ConexionBD.FechaFormatoMySQL(fecha, 0);
                ValuesGuardarDiaConPermiso[2] = cbLicencias.SelectedValue.ToString();
                ValuesGuardarDiaConPermiso[3] = "00:00:00";
                ValuesGuardarDiaConPermiso[4] = "23:59:59";
                ValuesGuardarDiaConPermiso[5] = "L";//L de LICENCIA
                ValuesGuardarDiaConPermiso[6] = tbDetalle.Text;


                if (bandera)
                {
                    if (Convert.ToInt32(cbLicencias.SelectedValue.ToString()) == 1)
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

                        MessageBox.Show("EL BOTON MODIFICAR SOLO QUITA LAS LICENCIAS, PARA CAMBIAR A OTRA LICENCIA DIFERENTE DEL QUE YA ASIGNO ANTERIORMENTE, UTILICE EL BOTON GUARDAR, DEBIDO A QUE TAMBIEN DEBE MODIFIACAR O PRESERVAR EL NÚMERO DEL DOCUMENTO O PAPELETA ASIGNADA AL PERSONAL", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


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


                bandera = false;
                ConexionBD.COMMIT();
                boolHecho1 = true;
            }
            catch
            {
                ConexionBD.ROLLBACK();
                boolHecho1 = false;
            }
            finally
            {
                ConexionBD.Desconectar();
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
           
        }
        #endregion

        private void tbDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
        }


     
    }
}
