using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class foto : UserControl
    {
        string aDNI = "";
        public foto()
        {
            InitializeComponent();
        }

        public void AsignarFoto(string pDNI, string pNombres, string pFecha, Image pImagenFoto)
        {
            aDNI = pDNI;
            tbNombre.Text = pNombres;
            lbFecha.Text = pFecha;
            pbFoto.Image = pImagenFoto;
        }
    }
}
