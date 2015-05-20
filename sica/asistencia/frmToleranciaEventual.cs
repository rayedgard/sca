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
    public partial class frmToleranciaEventual : Form
    {

        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] tolerancias = new object[3];
        string string_ArchivoConfiguracion;



        public frmToleranciaEventual(string ArchivoCOnfig)
        {
  

            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            MostrarDatos();
            dtpFecha.Value = DateTime.Now;

        }
        private void MostrarDatos()
        {
            ListarTolerancias();
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();

            limpiarUsuario();
        }

        public void ListarTolerancias()
        {
            //Cargar horarios
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvDatos.Rows.Clear();

            try
            {
                DataSet toleranciasExistentes = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_listarToleranciasEve");
                dgvDatos.Rows.Add(toleranciasExistentes.Tables[0].Rows.Count);
                for (int i = 0; i < toleranciasExistentes.Tables[0].Rows.Count; i++)
                {
                    dgvDatos.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvDatos.Rows[i].Cells[1].Value = toleranciasExistentes.Tables[0].Rows[i][0];//detalle
                    dgvDatos.Rows[i].Cells[2].Value = toleranciasExistentes.Tables[0].Rows[i][1];//fecha
                    dgvDatos.Rows[i].Cells[3].Value = toleranciasExistentes.Tables[0].Rows[i][2];//hora 

                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
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
            dgvDatos.Enabled = dgvDatos.Rows.Count > 0;


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

        public void limpiarUsuario()
        {
            tbDetalle.Text = "";
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = Convert.ToDateTime("01/01/2015 12:00:00am");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbDetalle.Text.Length >= 5)
            {
                
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool SeGuardo = false;
                    try
                    {
                        object[] NombresTolerancias = { "pDetalle", "pFecha", "pHora"};

                        tolerancias[0] = tbDetalle.Text.Trim();
                        tolerancias[1] = ConexionBD.FechaFormatoMySQL(dtpFecha.Value, 0);
                        tolerancias[2] = dtpHora.Value;


                        string mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("nuevo_GuardarToleranciasEve", NombresTolerancias, tolerancias);
                        if (mensaje == "duplicado")
                        {
                            MessageBox.Show("TOLERANCIA DUPLICADA, YA EXISTE UNA TOLERANCIA CONFIGURADA PARA ESTA FECHA!!", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ConexionBD.COMMIT();
                            SeGuardo = true;

                            tipo = Tipo.guardar;
                            habilitaBoton();
                        }
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
                        MessageBox.Show("HUBO UN ERROR AL GUARDAR LA TOLERANCIA, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //LimpiarDatosHorario();
                    //ListarHorariosExistentes();  
              
            }
            else
                MessageBox.Show("EL DETALLE DEBE CONTENER AL MENOS 5 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpiarUsuario();
            ListarTolerancias();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTA TOLERANCIA? \r", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //LimpiarDatosHorario();
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool SeElimino = false;
                    string fechaDTP= ConexionBD.FechaFormatoMySQL(dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString(),0);
                    try
                    {
                        ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_elimiaToleranciaEve", "pfecha", fechaDTP);
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
                        MessageBox.Show("HUBO UN ERROR AL ELIMINAR LA TOLERANCIA, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarTolerancias();

                }
            }
        }
    
    
    
    
    
    
    
    }
}
