using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Data.OleDb;

namespace asistencia
{
    public partial class frmImportExcel : Form
    {
        cLeeXls ClaseExcel = new cLeeXls();
        public frmImportExcel()
        {
            InitializeComponent();
        }

        private void frmImportExcel_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbreXLS();
            
        }

        /// <summary>
        /// METODO QUE LEE EXCEL SOLO COLUMNAS BIEN DEFINIDAS--- LANZA ERROR AL LEER CELDAS NULAS Y COMBINADAS
        /// </summary>
        private void AbreXLS()
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Archivo Excel"; // Default file name
            dlg.DefaultExt = ".xlsx"; // Default file extension
            dlg.Filter = "Text documents (.xlsx)|*.xlsx"; // Filter files by extension

      
            // Process open file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                tbNomabreArchivo.Text = filename;

                
                //DataTable datos = cLeeXls.ReadAsDataTable(filename);
                DataTable datos = cLeeXls.ExtractExcelSheetValuesToDataTable(filename,null);
                dgvExcel.DataSource = datos;
                
            }
        }










       



   

    }
}
