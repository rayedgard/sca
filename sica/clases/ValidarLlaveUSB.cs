using Lobosoft.Utilities.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases
{
    public class ValidarLlaveUSB
    {

        USBDrives LectorSerieUSB;
        /// <summary>
        /// metodo para validar la llave USB 
        /// </summary>
        /// <returns></returns>
        public bool AccesoPermitidoAlSistema()
        {
            /* Este debería ser el valor adecuado del número de serie de nuestro dispositivo USB. 
            * Podríamos obtenerlo usando el método GetSerialNumber("letra_de_unidad") de la clase USBDrives, 
            * en el ensamblado USBSN. 
             */
            string LlaveUSBConAcceso = "001CC0EC3466FD21071ED96D";
            USBDrives LectorSerieUSB = new USBDrives();
            bool detected = false;
            string[] drives = Environment.GetLogicalDrives();
            string KeysUSB = "";
            // Obtiene los nombres de los dispositivos, eliminando la \ de directorio
            foreach (string strDrive in drives)
            {
                KeysUSB = LectorSerieUSB.GetSerialNumber(strDrive.Replace("\\", ""));
                if (String.Equals(LlaveUSBConAcceso, KeysUSB))
                {
                    detected = true;
                    break;
                }
            }
            return detected;
        }




    }
}
