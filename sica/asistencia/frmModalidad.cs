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
    public partial class frmModalidad : Form
    {
       

         CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosDeCargos = new object[3];
        string string_ArchivoConfiguracion;

        public frmModalidad(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            listarModalidades();
           
            DatosDeCargos = new object[3];
            DatosDeCargos[0] = "0";
        }


        public void listarModalidades()
        {
            //Cargar cargos
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvAgenciasExistentes.Rows.Clear();


            DataSet CargosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuofi_ListarModalidadesExistentes");

            object[] ValoresFila = new object[5];

            if (CargosExistentes.Tables[0].Rows.Count >= 1)
            {
                dgvAgenciasExistentes.Rows.Add(CargosExistentes.Tables[0].Rows.Count);

                for (int i = 0; i < CargosExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvAgenciasExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvAgenciasExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvAgenciasExistentes.Rows[i].Cells[2].Value = CargosExistentes.Tables[0].Rows[i][0];//id
                    dgvAgenciasExistentes.Rows[i].Cells[3].Value = CargosExistentes.Tables[0].Rows[i][1];//nombre        
                    dgvAgenciasExistentes.Rows[i].Cells[4].Value = CargosExistentes.Tables[0].Rows[i][2];//detalles 
                }
            }
            ConexionBD.Desconectar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreCargo.Text.Trim() != "" && tbNombreCargo.Text.Trim().Length >= 3)
            {
                GuardarDatosModalidad();
                LimpiarDatosModalidad();
            }
            else
                MessageBox.Show("EL NOMBRE DE MODALIDAD DEBE AL MENOS CONTENER 3 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        
        }

        private void GuardarDatosModalidad()
        {
            if (DatosDeCargos == null || DatosDeCargos[0] == null)
            {
                DatosDeCargos = new object[3];
                DatosDeCargos[0] = "0";
            }
            DatosDeCargos[0] = DatosDeCargos[0].ToString().Trim();
            DatosDeCargos[1] = tbNombreCargo.Text;
            DatosDeCargos[2] = tbDescripcion.Text;


            object[] NombresDatosCargo = { "pIdModalidad", "pNombre", "pDetalles" };


            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuOfi_GuardarModalidad", NombresDatosCargo, DatosDeCargos);
                ConexionBD.COMMIT();
                SeGuardo = true;
            }
            catch (Exception ex)
            {
                ConexionBD.ROLLBACK();
                SeGuardo = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.Desconectar();
            }

            if (SeGuardo)
            {
                MessageBox.Show("LOS DATOS FUERON GUARDADOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("HUBO UN ERROR AL GUARDAR LOS DATOS, POR FAVOR INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listarModalidades();
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



        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosModalidad();
        }


        public void LimpiarDatosModalidad()
        {
            DatosDeCargos = new object[3];
            DatosDeCargos[0] = "0";
            tbNombreCargo.Text = "";
            tbDescripcion.Text = "";
            tbNombreCargo.Focus();
            tbNombreCargo.Select();


        }

        private void dgvAgenciasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)))
            {
                if (e.ColumnIndex == 0)
                {
                    // EDITAR
                    tbNombreCargo.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbDescripcion.Text = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();

                    DatosDeCargos = new object[3];
                    DatosDeCargos[0] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosDeCargos[1] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DatosDeCargos[2] = dgvAgenciasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();


                    tipo = Tipo.modificar;
                    habilitaBoton();
                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTA MODALIDAD? \r\nSi elimina esta modalidad cualquier trabajador registrado con esta modalidad \r\nse le asignara otra modalidad existente", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                       
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        string Mensaje = "NO SE EJECUTO PROCEDIMIENTO ALMACENADO";
                        bool SeElimino = false;
                        try
                        {
                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuOfi_EliminarModalidad", "pIdModalidad", dgvAgenciasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("ERROR AL ELIMINAR LA MODALIDAD, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarDatosModalidad();
                        listarModalidades();
                    }
                }
            }
        }


    }
}
