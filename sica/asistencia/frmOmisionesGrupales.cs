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
    public partial class frmOmisionesGrupales : Form
    {
        CValidacion ValidarDatos;
        CConection ConexionBD;

        ArrayList ListaMenuDiasOmision;
        object[] ParametrosRecuperarDiasConOmision = { "pDNI", "pMes", "pAnio" };
        object[] DatosRecuperarDiasConOmision = { "DNI", 01, 2011 };
        string string_ArchivoConfiguracion;
        public frmOmisionesGrupales(string ArchivoCOnfig)
        {
           
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            
            ConexionBD = new CConection();
            ListaMenuDiasOmision = new ArrayList();

            //para determinar el tipo de omision
            cbTipoOmision.Items.Add("ENTRADA");
            cbTipoOmision.Items.Add("SALIDA");
            cbTipoOmision.Items.Add("ENTRADA DE REFRIGERIO");
            cbTipoOmision.Items.Add("SALIDA DE REFRIGERIO");
            cbTipoOmision.SelectedIndex = 1;

              
            /*para los filtrados */
            cbFiltrado.Items.Add("AREAS");
            cbFiltrado.Items.Add("CARGOS");
            cbFiltrado.Items.Add("SEXO");
            cbFiltrado.Items.Add("MODALIDAD");

            cbFiltrado.SelectedIndex = 0;

            dtpFecha.Value = DateTime.Now;
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


                for (int i = 0; i < FiltroPersonal.Tables[0].Rows.Count; i++)
                {
                    GuardarOmisionGrupal(FiltroPersonal.Tables[0].Rows[i].ItemArray[0].ToString());

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
                MessageBox.Show("DEBE ASIGNAR UN DOCUMENTO DE REFERENCIA O DETALLE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        //METODO PARA GUARDAR LOS VALORES DE LA OMISION grupal
        private void GuardarOmisionGrupal(string dni)
        {

            object[] DatosGuardarDiaConOmision = { "pDNI", "pTipoOmision", "pFechaOmision", "pDocumento" };
            object[] ValuesGuardarDiaConOmision = { "pDNI", "pTipoOmision", "pFechaOmision", "pDocumento" };



            ConexionBD.Conectar(true, string_ArchivoConfiguracion);

            ValuesGuardarDiaConOmision[0] = dni;
            ValuesGuardarDiaConOmision[1] = cbTipoOmision.SelectedItem;
            ValuesGuardarDiaConOmision[2] = ConexionBD.FechaFormatoMySQL(dtpFecha.Value, 0);
            ValuesGuardarDiaConOmision[3] = tbDetalle.Text;

            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_guardarOmisionGrupo", DatosGuardarDiaConOmision, ValuesGuardarDiaConOmision);
                ConexionBD.COMMIT();
                boolHecho1 = true;
            }
            catch (Exception ex)
            {
                ConexionBD.ROLLBACK();
                boolHecho1 = false;
            }
            finally
            {
                ConexionBD.Desconectar();
            }


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

        private void tbDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
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

    }
}
