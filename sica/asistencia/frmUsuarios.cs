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
    public partial class frmUsuarios : Form
    {
       
        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] usuarios = new object[5];
        object[] indicesUsuario = new object[2];
        string string_ArchivoConfiguracion;



        public frmUsuarios(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            MostrarDatos();

            
            cbTipoUsiaro.Items.Add("SUPER-ADMINISTRADOR");
            cbTipoUsiaro.Items.Add("ADMINISTRADOR");
            cbTipoUsiaro.SelectedIndex = 0;
            
      
        }

        private void MostrarDatos()
        {

            ListarUsuarios();
            cargaAreas();
        }


        public void ListarUsuarios()
        {
            //Cargar horarios
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvUsuarios.Rows.Clear();

            try
            {
                DataSet UsuariosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_listarUsuarios");

                object[] ValoresFila = new object[4];
                dgvUsuarios.Rows.Add(UsuariosExistentes.Tables[0].Rows.Count);
                object[] indicesArea = new object[UsuariosExistentes.Tables[0].Rows.Count];
                indicesUsuario[0] = 0;
                indicesUsuario[1] = 1;

                for (int i = 0; i < UsuariosExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvUsuarios.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvUsuarios.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvUsuarios.Rows[i].Cells[2].Value = UsuariosExistentes.Tables[0].Rows[i][0];//nommbre
                    dgvUsuarios.Rows[i].Cells[3].Value = UsuariosExistentes.Tables[0].Rows[i][1];//contrasenia
                    dgvUsuarios.Rows[i].Cells[4].Value = UsuariosExistentes.Tables[0].Rows[i][2];//email 


                    dgvUsuarios.Rows[i].Cells[5].Value = ConexionBD.EjecutarProcedimientoReturnMensaje("nuevo_mostrarArea", "pIdArea", UsuariosExistentes.Tables[0].Rows[i][3]);//tipo
                    dgvUsuarios.Rows[i].Cells[6].Value = UsuariosExistentes.Tables[0].Rows[i][3];

                    if (Convert.ToInt32(UsuariosExistentes.Tables[0].Rows[i][4]) == 0)
                    {
                        dgvUsuarios.Rows[i].Cells[7].Value = "SUPER-ADMINISTRADOR";//tipo
                    }
                    else
                    {
                        dgvUsuarios.Rows[i].Cells[7].Value = "ADMINISTRADOR";//tipo
                    }

                    dgvUsuarios.Rows[i].Cells[8].Value = UsuariosExistentes.Tables[0].Rows[i][4];
                }
            }
            catch
            { }
            ConexionBD.Desconectar();
        }


        public void cargaAreas()
        {

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbAreas, true, "nuevo_listarAreasCombo");
            ConexionBD.Desconectar();
        }

        public void limpiarUsuario()
        {
            tbNombreUsuario.Text = "";

            tbContrasenia.Text = "";
            tbEmail.Text = "";
            cbAreas.SelectedIndex = 0;
            cbTipoUsiaro.SelectedIndex = 0;

            tbNombreUsuario.Focus();
            tbNombreUsuario.Select();
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
            dgvUsuarios.Enabled = dgvUsuarios.Rows.Count > 0;


        }
        #endregion

        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            //((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

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

            limpiarUsuario();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 1) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)) && dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString() != "1")
            {
                if (e.ColumnIndex == 0)
                {// EDITAR

                    tbNombreUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbContrasenia.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //en la linea de abajo capturamos el valor asignado al nomre desde la base de datos = value member
                    cbAreas.SelectedValue = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //en esta linea capturamos el index de de la seleccion
                    cbTipoUsiaro.SelectedIndex = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[8].Value);
                    //cbTipoUsiaro.= dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //cbAreas.SelectedValue = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //cbAreas.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();

                    usuarios = new object[5];
                    usuarios[0] = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    usuarios[1] = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    usuarios[2] = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    usuarios[3] = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    usuarios[4] = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();

                    tipo = Tipo.modificar;
                    habilitaBoton();
                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE USUARIO? \r", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //LimpiarDatosHorario();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        bool SeElimino = false;
                        try
                        {
                            ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_elimiaUsuario", "pAdministrador", dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("DATOS ELIMINADOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("HUBO UN ERROR AL ELIMINAR EL USUARIO, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarUsuarios();
                    }

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text.Length >= 5)
            {
                if (tbContrasenia.Text.Length >= 5)
                {
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool SeGuardo = false;
                    try
                    {
                        object[] NombresUsuarios = { "pAdministrador", "pContrasenia", "pCorreo", "pPrivilegio", "pArea" };

                        usuarios[0] = tbNombreUsuario.Text.Trim();
                        usuarios[1] = tbContrasenia.Text.Trim();
                        usuarios[2] = tbEmail.Text.Trim();
                        usuarios[3] = cbTipoUsiaro.SelectedIndex;
                        usuarios[4] = cbAreas.SelectedValue;

                        ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_GuardarUsuarios", NombresUsuarios, usuarios);
                        ConexionBD.COMMIT();
                        SeGuardo = true;

                        tipo= Tipo.guardar;
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
                        MessageBox.Show("LOS DATOS FUERON GUARDADOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("HUBO UN ERROR AL GUARDAR EL USUARIO, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //LimpiarDatosHorario();
                    //ListarHorariosExistentes();  
                }
                else
                    MessageBox.Show("LA CONTRASEÑA DEL USUARIO DEBE CONTENER AL MENOS 5 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("EL NOMBRE DE USUARIO DEBE CONTENER AL MENOS 5 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpiarUsuario();
            ListarUsuarios();
        }







    }
}
