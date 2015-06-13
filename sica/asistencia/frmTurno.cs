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
    public partial class frmTurno : Form
    {




        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] DatosHorarioNuevo = new object[10];
        object[] margenes = new object[5];
        string IdTurnoNuevo = "";
        string string_ArchivoConfiguracion;


        public frmTurno(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            MostrarDatos();
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {

        }
        private void MostrarDatos()
        {
            ListarTurnosExistentes();

        }

        public void ListarTurnosExistentes()
        {
            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvTurnosExistentes.Rows.Clear();


            DataSet TurnosExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_ListarTurnosExistentes");
  

            object[] ValoresFila = new object[5];
            dgvTurnosExistentes.Rows.Add(TurnosExistentes.Tables[0].Rows.Count);

            for (int i = 0; i < TurnosExistentes.Tables[0].Rows.Count; i++)
            {
                dgvTurnosExistentes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                dgvTurnosExistentes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                dgvTurnosExistentes.Rows[i].Cells[2].Value = TurnosExistentes.Tables[0].Rows[i][0];//id
                dgvTurnosExistentes.Rows[i].Cells[3].Value = TurnosExistentes.Tables[0].Rows[i][1];//nombre
                dgvTurnosExistentes.Rows[i].Cells[4].Value = TurnosExistentes.Tables[0].Rows[i][2];//nomenclatura
                dgvTurnosExistentes.Rows[i].Cells[5].Value = TurnosExistentes.Tables[0].Rows[i][3];//obs                
                ////para los mnargenes
                //dgvTurnosExistentes.Rows[i].Cells[6].Value = TurnosExistentes.Tables[0].Rows[i][4];//MARGEN 1               
                //dgvTurnosExistentes.Rows[i].Cells[7].Value = TurnosExistentes.Tables[0].Rows[i][5];//MARGEN 2                
                //dgvTurnosExistentes.Rows[i].Cells[8].Value = TurnosExistentes.Tables[0].Rows[i][6];//MARGEN 3                
                //dgvTurnosExistentes.Rows[i].Cells[9].Value = TurnosExistentes.Tables[0].Rows[i][7];//MAEGEN 4                

            }
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
            gbTurnos.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            dgvSubturnos.Enabled = dgvSubturnos.Rows.Count > 0;
            btnSubturno.Enabled = nudHoraInicio.Value > 0;
            dtp1.Enabled=  dgvSubturnos.Rows.Count >= 1;
            dtp2.Enabled = dgvSubturnos.Rows.Count >= 1;
            dtp3.Enabled = dgvSubturnos.Rows.Count >= 1;
            dtp4.Enabled = dgvSubturnos.Rows.Count >= 1;
            dtp5.Enabled = dgvSubturnos.Rows.Count > 1;
            dtp6.Enabled = dgvSubturnos.Rows.Count > 1;
            dtp7.Enabled = dgvSubturnos.Rows.Count > 1;
            dtp8.Enabled = dgvSubturnos.Rows.Count > 1;
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

            //((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int i_NroSubturnos = dgvSubturnos.Rows.Count;
            if (i_NroSubturnos > 0)
            {
                if (validaMargen())
                {
                    return;
                }
                if (tbNombreTurno.Text.Length >= 5)
                {
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool SeGuardo = false;
                    try
                    {
                        ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_EliminarTurnoPreProceso", "pIdTurno", IdTurnoNuevo);
                        object[] NombresGuardarTurno = { "pIdTurno", "pIdSubturno", "pNombreTurno", "pHoraInicio", "pHoraFin", "pNomenclatura", "pDetalles", "pM11", "pM12", "pM21", "pM22" };
                        object[] ValoresGuardarTurno = { IdTurnoNuevo.Trim(), 1, tbNombreTurno.Text, "10:00:00", "10:00:00", tbNomenclatura.Text, tbObservacionesTurno.Text, "pM11", "pM12", "pM21", "pM22"};

                        //object[] margenes = { "pIdMargen", "pM11", "pM12", "pM21", "pM22"};
                        //object[] ValoresMargenes = { "pIdMargen", "pM11", "pM12", "pM21", "pM22" };



                        for (int i = 0; i < i_NroSubturnos; i++)
                        {
                            ValoresGuardarTurno[1] = dgvSubturnos.Rows[i].Cells[1].Value.ToString();
                            ValoresGuardarTurno[3] = dgvSubturnos.Rows[i].Cells[2].Value.ToString();
                            ValoresGuardarTurno[4] = dgvSubturnos.Rows[i].Cells[3].Value.ToString();
                                                                               
                          
                            if (i == 0)
                            {
                                ValoresGuardarTurno[7] = dtp1.Value.Hour.ToString() + ":" + dtp1.Value.Minute.ToString() + ":" + dtp1.Value.Second.ToString();
                                ValoresGuardarTurno[8] = dtp2.Value.Hour.ToString() + ":" + dtp2.Value.Minute.ToString() + ":" + dtp2.Value.Second.ToString();
                                ValoresGuardarTurno[9] = dtp3.Value.Hour.ToString() + ":" + dtp3.Value.Minute.ToString() + ":" + dtp3.Value.Second.ToString();
                                ValoresGuardarTurno[10] = dtp4.Value.Hour.ToString() + ":" + dtp4.Value.Minute.ToString() + ":" + dtp4.Value.Second.ToString();
                               
                            }
                            if (i == 1)
                            {
                                ValoresGuardarTurno[7] = dtp5.Value.Hour.ToString() + ":" + dtp5.Value.Minute.ToString() + ":" + dtp5.Value.Second.ToString();
                                ValoresGuardarTurno[8] = dtp6.Value.Hour.ToString() + ":" + dtp6.Value.Minute.ToString() + ":" + dtp6.Value.Second.ToString();
                                ValoresGuardarTurno[9] = dtp7.Value.Hour.ToString() + ":" + dtp7.Value.Minute.ToString() + ":" + dtp7.Value.Second.ToString();
                                ValoresGuardarTurno[10] = dtp8.Value.Hour.ToString() + ":" + dtp8.Value.Minute.ToString() + ":" + dtp8.Value.Second.ToString();
                                
                            }

                            ConexionBD.EjecutarProcedimientoReturnMensaje("spuHor_GuardarTurnoSubturno", NombresGuardarTurno, ValoresGuardarTurno);
                        }

                        ConexionBD.COMMIT();
                        SeGuardo = true;
                    }
                    catch
                    {
                        ConexionBD.ROLLBACK();
                        SeGuardo = false;
                    }
                    finally
                    {
                        ConexionBD.Desconectar();
                    }

                    if (SeGuardo)
                        MessageBox.Show("EL TURNO SE GUARDO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("HUBO UN ERROR AL GUARDAR EL TURNO, POR FAVOR INTENTE NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    LimpiarDatosTurno();

                    ListarTurnosExistentes();


                    tipo = Tipo.guardar;
                    habilitaBoton();
                }
                else
                    MessageBox.Show("EL NOMBRE DE TURNO NO PUEDE ESTAR VACIO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("POR LO MENOS DEBE EXISTIR UN SUB TURNO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




        }


        private bool validaMargen()
        {
            bool retorna = false;
            if (dgvSubturnos.Rows.Count == 1)
            {
                epValida.Clear();
                if (dtp1.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp1, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE ENTRDA ");
                    return true;
                }
                if (dtp2.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp2, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE ENTRADA");
                    return true;
                }
                if (dtp3.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp3, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE SALIDA");
                    return true;
                }
                if (dtp4.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp4, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE SALIDA");
                    return true;
                }
                return retorna;
            }
            else
            {
                epValida.Clear();
                if (dtp1.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp1, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE ENTRDA ");
                    return true;
                }
                if (dtp2.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp2, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE ENTRADA");
                    return true;
                }
                if (dtp3.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp3, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE SALIDA");
                    return true;
                }
                if (dtp4.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp4, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE SALIDA");
                    return true;
                }
                epValida.Clear();
                if (dtp5.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp5, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE ENTRDA ");
                    return true;
                }
                if (dtp6.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp6, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE ENTRADA");
                    return true;
                }
                if (dtp7.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp7, "INGRESE HORA EN EL QUE INICIA EL REGISTRO DE SALIDA");
                    return true;
                }
                if (dtp8.Value == Convert.ToDateTime("01/01/2015 12:00:00am"))
                {
                    epValida.SetError(dtp8, "INGRESE HORA EN EL QUE FINALIZA EL REGISTRO DE SALIDA");
                    return true;
                }
                return retorna;
            }
            
        }



        private void LimpiarDatosTurno()
        {
            IdTurnoNuevo = "";
            tbNombreTurno.Text = "";
            tbObservacionesTurno.Text = "";
            tbNomenclatura.Text = "";
            dgvSubturnos.Rows.Clear();
            tbNombreTurno.Focus();
            tbNombreTurno.Select();

            dtp1.Value =Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp2.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp3.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp4.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp5.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp6.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp7.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
            dtp8.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            LimpiarDatosTurno();
            habilitaBoton();
        }

        private void btnSubturno_Click(object sender, EventArgs e)
        {
            double horaInicio,horafin;
            horaInicio = Convert.ToDouble(nudHoraInicio.Value + (nudMinutoIni.Value / 60));
            horafin = Convert.ToDouble(nudHoraFin.Value + (nudMinutoFin.Value / 60));
            if (horaInicio < horafin)
            {

                int HoraInicioAux = ((int)nudHoraInicio.Value) * 60 + (int)nudMinutoIni.Value;
                int HoraFinAux = ((int)nudHoraFin.Value) * 60 + (int)nudMinutoFin.Value;
                //if (HoraFinAux > HoraInicioAux)
                //{
                int NroFilas = dgvSubturnos.Rows.Count + 1;
                if (NroFilas > 1)
                {
                    string HoraSalAnterior = dgvSubturnos.Rows[NroFilas - 2].Cells[3].Value.ToString();
                    string[] HoraMinSegSaliAnterior = HoraSalAnterior.Split(':');
                    int HoraSalidaAnteriorAux = int.Parse(HoraMinSegSaliAnterior[0]) * 60 + int.Parse(HoraMinSegSaliAnterior[1]);
                    if (HoraSalidaAnteriorAux <= HoraInicioAux)
                    {
                        object[] NuevoSubturno = { (System.Drawing.Image)(asistencia.Properties.Resources.delete), NroFilas, nudHoraInicio.Value.ToString().Trim() + ":" + nudMinutoIni.Value.ToString().Trim() + ":00", nudHoraFin.Value.ToString().Trim() + ":" + nudMinutoFin.Value.ToString().Trim() + ":00" };
                        dgvSubturnos.Rows.Add(NuevoSubturno);

                    }
                }
                else
                {
                    object[] NuevoSubturno = { (System.Drawing.Image)(asistencia.Properties.Resources.delete), NroFilas, nudHoraInicio.Value.ToString().Trim() + ":" + nudMinutoIni.Value.ToString().Trim() + ":00", nudHoraFin.Value.ToString().Trim() + ":" + nudMinutoFin.Value.ToString().Trim() + ":00" };
                    dgvSubturnos.Rows.Add(NuevoSubturno);
                }
                tipo = Tipo.subturno;
                habilitaBoton();

            }
        }

   


        private void dgvSubturnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {//ELIMINAR EL SUBTURNO                
                dgvSubturnos.Rows.RemoveAt(e.RowIndex);
                int i_NroSubturnos = dgvSubturnos.Rows.Count;
                for (int i = 0; i < i_NroSubturnos; i++)
                {
                    dgvSubturnos.Rows[i].Cells[1].Value = i + 1;
                }
            }
        }

        private void dgvTurnosExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarDatosTurno(); 
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)) && dgvTurnosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString() != "1" && dgvTurnosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString() != "0")
            {
                if (e.ColumnIndex == 0)
                {// EDITAR
                    IdTurnoNuevo = dgvTurnosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbNombreTurno.Text = dgvTurnosExistentes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbNomenclatura.Text = dgvTurnosExistentes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbObservacionesTurno.Text = dgvTurnosExistentes.Rows[e.RowIndex].Cells[5].Value.ToString();

                 

                    // RECUPERAR SUBTURNOS
                    ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                    DataSet dsSubTurnos = ConexionBD.EjecutarProcedimientoReturnDataSet("spuTur_ListarSubturnos", "pIdTurno", IdTurnoNuevo);
                    ConexionBD.Desconectar();

                    if (dsSubTurnos != null && dsSubTurnos.Tables != null && dsSubTurnos.Tables[0].Rows.Count > 0)
                    {
                        int i_NroSubturnos = dsSubTurnos.Tables[0].Rows.Count;
                        dgvSubturnos.Rows.Clear();
                        dgvSubturnos.Rows.Add(i_NroSubturnos);

                        


                        for (int i = 0; i < i_NroSubturnos; i++)
                        {

                            //para mostrar los valores de los margenes
                            if (i == 0)
                            {
                                dtp1.Text = dsSubTurnos.Tables[0].Rows[i][3].ToString();
                                dtp2.Text = dsSubTurnos.Tables[0].Rows[i][4].ToString();
                                dtp3.Text = dsSubTurnos.Tables[0].Rows[i][5].ToString();
                                dtp4.Text = dsSubTurnos.Tables[0].Rows[i][6].ToString();
                            }
                            if (i == 1)
                            {
                                dtp5.Text = dsSubTurnos.Tables[0].Rows[i][3].ToString();
                                dtp6.Text = dsSubTurnos.Tables[0].Rows[i][4].ToString();
                                dtp7.Text = dsSubTurnos.Tables[0].Rows[i][5].ToString();
                                dtp8.Text = dsSubTurnos.Tables[0].Rows[i][6].ToString();
                            }
                            //fin margenes

                           
                            dgvSubturnos.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                            dgvSubturnos.Rows[i].Cells[1].Value = dsSubTurnos.Tables[0].Rows[i][0].ToString();
                            dgvSubturnos.Rows[i].Cells[2].Value = dsSubTurnos.Tables[0].Rows[i][1].ToString();
                            dgvSubturnos.Rows[i].Cells[3].Value = dsSubTurnos.Tables[0].Rows[i][2].ToString();
                   

                            tipo = Tipo.modificar;
                            habilitaBoton();

                        }
                    }

                }
                else
                {//ELIMINAR

                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE TURNO ? \r\nSi elimina este turno cualquier horario con algun dia con este turno \r\npasara a tener el turno por DEFAULT", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosTurno();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        bool SeElimino = false;
                        try
                        {
                            ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_EliminarTurno", "pIdTurno", dgvTurnosExistentes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("TURNO ELIMINADO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("HUBO UN ERROR AL ELIMINAR EL TURNO, POR FAVOR INTENTE NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                        ListarTurnosExistentes();
                    }
                }
            }
        }

        private void nudHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            tipo = Tipo.subturno;
            habilitaBoton();
        }

       

       
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
