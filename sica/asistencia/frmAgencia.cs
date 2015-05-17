using clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class frmAgencia : Form
    {
        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosDeAgencia = new object[6];
     
        string string_ArchivoConfiguracion;
        public frmAgencia(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            ListarAgenciasExistentes();
   
            CargarProvinciasDistritos();


            DatosDeAgencia = new object[6];
            DatosDeAgencia[0] = "0";
      
        }


        public void ListarAgenciasExistentes()
        {
            //Cargar dagencias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvAgenciasExistentes.Rows.Clear();


            DataSet AgenciasExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuofi_ListarAgenciasExistentes");

            object[] ValoresFila = new object[8];

            if (AgenciasExistentes.Tables[0].Rows.Count >= 1)
            {
                dgvAgenciasExistentes.Rows.Add(AgenciasExistentes.Tables[0].Rows.Count);

                for (int i = 0; i < AgenciasExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvAgenciasExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvAgenciasExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvAgenciasExistentes.Rows[i].Cells[2].Value = AgenciasExistentes.Tables[0].Rows[i][0];//id
                    dgvAgenciasExistentes.Rows[i].Cells[3].Value = AgenciasExistentes.Tables[0].Rows[i][1];//nombre
                    dgvAgenciasExistentes.Rows[i].Cells[4].Value = AgenciasExistentes.Tables[0].Rows[i][2];//direccion                
                    dgvAgenciasExistentes.Rows[i].Cells[5].Value = AgenciasExistentes.Tables[0].Rows[i][3];//telefono          
                    dgvAgenciasExistentes.Rows[i].Cells[6].Value = AgenciasExistentes.Tables[0].Rows[i][4];//provincia                
                    dgvAgenciasExistentes.Rows[i].Cells[7].Value = AgenciasExistentes.Tables[0].Rows[i][5];//distrito
                }
            }
            ConexionBD.Desconectar();
        }

        public void CargarProvinciasDistritos()
        {
            //Cargar Provincias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbProvincias, true, "spuGeo_ListarProvincias");
            //Cosas por defecto
            cbProvincias.Refresh();
            ConexionBD.Desconectar();
            //Cargar Distritos
            if (cbProvincias.SelectedValue != null)
                CargarDistritos(cbProvincias.SelectedValue.ToString());
        }

        public void CargarDistritos(string pIdProvincia)
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbDistritos, true, "spuGeo_ListarDistritos", "pIdProvincia", pIdProvincia);
            cbDistritos.Refresh();
            ConexionBD.Desconectar();
        }



        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar, modificar, eliminar, grid, subturno
        }
        private Tipo tipo;




        private void habilitaBoton()
        {
            btnGuardar.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            gbDatos.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            dgvAgenciasExistentes.Enabled = dgvAgenciasExistentes.Rows.Count > 0;


        }
        #endregion

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosAgencia();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreAgencia.Text.Trim() != "" && tbNombreAgencia.Text.Trim().Length >= 3)
            {
                if (cbDistritos.SelectedIndex >= 0 && cbDistritos.Text.Trim() != "")
                {
                    GuardarDatosDeAgencia();

                }
                else
                    MessageBox.Show("DEBE SELECCIONAR EL DISTRITO", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("EL NOMBRE DE LA AGENCIA DEBE TENER AL MENOS 3 CARACTERES", "ATEMCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       
        }



        private void GuardarDatosDeAgencia()
        {
            if (DatosDeAgencia == null || DatosDeAgencia[0] == null)
            {
                DatosDeAgencia = new object[6];
                DatosDeAgencia[0] = "0";
            }
            DatosDeAgencia[0] = DatosDeAgencia[0].ToString().Trim();
            DatosDeAgencia[1] = tbNombreAgencia.Text;
            DatosDeAgencia[2] = tbDireccionAgencia.Text;
            DatosDeAgencia[3] = tbTelefonoAgencia.Text;
            DatosDeAgencia[4] = cbProvincias.SelectedValue;
            DatosDeAgencia[5] = cbDistritos.SelectedValue;

            object[] NombresDatosAgencia = { "pIdAgencia", "pNombreAgencia", "pDireccion", "pTelefono", "pIdProvincia", "pIdDistrito" };


            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuOfi_GuardarAgencia", NombresDatosAgencia, DatosDeAgencia);
                ConexionBD.COMMIT();
                SeGuardo = true;

                tipo = Tipo.guardar;
                habilitaBoton();
            }
            catch//(Exception ex)
            {
                ConexionBD.ROLLBACK();
                SeGuardo = false;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.Desconectar();
            }

            if (SeGuardo)
            {
                MessageBox.Show("LOS DATOS FUERON GUARDOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosAgencia();
            }
            else
                MessageBox.Show("HUBO UN ERROR AL GUARDAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarAgenciasExistentes();
        }



        public void LimpiarDatosAgencia()
        {
            DatosDeAgencia = new object[6];
            DatosDeAgencia[0] = "0";
            tbNombreAgencia.Text = "";
            tbTelefonoAgencia.Text = "";
            tbDireccionAgencia.Text = "";

            tbNombreAgencia.Focus();
            tbNombreAgencia.Select();
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincias.SelectedValue != null && cbProvincias.SelectedItem != null && cbProvincias.SelectedIndex >= 0 && cbProvincias.Items.Count > 0)
                if (cbProvincias.SelectedValue.ToString().Length <= 10)
                    CargarDistritos(cbProvincias.SelectedValue.ToString());
        }

      
        private void dgvAgenciasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)))
            {
                if (e.ColumnIndex == 0)
                {
                    // EDITAR
                    tbNombreAgencia.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbDireccionAgencia.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbTelefonoAgencia.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbProvincias.SelectedValue = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[6].Value;
                    cbDistritos.SelectedValue = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[7].Value;

                    DatosDeAgencia = new object[6];
                    DatosDeAgencia[0] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosDeAgencia[1] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DatosDeAgencia[2] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DatosDeAgencia[3] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[5].Value;
                    DatosDeAgencia[4] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[6].Value;
                    DatosDeAgencia[5] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[7].Value;

                    tipo = Tipo.modificar;
                    habilitaBoton();

                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTA AGENCIA? \r\nSi elimina esta agencia cualquier trabajador registrado con esta agencia \r\npasara a pertenecer a la primera agencia existente", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosAgencia();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        string Mensaje = "NO SE EJECUTO PROCEDIMIENTO ALMACENADO";
                        bool SeElimino = false;
                        try
                        {
                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuOfi_EliminarAgencia", "pIdAgencia", dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
                            ConexionBD.COMMIT();
                            SeElimino = true;

                            tipo = Tipo.eliminar;
                            habilitaBoton();
                        }
                        catch
                        {
                            ConexionBD.ROLLBACK();
                            SeElimino = false;
                        }
                        finally
                        {
                            ConexionBD.Desconectar();
                        }

                        if (SeElimino)
                            MessageBox.Show(Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("HUBO UN ERROR AL ELIMINAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarAgenciasExistentes();
                    }
                }
            }
        }

        private void frmAgencia_Load(object sender, EventArgs e)
        {

        }





    }
}
