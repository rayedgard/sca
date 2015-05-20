using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using System.Diagnostics;
using System.IO;
using clases;


namespace asistencia
{
    public partial class Principal : Form
    {


        string a_IPMaquina;
        int a_Puerto;
        string string_ArchivoConfiguracion;


        CValidacion ValidarDatos;
        CConection ConexionBD;

        public Principal()
        {
            string_ArchivoConfiguracion = System.Environment.CurrentDirectory + @"\RelojSistema.cfg";
            ConexionBD = new CConection();
            InitializeComponent();
            CargarConfiguracionEquipo();
            cargaReloj();
        }
       
        
        
        public void CargarConfiguracionEquipo()
        {
            
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);

            a_IPMaquina = configXml_ArchivoConfiguracion.GetValue("principal", "ipmaquina", "192.168.1.201");
            a_Puerto = configXml_ArchivoConfiguracion.GetValue("principal", "nropuerto", 4370);

         
        }

        private void cargaReloj()
        {
            //Cargar Provincias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbIPreloj, true, "nuevo_listarReloj");
            ConexionBD.Desconectar();
        }
        
        private void pbPersonal_Click(object sender, EventArgs e)
        {
            
            frmPersonal1 per = new frmPersonal1(a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
             per.MdiParent = this;
            per.Show();
          
        }

        private void lbTurnos_Click(object sender, EventArgs e)
        {
            frmTurno turno = new frmTurno(string_ArchivoConfiguracion);
            turno.MdiParent = this;
            turno.Show();
        }

        private void lbLicencias_Click(object sender, EventArgs e)
        {
            frmLicencia licencia = new frmLicencia(string_ArchivoConfiguracion);
            licencia.MdiParent = this;
            licencia.Show();
        }

        private void pbTiposPersonal_Click(object sender, EventArgs e)
        {
            frmTipoPersonal tipoPer = new frmTipoPersonal(string_ArchivoConfiguracion);
            tipoPer.MdiParent = this;
            tipoPer.Show();
        }

        private void lbHorarios_Click(object sender, EventArgs e)
        {
            frmHorario horario = new frmHorario(string_ArchivoConfiguracion);
            horario.MdiParent = this;
            horario.Show();
        }

        private void áREASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAreas area = new frmAreas(string_ArchivoConfiguracion);
            area.MdiParent = this;
            area.Show();
        }

        private void aGENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgencia agencia = new frmAgencia(string_ArchivoConfiguracion);
            agencia.MdiParent = this;
            agencia.Show();
        }

        private void cIUDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudad = new frmCiudades(string_ArchivoConfiguracion);
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void mODALIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModalidad modalidad = new frmModalidad(string_ArchivoConfiguracion);
            modalidad.MdiParent = this;
            modalidad.Show();
        }

        private void dIASNOLABORABLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiasNoLaborables nolaborables = new frmDiasNoLaborables(string_ArchivoConfiguracion);
            nolaborables.MdiParent = this;
            nolaborables.Show();
        }

        private void lbCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario calendario = new frmCalendario(string_ArchivoConfiguracion);
            calendario.MdiParent = this;
            calendario.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios(string_ArchivoConfiguracion);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void rELOJESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReloj reloj = new frmReloj(string_ArchivoConfiguracion);
            reloj.MdiParent = this;
            reloj.Show();
        }

        private void tOLERANCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoToletancia tolerancia = new frmNuevoToletancia(string_ArchivoConfiguracion);
            tolerancia.MdiParent = this;
            tolerancia.Show();
        }

        private void tIPOSDELICENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoLIcencia tipolicencia = new frmTipoLIcencia(string_ArchivoConfiguracion);
            tipolicencia.MdiParent = this;
            tipolicencia.Show();
        }

        private void tIPOSDEPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoPermiso tipopermiso = new frmTipoPermiso(string_ArchivoConfiguracion);
            tipopermiso.MdiParent = this;
            tipopermiso.Show();
        }

        private void lbPermisos_Click(object sender, EventArgs e)
        {
            frmPermiso permiso = new frmPermiso(string_ArchivoConfiguracion);
            permiso.MdiParent = this;
            permiso.Show();
        }

        private void lbOmisiones_Click(object sender, EventArgs e)
        {
            frmOmision omision = new frmOmision(string_ArchivoConfiguracion);
            omision.MdiParent = this;
            omision.Show();
        }

        private void lbVacaciones_Click(object sender, EventArgs e)
        {
            frmVacaciones vaca = new frmVacaciones(string_ArchivoConfiguracion);
            vaca.MdiParent = this;
            vaca.Show();
        }

   


        private void cbIPreloj_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCambiaReloj.Enabled = true; 
        }

        private void btnCambiaReloj_Click(object sender, EventArgs e)
        {
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);

            configXml_ArchivoConfiguracion.SetValue("principal", "ipmaquina", cbIPreloj.SelectedValue.ToString());


            frmCambiarIP ip = new frmCambiarIP(string_ArchivoConfiguracion);
            ip.CargarConfiguracionEquipo();
            MessageBox.Show("Ud Cambio la conexión del RELOJ con IP:" + cbIPreloj.SelectedValue.ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbVolcar_Click(object sender, EventArgs e)
        {
            CargarConfiguracionEquipo();
            frmVolcarDatos volcar = new frmVolcarDatos(1, a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
            if (volcar != null && volcar.bIsConnected)
                volcar.ShowDialog();
        }

    
        private void lbVolvar_Click(object sender, EventArgs e)
        {
            CargarConfiguracionEquipo();
            frmVolcarDatos volcar = new frmVolcarDatos(1, a_IPMaquina, a_Puerto, string_ArchivoConfiguracion);
            if (volcar != null && volcar.bIsConnected)
                volcar.ShowDialog();
        }

        private void gESTIONDEFOTOGRAFICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFotos fotos = new frmFotos(string_ArchivoConfiguracion);
            fotos.MdiParent = this;
            fotos.Show();
        }

        private void tOLERANCIASEVENTUALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToleranciaEventual tole = new frmToleranciaEventual(string_ArchivoConfiguracion);
            tole.MdiParent = this;
            tole.Show();
        }



        
        
    }
}
