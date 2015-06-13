using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace clases
{
    public class Correos
    {

        /*
        * Cliente SMTP
        * Gmail:  smtp.gmail.com  puerto:587
        * Hotmail: smtp.liva.com  puerto:25
        */
        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

        public Correos()
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential("rayedgard@itdecsa.com", "edgard27");
            server.EnableSsl = true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }

    }
}
