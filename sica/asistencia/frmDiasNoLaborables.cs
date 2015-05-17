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
    public partial class frmDiasNoLaborables : Form
    {
       

        CValidacion ValidarDatos;
        CConection ConexionBD;
        object[] VariablesDiaFeriado = { "pIdTipoDiaFeriado","pNombreFeriado","pHoraInicio","pHoraFin","pTodoElDia","pColorFeriado","pImagenMenu","pDetalles"};
        object[] DatosDiaFeriado = new object[8];

        //ArrayList ListaMenuDiasFeriados;
        //object[] ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
        //object[] DatosRecuperarDiasFeriados = { 01, 2011 };
        string string_ArchivoConfiguracion;

        public frmDiasNoLaborables(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
      

            LimpiarDatosTipoDiaFeriado();

            CargarDiasFeriados();
          
          
        }



        private void CargarDiasFeriados()
        {
            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvDiasFeriados.Rows.Clear();
            DataSet DiasNoLaborables = ConexionBD.EjecutarProcedimientoReturnDataSet("spudia_ListarDiasNoLaborables");

            object[] ValoresFila = new object[9];
            dgvDiasFeriados.Rows.Add(DiasNoLaborables.Tables[0].Rows.Count);

            for (int i = 0; i < DiasNoLaborables.Tables[0].Rows.Count; i++)
            {
                dgvDiasFeriados.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                dgvDiasFeriados.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                dgvDiasFeriados.Rows[i].Cells[2].Value = DiasNoLaborables.Tables[0].Rows[i][0];
                dgvDiasFeriados.Rows[i].Cells[3].Value = DiasNoLaborables.Tables[0].Rows[i][1];
                dgvDiasFeriados.Rows[i].Cells[4].Value = true;
                if (DiasNoLaborables.Tables[0].Rows[i][2].ToString() == "N")
                    dgvDiasFeriados.Rows[i].Cells[4].Value = false;
                dgvDiasFeriados.Rows[i].Cells[5].Value = DiasNoLaborables.Tables[0].Rows[i][3];//HORA INICIO
                dgvDiasFeriados.Rows[i].Cells[6].Value = DiasNoLaborables.Tables[0].Rows[i][4];// HORA FIN
                dgvDiasFeriados.Rows[i].Cells[7].Value = "";// COLOR
                dgvDiasFeriados.Rows[i].Cells[7].Style.BackColor = ColorTranslator.FromWin32(int.Parse(DiasNoLaborables.Tables[0].Rows[i][5].ToString()));// COLOR
                dgvDiasFeriados.Rows[i].Cells[8].Value = ConexionBD.Bytes2Image((byte[])DiasNoLaborables.Tables[0].Rows[i][6]);
            }
            ConexionBD.Desconectar();

            //CargarListaMenuPaCalendario();
        }

        private void LimpiarDatosTipoDiaFeriado()
        {
            DatosDiaFeriado[0] = "0";//Id
            DatosDiaFeriado[1] = "";//Nombre
            DatosDiaFeriado[2] = "";//Hora Ini
            DatosDiaFeriado[3] = "";// Hora Fin
            DatosDiaFeriado[4] = "S";
            DatosDiaFeriado[5] = "";
            DatosDiaFeriado[6] = "";
            DatosDiaFeriado[7] = "";

            tbNombreFeriado.Text = "";
            rbSiTodoDia.Checked = true;
            nudHoraInicio.Value = 0;
            nudMinutoIni.Value = 0;
            nudHoraFIn.Value = 23;
            nudMInutoFin.Value = 59;

            paColorFondo.BackColor = Color.Firebrick;
            pbImagenMenu.Image = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);

            tbNombreFeriado.Focus();
            tbNombreFeriado.Select();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosTipoDiaFeriado();
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
            dgvDiasFeriados.Enabled = dgvDiasFeriados.Rows.Count > 0;


        }
        #endregion


        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

       

        private void paColorFondo_Click(object sender, EventArgs e)
        {
            if (cdSeleccionarColor.ShowDialog() == DialogResult.OK)
            {
                paColorFondo.BackColor = cdSeleccionarColor.Color;
            }
        }

        private void pbImagenMenu_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }


        private void CargarFoto()
        {
            this.ofd_CargarImagen.Title = "Cargar Imagen Menu";
            this.ofd_CargarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            this.ofd_CargarImagen.Filter = "Imagenes (*.gif)|*.gif|Imagenes(*.bmp)|*.bmp|Imagenes(*.jpg)|*.jpg|Imagenes(*.png)|*.png";

            this.ofd_CargarImagen.DefaultExt = "jpg";
            this.ofd_CargarImagen.FilterIndex = 3;
            this.ofd_CargarImagen.FileName = "";

            if (this.ofd_CargarImagen.ShowDialog() == DialogResult.OK)
            {
                if (this.ofd_CargarImagen.FileName != string.Empty)
                {
                    try
                    {
                        this.pbImagenMenu.Image = Image.FromFile(this.ofd_CargarImagen.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbImagenMenu.Image = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);
                    }

                }
                else
                {
                    pbImagenMenu.Image = (System.Drawing.Image)(asistencia.Properties.Resources.Navidad_Christmas_Tree);
                }


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTipoDiaFeriado();
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatosTipoDiaFeriado();

        }

        private void GuardarTipoDiaFeriado()
        {
            if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbNombreFeriado, 3))
            {
                int HoraInicioAux = ((int)nudHoraInicio.Value) * 60 + (int)nudMinutoIni.Value;
                int HoraFinAux = ((int)nudHoraFIn.Value) * 60 + (int)nudMInutoFin.Value;
                if (HoraFinAux > HoraInicioAux || rbSiTodoDia.Checked)
                {
                    if (rbSiTodoDia.Checked)
                    {
                        nudHoraInicio.Value = 0;
                        nudMinutoIni.Value = 0;
                        nudHoraFIn.Value = 23;
                        nudMInutoFin.Value = 59;
                    }
                    // object[] VariablesDiaFeriado = {     "pIdTipoDiaFeriado","pNombreFeriado","pHoraInicio",
                    //                                      "pHoraFin","pTodoElDia","pColorFeriado",
                    //                                      "pImagenMenu","pDetalles"};         
                    DatosDiaFeriado[1] = tbNombreFeriado.Text;
                    //nudMinutoIni.Value.ToString().Trim() + ":00", nudHoraFIn.Value.ToString().Trim() + ":" + nudMInutoFin.Value.ToString().Trim() + ":00" };

                    DatosDiaFeriado[2] = nudHoraInicio.Value.ToString().Trim() + ":" + nudMinutoIni.Value.ToString().Trim() + ":00";
                    DatosDiaFeriado[3] = nudHoraFIn.Value.ToString().Trim() + ":" + nudMInutoFin.Value.ToString().Trim() + ":00";
                    DatosDiaFeriado[4] = "S";
                    if (rbNoTodoDia.Checked)
                        DatosDiaFeriado[4] = "N";
                    DatosDiaFeriado[5] = ColorTranslator.ToWin32(paColorFondo.BackColor);
                    DatosDiaFeriado[6] = ConexionBD.Image2Bytes(pbImagenMenu.Image);
                    DatosDiaFeriado[7] = "";

                    // Guardar los datos
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool TransaccionCompletada = false;
                    string Mensaje = "";
                    try
                    {
                        ConexionBD.EjecutarProcedimientoReturnVoid("spuDia_GuardarTipoDiaFeriado", VariablesDiaFeriado, DatosDiaFeriado);
                        TransaccionCompletada = true;
                        ConexionBD.COMMIT();
                    }
                    catch (Exception ex)
                    {
                        ConexionBD.ROLLBACK();
                        TransaccionCompletada = false;
                        Mensaje = ex.Message;
                    }
                    finally
                    {
                        ConexionBD.Desconectar();
                    }


                    if (TransaccionCompletada)
                    {
                        MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatosTipoDiaFeriado();
                        CargarDiasFeriados();
                    }
                    else
                        MessageBox.Show("NO SE PUDO GUARDAR LOS DATOS, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("La Hora de termino del feriado debe ser mayor que la hora de inicio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("EL CAMPO NOMBRE DEL TIPO DE DIA FERIADO NO PUEDE SER VACIO O TIENE LONGITUD MINIMA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvDiasFeriados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvDiasFeriados.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() != "1")
            {
                DatosDiaFeriado[0] = dgvDiasFeriados.Rows[e.RowIndex].Cells[2].Value;//Id
                DatosDiaFeriado[1] = dgvDiasFeriados.Rows[e.RowIndex].Cells[3].Value;//Nombre
                DatosDiaFeriado[2] = dgvDiasFeriados.Rows[e.RowIndex].Cells[5].Value;//Hora Ini
                DatosDiaFeriado[3] = dgvDiasFeriados.Rows[e.RowIndex].Cells[6].Value;// Hora Fin
                DatosDiaFeriado[4] = "S";
                if ((bool)dgvDiasFeriados.Rows[e.RowIndex].Cells[4].Value == false)//DEtalles
                    DatosDiaFeriado[4] = "N";
                DatosDiaFeriado[5] = ColorTranslator.ToWin32(dgvDiasFeriados.Rows[e.RowIndex].Cells[7].Style.BackColor);// Color Fondo
                DatosDiaFeriado[6] = ConexionBD.Image2Bytes((Image)dgvDiasFeriados.Rows[e.RowIndex].Cells[8].Value);// Imagen Menu
                DatosDiaFeriado[7] = "";

                tbNombreFeriado.Text = DatosDiaFeriado[1].ToString();
                rbSiTodoDia.Checked = true;
                if (DatosDiaFeriado[4].ToString() != "S")//Detalles
                    rbNoTodoDia.Checked = true;

                string[] AuxHoraInicio = DatosDiaFeriado[2].ToString().Split(':');
                string[] AuxHoraFin = DatosDiaFeriado[3].ToString().Split(':');

                nudHoraInicio.Value = int.Parse(AuxHoraInicio[0]);
                nudMinutoIni.Value = int.Parse(AuxHoraInicio[1]);

                nudHoraFIn.Value = int.Parse(AuxHoraFin[0]);
                nudMInutoFin.Value = int.Parse(AuxHoraFin[1]);


                paColorFondo.BackColor = ColorTranslator.FromWin32(int.Parse(DatosDiaFeriado[5].ToString()));
                pbImagenMenu.Image = (Image)dgvDiasFeriados.Rows[e.RowIndex].Cells[8].Value;

                tipo = Tipo.modificar;
                habilitaBoton();


            }
            else
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 1 && dgvDiasFeriados.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() != "1")
                {
                    if (MessageBox.Show("¿Esta Seguro que quiere eliminar este dia feriado (" + dgvDiasFeriados.Rows[e.RowIndex].Cells[3].Value.ToString() + ")?, \r\n Si lo hace cualquier dia marcado con este tipo de dia feriado pasara a ser dia laborable", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Guardar los datos
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        bool TransaccionCompletada = false;
                        string Mensaje = "";
                        try
                        {
                            ConexionBD.EjecutarProcedimientoReturnVoid("spuDia_EliminarTipoDiaFeriado", VariablesDiaFeriado[0], dgvDiasFeriados.Rows[e.RowIndex].Cells[2].Value);
                            TransaccionCompletada = true;
                            ConexionBD.COMMIT();

                            tipo = Tipo.eliminar;
                            habilitaBoton();
                        }
                        catch (Exception ex)
                        {
                            ConexionBD.ROLLBACK();
                            TransaccionCompletada = false;
                            Mensaje = ex.Message;
                        }
                        finally
                        {
                            ConexionBD.Desconectar();
                        }


                        if (TransaccionCompletada)
                        {
                            MessageBox.Show("DIA FERIADO ELIMINADO CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatosTipoDiaFeriado();
                            CargarDiasFeriados();
                           
                        }
                        else
                            MessageBox.Show("NO SE PUDO ELIMINAR EL TIPO DE DIA FERIADO \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void frmDiasNoLaborables_Load(object sender, EventArgs e)
        {

        }





    }
}
