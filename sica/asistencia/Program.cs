using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ValidarLlaveUSB validaLLave = new ValidarLlaveUSB(); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PARA EL SPLAS SCRIM
            Splash sp = new Splash();
            
            if (sp.ShowDialog() == DialogResult.OK)
            {
                if (validaLLave.AccesoPermitidoAlSistema())
                {
                    //PARA EL FORMULARIO DE LOGUEO
                    loguin login = new loguin();
                    login.ShowDialog();
                    if (login.Login == 1)
                        Application.Run(new Principal());
                }
                else
                {
                    frmValidaUSB valida = new frmValidaUSB();
                    valida.ShowDialog();
                }
               



            }
        }
    }
}
