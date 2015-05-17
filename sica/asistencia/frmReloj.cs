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
    public partial class frmReloj : Form
    {
        CValidacion ValidarDatos;
        object[] DatosDeReloj = new object[2];
        string string_ArchivoConfiguracion;
        CConection ConexionBD;

        public frmReloj(string ArchivoConfig)
        {
            string_ArchivoConfiguracion = ArchivoConfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();

            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
            //lbActual.Text = configXml_ArchivoConfiguracion.GetValue("principal", "ipmaquina", "192.168.1.201");


            ListarReloj();

            DatosDeReloj = new object[2];
          
        }

        private void LimpiarDatosReloj()
        {
            DatosDeReloj = new object[2];
            tbIP.Text = "";
            tbNombre.Text = "";
            tbIP.Focus();
            tbIP.Select();
        }

        private void ListarReloj()
        {

            //Cargar areas
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvRelojes.Rows.Clear();


            DataSet relojes = ConexionBD.EjecutarProcedimientoReturnDataSet("spuofi_ListarReloj");

            object[] ValoresFila = new object[4];
            if (relojes.Tables[0].Rows.Count >= 1)
            {

                dgvRelojes.Rows.Add(relojes.Tables[0].Rows.Count);

                for (int i = 0; i < relojes.Tables[0].Rows.Count; i++)
                {
                    dgvRelojes.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                    dgvRelojes.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                    dgvRelojes.Rows[i].Cells[2].Value = relojes.Tables[0].Rows[i][0];//ip
                    dgvRelojes.Rows[i].Cells[3].Value = relojes.Tables[0].Rows[i][1];//nombre
                    
                }
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
            gbDatos.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            dgvRelojes.Enabled = dgvRelojes.Rows.Count > 0;
            tbIP.Enabled = tipo == Tipo.guardar;


        }
        #endregion

        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

        private void frmReloj_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();

            LimpiarDatosReloj();
        }

        private void tbIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "TipoIP", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbIP.Text.Trim() != "")
            {
                GuardarDatosReloj();
            }
            else
                MessageBox.Show("EL NOMBRE DE AREA DEBE CONTENER AL MENOS 3 CARACTERES", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        
        }


        private void GuardarDatosReloj()
        {
            
            DatosDeReloj[0] = tbIP.Text.Trim();
            DatosDeReloj[1] = tbNombre.Text;

            object[] NombresDatosReloj = { "pIP", "pNombre"};

            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool SeGuardo = false;
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuofi_GuardaReloj", NombresDatosReloj, DatosDeReloj);
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
                MessageBox.Show("LOS DATOS SE GUARDARON EXITOSAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosReloj();
            }
            else
                MessageBox.Show("ERROR AL GUARDAR LOS DATOS, INTENTE NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarReloj();
        }

      

        private void dgvRelojes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 1) || (e.ColumnIndex == 0)))
            {
                if (e.ColumnIndex == 0)
                {
                    // EDITAR
                    tbIP.Text = dgvRelojes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbNombre.Text = dgvRelojes.Rows[e.RowIndex].Cells[3].Value.ToString();

                    DatosDeReloj = new object[2];
                    DatosDeReloj[0] = dgvRelojes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DatosDeReloj[1] = dgvRelojes.Rows[e.RowIndex].Cells[3].Value.ToString();
                   

                    tipo = Tipo.modificar;
                    habilitaBoton();
                }
                else
                {//ELIMINAR
                    if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR EL DISPOSITIVO BIOMÉTRICO? ", "CUIDADO!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        LimpiarDatosReloj();
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        string Mensaje = "NO SE EJECUTO PROCEDIMIENTO ALMACENADO";
                        bool SeElimino = false;
                        try
                        {
                            Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuofi_EliminaReloj", "pIP", dgvRelojes.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                            MessageBox.Show("ERROR AL ELIMINAR EL DISPOSITIVO BIOMÉTRICO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarReloj();
                    }
                }
            }
        }

      

       



    
    
    
    
    
    
    }
}
