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
    public partial class frmBuscarDNI : Form
    {


        CConection conBD;
        public string pDNI = "";
        string string_ArchivoConfiguracion;
       
        
        public frmBuscarDNI(string ArchivoConfig)
        {
            string_ArchivoConfiguracion = ArchivoConfig;
            InitializeComponent();
            conBD = new CConection();

        }


        public void rotativo(bool valor)
        {
            try
            {
                conBD.Conectar(false, string_ArchivoConfiguracion);
                DataSet dsDatosGrid = conBD.EjecutarProcedimientoReturnDataSet("spupri_BuscarPersonal_Filtro", "pFiltro", filtro.Text);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dsDatosGrid.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dsDatosGrid.Tables[0].Rows[i].ItemArray);
                }

                conBD.Desconectar();
            }
            catch { }
        }

        public bool bandera = false;
        



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pDNI = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                lbSELECCIONADO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

       

        private void filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            rotativo(bandera);
        }


        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pDNI = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                lbSELECCIONADO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void frmBuscarDNI_Load(object sender, EventArgs e)
        {
            this.ActiveControl = filtro;
        }










        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

   

        private void pbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rotativo(bandera);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pDNI = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                lbSELECCIONADO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
            catch
            {
            }
        }

       
    }
}
