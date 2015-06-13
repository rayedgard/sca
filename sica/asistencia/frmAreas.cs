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
    public partial class frmAreas : Form
    {
      
        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosDeArea = new object[3];
        string string_ArchivoConfiguracion;
        public frmAreas(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            ListarAreasExistentes();
            

            DatosDeArea = new object[3];
            DatosDeArea[0] = "0";
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
            dgvAreasExistentes.Enabled = dgvAreasExistentes.Rows.Count > 0;


        }
        #endregion




        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

           // ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosArea();
        }

        private void dgvAreasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)))
            {
                if (e.ColumnIndex == 0)
                {
                    // EDITAR
                    tbNombreArea.Text = dgvAreasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbDescripcionArea.Text = dgvAreasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();

                    DatosDeArea = new object[3];
                    DatosDeArea[0] = dgvAreasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosDeArea[1] = dgvAreasExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DatosDeArea[2] = dgvAreasExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();

                    tipo = Tipo.modificar;
                    habilitaBoton();
                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL ÁREA DE TRABAJO? \r\nSi elimina esta area cualquier trabajador registrado con esta area \r\npasara a pertenecer a la primera area de trabajo existente", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosArea();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        string Mensaje = "NO SE EJECUTO PROCEDIMIENTO ALMACENADO";
                        bool SeElimino = false;
                        try
                        {
                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuOfi_EliminarArea", "pIdArea", dgvAreasExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("ERROR AL ELIMINAR EL ÁREA DE TRABAJO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarAreasExistentes();
                    }
                }
            }
        }




        private void LimpiarDatosArea()
        {
            DatosDeArea = new object[3];
            DatosDeArea[0] = "0";
            tbNombreArea.Text = "";
            tbDescripcionArea.Text = "";
            tbNombreArea.Focus();
            tbNombreArea.Select();
        }

        private void ListarAreasExistentes()
        {

            //Cargar areas
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvAreasExistentes.Rows.Clear();


            DataSet AreasExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuofi_ListarAreasExistentes");

            object[] ValoresFila = new object[5];
            if (AreasExistentes.Tables[0].Rows.Count >= 1)
            {

                dgvAreasExistentes.Rows.Add(AreasExistentes.Tables[0].Rows.Count);

                for (int i = 0; i < AreasExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvAreasExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvAreasExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvAreasExistentes.Rows[i].Cells[2].Value = AreasExistentes.Tables[0].Rows[i][0];//id
                    dgvAreasExistentes.Rows[i].Cells[3].Value = AreasExistentes.Tables[0].Rows[i][1];//nombre
                    dgvAreasExistentes.Rows[i].Cells[4].Value = AreasExistentes.Tables[0].Rows[i][2];//detalles 
                }
            }
            ConexionBD.Desconectar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreArea.Text.Trim() != "" && tbNombreArea.Text.Trim().Length >= 3)
            {
                GuardarDatosDeArea();
            }
            else
                MessageBox.Show("EL NOMBRE DE AREA DEBE CONTENER AL MENOS 3 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void GuardarDatosDeArea()
        {
            if (DatosDeArea == null || DatosDeArea[0] == null)
            {
                DatosDeArea = new object[3];
                DatosDeArea[0] = "0";
            }
            DatosDeArea[0] = DatosDeArea[0].ToString().Trim();
            DatosDeArea[1] = tbNombreArea.Text;
            DatosDeArea[2] = tbDescripcionArea.Text;

            object[] NombresDatosArea = { "pIdArea", "pNombreArea", "pDescripcion" };

            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuOfi_GuardarArea", NombresDatosArea, DatosDeArea);
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
                MessageBox.Show("LOS DATOS SE GUARDARON EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosArea();
            }
            else
                MessageBox.Show("ERROR AL GUARDAR LOS DATOS, INTENTE NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarAreasExistentes();
        }









  
    }
}
