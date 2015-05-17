using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    public partial class frmNuevoToletancia : Form
    {
     



        CConection ConexionBD;
        CValidacion ValidarDatos;
        object[] ToleranciaValores = new object[5];
        string string_ArchivoConfiguracion;

        public frmNuevoToletancia(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            //MostrarDatos();
            mostrarTolerancia();

        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if (tbTolerancia.Text.Length >= 1 && tbIntervalo1.Text.Length >= 1 && Convert.ToInt32(tbTolerancia.Text) < 60 && Convert.ToInt32(tbIntervalo1.Text) < 60)
            {
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                bool SeGuardo = false;
                try
                {
                    object[] nombresTolerancia = { "pIdTolerancia", "pTolerancia", "pIntervalo1", "pIntervalo2", "pIntervalo3" };
                    if (ToleranciaValores == null || ToleranciaValores[0] == null)
                    {
                        ToleranciaValores = new object[5];
                        ToleranciaValores[0] = "";
                    }
                    ToleranciaValores[0] = ToleranciaValores[0].ToString().Trim();
                    ToleranciaValores[1] = (Convert.ToInt32(tbTolerancia.Text) * 100).ToString();
                    ToleranciaValores[2] = (Convert.ToInt32(tbIntervalo1.Text) * 100).ToString();
                    ToleranciaValores[3] = (Convert.ToInt32(tbIntervalo2.Text) * 100).ToString();
                    ToleranciaValores[4] = (Convert.ToInt32(tbIntervalo3.Text) * 100).ToString();
                    //ToleranciaValores[1] = "00-" + tbTolerancia.Text +"-00";
                    //ToleranciaValores[2] = "00-" + tbTardanza.Text + "-00"; ;

                    ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_GuardarTolerancia", nombresTolerancia, ToleranciaValores);
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
                    MessageBox.Show("La asignación de tolerancia y tardanza se agregado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("La asignación de tolerancia y tardanza no pudo ser agregado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LimpiarDatosHorario();
                //ListarHorariosExistentes();  

            }
            else
                MessageBox.Show("Los valores asignados a los parametros no deben estar vacios ni mayores que 60, coloque al menos 0, para determinar nulidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // LimpiarDatosHorario();
        }


    
 



        public void mostrarTolerancia()
        {
            //Cargar horarios
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
             tbTolerancia.Text = "";
             tbIntervalo1.Text = "";
            try
            {
                ToleranciaValores = ConexionBD.RecuperarDatosEnArregloUnaFila("nuevoMostrarTolerancia");
                tbTolerancia.Text = ToleranciaValores[1].ToString();
                tbIntervalo1.Text = ToleranciaValores[2].ToString();
                tbIntervalo2.Text = ToleranciaValores[3].ToString();
                tbIntervalo3.Text = ToleranciaValores[4].ToString();
           }
            catch
            { }
            ConexionBD.Desconectar();
        }

        private void validaNumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



    }
}
