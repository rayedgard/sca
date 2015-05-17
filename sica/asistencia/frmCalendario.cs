using clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class frmCalendario : Form
    {
        CValidacion ValidarDatos;
        CConection ConexionBD;
        object[] VariablesDiaFeriado = { "pIdTipoDiaFeriado", "pNombreFeriado", "pHoraInicio", "pHoraFin", "pTodoElDia", "pColorFeriado", "pImagenMenu", "pDetalles" };
        object[] DatosDiaFeriado = new object[8];
        ArrayList ListaMenuDiasFeriados;
        object[] ParametrosRecuperarDiasFeriados = { "pMes", "pAnio" };
        object[] DatosRecuperarDiasFeriados = { 01, 2011 };
        string string_ArchivoConfiguracion;

        public frmCalendario(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            ListaMenuDiasFeriados = new ArrayList();

          
        
            CargarListaMenuPaCalendario();
            CargarFeriadosMesCalendario();
            calend_CalendarioDiasFeriados.MesAnioFecha = new int[] { DateTime.Now.Month, DateTime.Now.Year };
            calend_CalendarioDiasFeriados.MesAnioFecha_Changed += new ClaseCalendario.Calendario.MesCambiadoCambiadaEventHandler(ValorMesAnioFechaCambiado);

            calend_CalendarioDiasFeriados.FechaActualHoy= DateTime.Now;
            
        }

        public void ValorMesAnioFechaCambiado(int NuevoMes, int NuevoAnio, int OldMes, int OldAnio)
        {
            CargarFeriadosMesCalendario();
        }

        public void CargarFeriadosMesCalendario()
        {
            //ParametrosRecuperarDiasFeriados = {"pMes","pAnio"};
            DatosRecuperarDiasFeriados[0] = calend_CalendarioDiasFeriados.MesAnioFecha[0];
            DatosRecuperarDiasFeriados[1] = calend_CalendarioDiasFeriados.MesAnioFecha[1];

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet DiasNoLaborables = ConexionBD.EjecutarProcedimientoReturnDataSet("spuhor_DiasNoLaborablesMesAnio", ParametrosRecuperarDiasFeriados, DatosRecuperarDiasFeriados);
            // Recupera DIA | MES | ANÑO | TIPODIA NOLABORAL            
            for (int i = 0; i < DiasNoLaborables.Tables[0].Rows.Count; i++)
            {
                calend_CalendarioDiasFeriados.CambiarOpcionDia(DiasNoLaborables.Tables[0].Rows[i][3].ToString(), int.Parse(DiasNoLaborables.Tables[0].Rows[i][0].ToString()));
            }
            ConexionBD.Desconectar();
        }
        public void CargarListaMenuPaCalendario()
        {
            ListaMenuDiasFeriados = new ArrayList();
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet DiasNoLaborables = ConexionBD.EjecutarProcedimientoReturnDataSet("spudia_ListarDiasNoLaborables");
            int NroElementos = DiasNoLaborables.Tables[0].Rows.Count;
            object[] Opcion = new object[4];

            for (int i = 0; i < NroElementos; i++)
            {
                Opcion[0] = DiasNoLaborables.Tables[0].Rows[i][0];
                Opcion[1] = DiasNoLaborables.Tables[0].Rows[i][1];
                Opcion[2] = ColorTranslator.FromWin32(int.Parse(DiasNoLaborables.Tables[0].Rows[i][5].ToString()));
                Opcion[3] = ConexionBD.Bytes2Image((byte[])DiasNoLaborables.Tables[0].Rows[i][6]);

                ListaMenuDiasFeriados.Add(Opcion.Clone());
            }


            ConexionBD.Desconectar();


           

            calend_CalendarioDiasFeriados.ListaOpcionesFeriados = ListaMenuDiasFeriados;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            object[] DatosEliminarDiasNoLaborables = { "pMes", "pAnio" };
            object[] ValuesEliminarDiasNoLaborables = { "pMes", "pAnio" };
            ValuesEliminarDiasNoLaborables[0] = calend_CalendarioDiasFeriados.MesAnioFecha[0];
            ValuesEliminarDiasNoLaborables[1] = calend_CalendarioDiasFeriados.MesAnioFecha[1];


            object[] DatosGuardarDiaNoLaboral = { "pDiaMesAnio", "pIdTipoDiaNoLaboral" };
            object[] ValuesGuardarDiaNoLaboral = { "pDiaMesAnio", "pIdTipoDiaNoLaboral" };
            int pMes = calend_CalendarioDiasFeriados.MesAnioFecha[0];
            int pAnio = calend_CalendarioDiasFeriados.MesAnioFecha[1];

            string[] sa_DiasMesOpciones = calend_CalendarioDiasFeriados.DiasMesConOpciones;
            int i_NroDiasMes = calend_CalendarioDiasFeriados.i_NroDiasMes;

            bool boolHecho = false;
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_EliminarDiasNoLaborablesMesAnio", DatosEliminarDiasNoLaborables, ValuesEliminarDiasNoLaborables);
                for (int i = 0; i < i_NroDiasMes; i++)
                {
                    ValuesGuardarDiaNoLaboral[0] = string.Format("{0}-{1}-{2}", pAnio, pMes, i + 1); ;
                    ValuesGuardarDiaNoLaboral[1] = sa_DiasMesOpciones[i];
                    ConexionBD.EjecutarProcedimientoReturnVoid("spuHor_GuardarDiasNoLaboral", DatosGuardarDiaNoLaboral, ValuesGuardarDiaNoLaboral);
                }
                ConexionBD.COMMIT();
                boolHecho = true;
            }
            catch
            {
                ConexionBD.ROLLBACK();
                boolHecho = false;
            }
            finally
            {
                ConexionBD.Desconectar();
            }
            if (boolHecho)
                MessageBox.Show("DIAS NO LABORABLES GUARDADOS SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("NO SE PUDO GUARDAR LOS DIAS NO LABORABLES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
        }











    }
}
