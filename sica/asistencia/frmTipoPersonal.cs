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
    public partial class frmTipoPersonal : Form
    {
      



        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosDeCargos = new object[5];
        string string_ArchivoConfiguracion;
        
          public frmTipoPersonal(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            ListarCargosExistentes();
            CargarHorarios();
            DatosDeCargos = new object[5];
            DatosDeCargos[0] = "0";
        }



        public void CargarHorarios()
        {
            
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
           try
           {
               DataSet HorariosLista1 = ConexionBD.EjecutarProcedimientoReturnDataSet( "spuGeo_ListarHorarios");
               DataSet HorariosLista2 = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_ListarHorariosRotativos");
               if (rbEstatico.Checked)
               {
                   cbHorarioDefault.DataSource = HorariosLista1.Tables[0].DefaultView;
                   cbHorarioDefault.DisplayMember = "DISPLAY MEMBER";
                   cbHorarioDefault.ValueMember = "VALUE MEMBER";
               }
               if (rbRotativo.Checked)
               {
                   cbHorarioDefault.DataSource = HorariosLista2.Tables[0].DefaultView;
                   cbHorarioDefault.DisplayMember = "DISPLAY MEMBER";
                   cbHorarioDefault.ValueMember = "VALUE MEMBER";
               }

          
           }
           catch
           { }
               ConexionBD.Desconectar();

            //ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            //ConexionBD.EjecutarProcedimientoReturnComboBox(cbHorarioDefault, true, "spuGeo_ListarHorarios");
            //ConexionBD.EjecutarProcedimientoReturnComboBox(cbHorarioDefault, true, "nuevo_ListarHorariosRotativos");
            //cbHorarioDefault.Refresh();
            //ConexionBD.Desconectar();
        }


        public void ListarCargosExistentes()
        {
            //Cargar cargos
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvAgenciasExistentes.Rows.Clear();


            DataSet CargosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuofi_ListarCargosExistentes");

            object[] ValoresFila = new object[7];

            if (CargosExistentes.Tables[0].Rows.Count >= 1)
            {
                dgvAgenciasExistentes.Rows.Add(CargosExistentes.Tables[0].Rows.Count);

                for (int i = 0; i < CargosExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvAgenciasExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvAgenciasExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvAgenciasExistentes.Rows[i].Cells[2].Value = CargosExistentes.Tables[0].Rows[i][0];//id
                    dgvAgenciasExistentes.Rows[i].Cells[3].Value = CargosExistentes.Tables[0].Rows[i][1];//nombre
                    dgvAgenciasExistentes.Rows[i].Cells[4].Value = CargosExistentes.Tables[0].Rows[i][2];//horariio                
                    dgvAgenciasExistentes.Rows[i].Cells[5].Value = CargosExistentes.Tables[0].Rows[i][3];//sueldo          
                    dgvAgenciasExistentes.Rows[i].Cells[6].Value = CargosExistentes.Tables[0].Rows[i][4];//detalles 
                }
            }
            ConexionBD.Desconectar();
        }
               

        private void dgvAgenciasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)))
            {
                if (e.ColumnIndex == 0)
                {
                    // EDITAR


                    if (Convert.ToInt32(dgvAgenciasExistentes.Rows[e.RowIndex].Cells[6].Value) >= 300)
                    {
                        rbRotativo.Checked = true;
                        CargarHorarios();
                    }
                    else
                    {
                        rbEstatico.Checked = true;
                        CargarHorarios();
                    }

                    tbNombreCargo.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbSueldoDefault.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbDescripcion.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbHorarioDefault.SelectedValue = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[6].Value;
               


                    DatosDeCargos = new object[5];
                    DatosDeCargos[0] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosDeCargos[1] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DatosDeCargos[2] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DatosDeCargos[3] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[5].Value;
                    DatosDeCargos[4] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[6].Value;

                    tipo = Tipo.modificar;
                    habilitaBoton();

                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿Esta seguro que quiere eliminar esta cargo? \r\nSi elimina esta cargo cualquier trabajador registrado con este cargo \r\nse le asignara otro cargo existente", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosCargo();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        string Mensaje = "NO SE EJECUTO PROCEDIMIENTO ALMACENADO";
                        bool SeElimino = false;
                        try
                        {
                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuOfi_EliminarCargo", "pIdCargo", dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("El cargo no pudo ser Eliminado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarCargosExistentes();
                    }
                }
            }
        }


        public void LimpiarDatosCargo()
        {
            DatosDeCargos = new object[5];
            DatosDeCargos[0] = "0";
            tbNombreCargo.Text = "";
            tbDescripcion.Text = "";
            tbSueldoDefault.Text = "";
        }

        
        private void btnNuevaAgencia_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosCargo();
        }

        private void btnGuardarAgencia_Click(object sender, EventArgs e)
        {
            if (tbNombreCargo.Text.Trim() != "" && tbNombreCargo.Text.Trim().Length >= 3)
            {
                GuardarDatosDeCargo();
            }
            else
                MessageBox.Show("Debe escribir un nombre correcto para el cargo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void GuardarDatosDeCargo()
        {
            if (DatosDeCargos == null || DatosDeCargos[0] == null)
            {
                DatosDeCargos = new object[5];
                DatosDeCargos[0] = "0";
            }
            DatosDeCargos[0] = DatosDeCargos[0].ToString().Trim();
            DatosDeCargos[1] = tbNombreCargo.Text;
            DatosDeCargos[2] = tbSueldoDefault.Text;
            DatosDeCargos[3] = tbDescripcion.Text;
            DatosDeCargos[4] = cbHorarioDefault.SelectedValue;

            object[] NombresDatosCargo = { "pIdCargo","pNombreCargo","pSueldo","pDetalles","pIdHorario"};


            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuOfi_GuardarCargo", NombresDatosCargo, DatosDeCargos);
                ConexionBD.COMMIT();
                SeGuardo = true;
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
                MessageBox.Show("Los datos del cargo fueron guardados correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosCargo();
            }
            else
                MessageBox.Show("No se pudo guardar los datos del cargo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarCargosExistentes();
        }

        private void tbSueldoDefault_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(tbSueldoDefault.Text, "decimalpositivo", sender, e);
        }

        private void tbNombreCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(tbNombreCargo.Text, "LetrasNumerosEspacio", sender, e);
        }

        private void rbEstatico_Click(object sender, EventArgs e)
        {
            CargarHorarios();
        }

        private void rbRotativo_Click(object sender, EventArgs e)
        {
            CargarHorarios();
        }







        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar, modificar, eliminar, grid
        }
        private Tipo tipo;
        



        private void habilitaBoton()
        {
            btnGuardar.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar;
            gbCargos.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar;
            dgvAgenciasExistentes.Enabled = dgvAgenciasExistentes.Rows.Count > 0;
            
        }
        #endregion



        #region ---------------validacion caja de texto-----------------
        private void validaNumeros(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }

        private void validaDecimales(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(tbSueldoDefault.Text, "decimalpositivo", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion


        private void frmTipoPersonal_Load(object sender, EventArgs e)
        {

        }

        



    }
}
