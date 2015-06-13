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
    public partial class frmHorario : Form
    {
        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosHorarioNuevo = new object[10];
      
        string string_ArchivoConfiguracion;

        public frmHorario(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            ListarHorariosExistentes();
            ListarTurnosExistentes();
        }


        public void ListarHorariosExistentes()
        {
            //Cargar horarios
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvHorariosExistentes.Rows.Clear();


            DataSet HorariosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_ListarHorariosExistentes");

            object[] ValoresFila = new object[12];
            dgvHorariosExistentes.Rows.Add(HorariosExistentes.Tables[0].Rows.Count);

            for (int i = 0; i < HorariosExistentes.Tables[0].Rows.Count; i++)
            {
                dgvHorariosExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                dgvHorariosExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                dgvHorariosExistentes.Rows[i].Cells[2].Value = HorariosExistentes.Tables[0].Rows[i][0];//id
                dgvHorariosExistentes.Rows[i].Cells[3].Value = HorariosExistentes.Tables[0].Rows[i][1];//nombre
                dgvHorariosExistentes.Rows[i].Cells[4].Value = HorariosExistentes.Tables[0].Rows[i][2];//obs                
                dgvHorariosExistentes.Rows[i].Cells[5].Value = HorariosExistentes.Tables[0].Rows[i][3];//lun                
                dgvHorariosExistentes.Rows[i].Cells[6].Value = HorariosExistentes.Tables[0].Rows[i][4];//mar                
                dgvHorariosExistentes.Rows[i].Cells[7].Value = HorariosExistentes.Tables[0].Rows[i][5];//mier                
                dgvHorariosExistentes.Rows[i].Cells[8].Value = HorariosExistentes.Tables[0].Rows[i][6];//jue               
                dgvHorariosExistentes.Rows[i].Cells[9].Value = HorariosExistentes.Tables[0].Rows[i][7];//vier                
                dgvHorariosExistentes.Rows[i].Cells[10].Value = HorariosExistentes.Tables[0].Rows[i][8];//sab                
                dgvHorariosExistentes.Rows[i].Cells[11].Value = HorariosExistentes.Tables[0].Rows[i][9];//dom                

            }
            ConexionBD.Desconectar();
        }
        private void frmHorario_Load(object sender, EventArgs e)
        {

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
            dgvHorariosExistentes.Enabled = dgvHorariosExistentes.Rows.Count > 0;
          

        }
        #endregion




        #region ---------------validacion caja de texto-----------------
  

        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            //((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

        private void cbPonerMismoHorario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPonerMismoHorario.Checked)
            {
                cbMartes.Enabled = false;
                cbMiercoles.Enabled = false;
                cbJueves.Enabled = false;
                cbViernes.Enabled = false;

                if (cbLunes.SelectedValue != null)
                {
                    cbMartes.SelectedValue = cbLunes.SelectedValue;
                    cbMiercoles.SelectedValue = cbLunes.SelectedValue;
                    cbJueves.SelectedValue = cbLunes.SelectedValue;
                    cbViernes.SelectedValue = cbLunes.SelectedValue;
                }
            }
            else
            {
                cbMartes.Enabled = true;
                cbMiercoles.Enabled = true;
                cbJueves.Enabled = true;
                cbViernes.Enabled = true;
            }
        }

        private void cbLunes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLunes.SelectedValue != null && cbPonerMismoHorario.Checked)
            {
                cbMartes.SelectedValue = cbLunes.SelectedValue;
                cbMiercoles.SelectedValue = cbLunes.SelectedValue;
                cbJueves.SelectedValue = cbLunes.SelectedValue;
                cbViernes.SelectedValue = cbLunes.SelectedValue;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbDomingo.SelectedIndex >= 0 && cbLunes.SelectedIndex >= 0 && cbMartes.SelectedIndex >= 0 && cbMiercoles.SelectedIndex >= 0 && cbJueves.SelectedIndex >= 0 && cbViernes.SelectedIndex >= 0 && cbSabado.SelectedIndex >= 0)
            {
                if (tbNombreHorario.Text.Length >= 3)
                {
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool SeGuardo = false;
                    try
                    {
                        object[] NombresGuardarHorario = { "pIdHorario", "pNombreHorario", "pIdTurnoDom", "pIdTurnoLun", "pIdTurnoMar", "pIdTurnoMie", "pIdTurnoJue", "pIdTurnoVie", "pIdTurnoSab", "pDetalles" };
                        if (DatosHorarioNuevo == null || DatosHorarioNuevo[0] == null)
                        {
                            DatosHorarioNuevo = new object[10];
                            DatosHorarioNuevo[0] = "";
                        }
                        DatosHorarioNuevo[0] = DatosHorarioNuevo[0].ToString().Trim();
                        DatosHorarioNuevo[1] = tbNombreHorario.Text;
                        DatosHorarioNuevo[2] = cbDomingo.SelectedValue;
                        DatosHorarioNuevo[3] = cbLunes.SelectedValue;
                        DatosHorarioNuevo[4] = cbMartes.SelectedValue;
                        DatosHorarioNuevo[5] = cbMiercoles.SelectedValue;
                        DatosHorarioNuevo[6] = cbJueves.SelectedValue;
                        DatosHorarioNuevo[7] = cbViernes.SelectedValue;
                        DatosHorarioNuevo[8] = cbSabado.SelectedValue;
                        DatosHorarioNuevo[9] = tbObservacionesHorario.Text;

                        ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarHorario", NombresGuardarHorario, DatosHorarioNuevo);
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
                        MessageBox.Show("ASIGNACIÓN DE HORARIO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("EL HORARIO NO PUDO SER ASIGNADO, POR FAVOR INTENTE OTRA VEZ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarDatosHorario();
                    ListarHorariosExistentes();
                }
                else
                    MessageBox.Show("EL NOMBRE DE HORARIO NO PUEDE ESTAR VACIO", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("DEBE SELECCIONAR TURNOS PARA ASIGNARLAS A CADA DIA", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }



        public void LimpiarDatosHorario()
        {
            DatosHorarioNuevo = new object[10];
            DatosHorarioNuevo[0] = "";
            tbNombreHorario.Text = "";
            tbObservacionesHorario.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
        }



        public void ListarTurnosExistentes()
        {
            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
       


            DataSet TurnosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbDomingo, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbLunes, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbMartes, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbMiercoles, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbJueves, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbViernes, true, "spuhor_ListarTurnosExistentes");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbSabado, true, "spuhor_ListarTurnosExistentes");

           
            ConexionBD.Desconectar();


        }

        private void dgvHorariosExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)) && dgvHorariosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString() != "1")
            {
                if (e.ColumnIndex == 0)
                {// EDITAR
                    tbNombreHorario.Text = dgvHorariosExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbObservacionesHorario.Text = dgvHorariosExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cbLunes.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[5].Value;
                    cbMartes.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[6].Value;
                    cbMiercoles.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[7].Value;
                    cbJueves.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[8].Value;
                    cbViernes.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[9].Value;
                    cbSabado.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[10].Value;
                    cbDomingo.SelectedValue = dgvHorariosExistentes.Rows[e.RowIndex].Cells[11].Value;


                    DatosHorarioNuevo = new object[10];
                    DatosHorarioNuevo[0] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosHorarioNuevo[1] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DatosHorarioNuevo[2] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DatosHorarioNuevo[3] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[5].Value;
                    DatosHorarioNuevo[4] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[6].Value;
                    DatosHorarioNuevo[5] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[7].Value;
                    DatosHorarioNuevo[6] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[8].Value;
                    DatosHorarioNuevo[7] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[9].Value;
                    DatosHorarioNuevo[8] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[10].Value;
                    DatosHorarioNuevo[9] = dgvHorariosExistentes.Rows[e.RowIndex].Cells[11].Value;

                    cbPonerMismoHorario.Checked = false;


                    tipo = Tipo.modificar;
                    habilitaBoton();

                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE HORARIO? \r\nSi elimina este horario cualquier trabajador registrado con este horario \r\npasara a tener el horario por DEFAULT", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosHorario();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        bool SeElimino = false;
                        try
                        {
                            ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_EliminarHorario", "pIdHorario", dgvHorariosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("HORARIO ELIMINADO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("HUBO UN ERROR AL ELIMINAR EL HORARIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarHorariosExistentes();
                    }
                }
            }
        }











    }
}
