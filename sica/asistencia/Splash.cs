using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            tiempo.Enabled = true;
            tiempo.Interval = 3000;
        }


             
        private void tiempo_Tick(object sender, EventArgs e)
        {
            tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
