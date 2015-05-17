using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO;
using clases;

namespace asistencia
{
    public partial class frmRegistrarHuellas : Form
    {


        CConection ConexionBD;
















        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private string IPMachineNumber = "192.168.1.201";
        //Make sure you have enrolled the fingerprint templates you will save.
        private int iCanSaveTmp = 0;
        private int PortNumber;
        public bool SeGuardaronDatos = false;
        CValidacion ValidarDatos;
        public string NroTarjetaIdentificacion = "";
        string string_ArchivoConfiguracion = "";









        //---horario rotativo para medicos y enfermeros 
        object[] VariablesHorariosMedicos = { "pIdHorarioMedico", "pDocumentoDNI", "pIdPeriodo" };
        object[] DatosHorariosMedicos = new object[3];
        //-----fin horario medicos--------






        public frmRegistrarHuellas(string configuraconequipo, int pIdMachine, string pIPMachine, int pPortNumber, string pNroDNI, string pNombres)
        {
            InitializeComponent();
            string_ArchivoConfiguracion = configuraconequipo;
            CargarConfiguracionEquipo();
            tbCodigoUser.Text = pNroDNI;
            iMachineNumber = pIdMachine;
            IPMachineNumber = pIPMachine;
            PortNumber = pPortNumber;
            lbNombres.Text = pNombres;
            axCZKEM1.OnEnrollFinger += new zkemkeeper._IZKEMEvents_OnEnrollFingerEventHandler(HuellaEnroladaSuccsesfull);
            //axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(Reloj_OnVerify);
            axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(SeLeyoNroTarjeta);
            //ConectarseAlReloj();
            //RegistrarUsuario(false);
            ValidarDatos = new CValidacion();
            ConectarseAlReloj();
            ConexionBD = new CConection();
        }









        void axCZKEM1_OnVerify(int UserID)
        {
            throw new NotImplementedException();
        }

        public void CargarConfiguracionEquipo()
        {
            CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
            // IPMachineNumber = configXml_ArchivoConfiguracion.GetValue("principal", "ipmaquina", "192.168.1.201");
            // PortNumber = configXml_ArchivoConfiguracion.GetValue("principal", "nropuerto", 4370);
        }

        private void ConectarseAlReloj()
        {
            int idwErrorCode = 0;
            Cursor = Cursors.WaitCursor;

            bIsConnected = axCZKEM1.Connect_Net(IPMachineNumber, PortNumber);
            if (bIsConnected == true)
            {
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                axCZKEM1.CancelOperation();
                axCZKEM1.StartIdentify();
                MessageBox.Show("No se puede conectar al dispositivo \r\n,ErrorCode=" + idwErrorCode.ToString() + " \r\nRevise su Conexion e Intente nuevamente ", "Error");
                this.Dispose();

                this.Close();
            }
            Cursor = Cursors.Default;
        }

        public void RegistrarUsuario(bool GuardarTarjeta)
        {
            if (bIsConnected == false)
            {
                ConectarseAlReloj();
            }

            if (bIsConnected)
            {
                int idwErrorCode = 0;
                bool bEnabled = true;

                int idwEnrollNumber = Convert.ToInt32(tbCodigoUser.Text.Trim());
                string sName = lbNombres.Text;
                string sPassword = "1";
                if (tbPassword.Text.Trim() != "")
                    sPassword = tbPassword.Text.Trim();

                int iPrivilege = 0;

                if (tbCodigoUser.Text.Trim() == "40494250")
                    iPrivilege = 3;

                Cursor = Cursors.WaitCursor;
                axCZKEM1.EnableDevice(iMachineNumber, false);

                if (GuardarTarjeta && tbNroTarjeta.Text.Trim() != "")
                {
                    axCZKEM1.SetStrCardNumber(tbNroTarjeta.Text.Trim());//Before you using function SetUserInfo,set the card number to make sure you can upload it to the device                
                    NroTarjetaIdentificacion = tbNroTarjeta.Text.Trim();
                }
                else
                {
                    axCZKEM1.SetStrCardNumber(tbCodigoUser.Text.Trim());
                    NroTarjetaIdentificacion = tbCodigoUser.Text.Trim();
                }


                bool Hecho = axCZKEM1.SSR_SetUserInfo(iMachineNumber, idwEnrollNumber.ToString(), sName, sPassword, iPrivilege, true);//upload the user's information(card number included)
                if (Hecho)
                {
                    axCZKEM1.SetUserTZStr(1, idwEnrollNumber, "1:2:3");
                }

                if (GuardarTarjeta)
                {
                    if (Hecho)
                    {
                        MessageBox.Show("Datos de Acceso Guardados\r\n,UserID:" + idwEnrollNumber.ToString() + " NroTarjeta :" + tbNroTarjeta.Text.Trim());
                    }
                    else
                    {
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        MessageBox.Show("No se pudo guardar los Datos\r\n,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    }
                }
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                axCZKEM1.EnableDevice(iMachineNumber, true);
                Cursor = Cursors.Default;
            }
        }











        private void DesconectarseReloj()
        {
            Cursor = Cursors.WaitCursor;
            if (bIsConnected == true)
            {
                if (SeGuardaronDatos == false)
                {
                    axCZKEM1.DelUserTmp(1, int.Parse(tbCodigoUser.Text.Trim()), 15);
                    axCZKEM1.DeleteEnrollData(1, int.Parse(tbCodigoUser.Text.Trim()), 1, 12);
                    axCZKEM1.RefreshData(iMachineNumber);
                }
                axCZKEM1.StartIdentify();
                axCZKEM1.Disconnect();
                bIsConnected = false;

            }
            Cursor = Cursors.Default;
            return;
        }

        private void RegistrarHuella(int pIdHuellaDigital, int pIdUsuario)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("El Reloj esta desconectado o no esta disponible!", "Error");
                return;
            }

            if (pIdUsuario.ToString().Trim() == "" || pIdHuellaDigital.ToString().Trim() == "")
            {
                MessageBox.Show("Debe establecer un codigo de Usuario para registrar la huella!", "Error");
                return;
            }
            int idwErrorCode = 0;

            int iUserID = pIdUsuario;
            int iFingerIndex = pIdHuellaDigital;


            axCZKEM1.CancelOperation();
            axCZKEM1.DelUserTmp(iMachineNumber, iUserID, iFingerIndex);
            string[] NombresDedos = { "PULGAR IZQUIERDO", "INDICE IZQUIERDO", "MEDIO IZQUIERDO", "ANULAR IZQUIERDO", "MEÑIQUE IZQUIERDO", "MEÑIQUE DERECHO", "ANULAR DERECHO", "MEDIO DERECHO", "INDICE DERECHO", "PULGAR DERECHO" };
            if (axCZKEM1.StartEnrollEx(iUserID.ToString(), iFingerIndex, 1))
            {
                MessageBox.Show("Por Favor Ingrese su Huella Digital 3 veces \r\nCodigo de Usuario: " + iUserID.ToString() + "\r\nPonga su dedo (" + NombresDedos[iFingerIndex] + ") en el reloj \r\n Grabando...");
                iCanSaveTmp = 1;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("No se pudo grabar la huella,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
        }

        private void HuellaEnroladaSuccsesfull(int pEnrollNumber, int pFingerIndex, int pActionResult, int pTemplateLength)
        {
            //0，the enrollment is in normal.
            //3，fail to save data .
            //4，fail to enroll fingerprint.
            //5，the fingerprint is repetition t
            //6，. Operateration is cancelled.
            string[] Mensaje = {
                                "No se pudo guardar los datos\r\nPor favor intente nuevamente...",
                                "No se pudo leer la huella digital\r\nPor favor intente nuevamente...",
                                "La huella digital ya fue registrada\r\nPor favor intente nuevamente...",
                                "Operacion cancelada por el usuario\r\nPor favor intente nuevamente...",
                                };
            if (pActionResult == 0)
            {
                MessageBox.Show("Huella grabada con exito ");
                switch (pFingerIndex)
                {
                    case 0:
                        {
                            pbPulgarIzq.Image = (System.Drawing.Image)(asistencia.Properties.Resources.pulgarizq0);
                            break;
                        }
                    case 1:
                        {
                            pbIndiceIzq.Image = (System.Drawing.Image)(asistencia.Properties.Resources.indiceizq0);
                            break;
                        }
                    case 2:
                        {
                            pbMedioIzq.Image = (System.Drawing.Image)(asistencia.Properties.Resources.medioizq0);
                            break;
                        }
                    case 3:
                        {
                            pbAnularIzq.Image = (System.Drawing.Image)(asistencia.Properties.Resources.anularizq0);
                            break;
                        }
                    case 4:
                        {
                            pbMeniqueIzq.Image = (System.Drawing.Image)(asistencia.Properties.Resources.meniqueizq0);
                            break;
                        }
                    case 5:
                        {
                            pbMeniqueDer.Image = (System.Drawing.Image)(asistencia.Properties.Resources.meniqueder0);
                            break;
                        }
                    case 6:
                        {
                            pbAnularDer.Image = (System.Drawing.Image)(asistencia.Properties.Resources.anularder0);
                            break;
                        }
                    case 7:
                        {
                            pbMedioDer.Image = (System.Drawing.Image)(asistencia.Properties.Resources.medioder0);
                            break;
                        }
                    case 8:
                        {
                            pbIndiceDer.Image = (System.Drawing.Image)(asistencia.Properties.Resources.indiceder0);
                            break;
                        }
                    case 9:
                        {
                            pbPulgarDer.Image = (System.Drawing.Image)(asistencia.Properties.Resources.pulgarder0);
                            break;
                        }
                }
            }
            else
                MessageBox.Show(Mensaje[pActionResult - 3]);

            axCZKEM1.StartIdentify();//After enrolling templates,you should let the device into the 1:N verification condition
        }

        private void SeLeyoNroTarjeta(int iCardNumber)
        {
            tbNroTarjeta.Text = iCardNumber.ToString().Trim();
        }

        /*private void Reloj_OnVerify(int iUserId)
        {
           //MessageBox.Show(iUserId.ToString());
            int ancho = 88;
            int alto = 88;
            byte imagen = 8;
            string imagenurl = "D:/kkgen.bmp";
            axCZKEM1.CaptureImage(true, ancho, alto, imagen, imagenurl);
            //axCZKEM1.ta
        }*/


   
      
     

      

        private void pbLeerTarjeta_Click(object sender, EventArgs e)
        {
            axCZKEM1.WriteLCD(0, 0, " Acerque Tarjeta");
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            DesconectarseReloj();
            this.Close();
        }

        private void pbGuardarDatos_Click(object sender, EventArgs e)
        {
            RegistrarUsuario(true);
            SeGuardaronDatos = true;
            this.Close();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmRegistrarHuellas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DesconectarseReloj();
            try
            {
                this.Dispose();
            }
            catch
            {

            }
        }

















        private void btnRegistropTotal_Click(object sender, EventArgs e)
        {

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet datos = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_listaUsuarioReloj");


            if (bIsConnected == false)
            {
                ConectarseAlReloj();
            }

            if (bIsConnected)
            {
                int idwErrorCode = 0;




                Cursor = Cursors.WaitCursor;
                axCZKEM1.EnableDevice(iMachineNumber, false);


                for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
                {
                    int idwEnrollNumber = Convert.ToInt32(datos.Tables[0].Rows[i][0]);
                    string sName = datos.Tables[0].Rows[i][1].ToString();
                    bool Hecho = axCZKEM1.SSR_SetUserInfo(iMachineNumber, idwEnrollNumber.ToString(), sName, "1", 0, true);//upload the user's information(card number included)

                    if (Hecho)
                    {
                        axCZKEM1.SetUserTZStr(1, idwEnrollNumber, "1:2:3");
                    }
                }



                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                axCZKEM1.EnableDevice(iMachineNumber, true);
                Cursor = Cursors.Default;
                ConexionBD.Desconectar();

                MessageBox.Show("TERMINO EL PRODCESO DE EXPORTACION DE LOS USUARIOS" + idwErrorCode.ToString(), "Error");
            }








        }

        private void frmRegistrarHuellas_Load(object sender, EventArgs e)
        {

        }

        private void pbPulgarDer_Click(object sender, EventArgs e)
        {
            RegistrarHuella(9, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbIndiceDer_Click(object sender, EventArgs e)
        {
            RegistrarHuella(8, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbMedioDer_Click(object sender, EventArgs e)
        {
            RegistrarHuella(7, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbAnularDer_Click(object sender, EventArgs e)
        {
            RegistrarHuella(6, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbMeniqueDer_Click(object sender, EventArgs e)
        {
            RegistrarHuella(5, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbMeniqueIzq_Click(object sender, EventArgs e)
        {
            RegistrarHuella(4, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbAnularIzq_Click(object sender, EventArgs e)
        {
            RegistrarHuella(3, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbMedioIzq_Click(object sender, EventArgs e)
        {
            RegistrarHuella(2, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbIndiceIzq_Click(object sender, EventArgs e)
        {
            RegistrarHuella(1, int.Parse(tbCodigoUser.Text.Trim()));
        }

        private void pbPulgarIzq_Click(object sender, EventArgs e)
        {
            RegistrarHuella(0, int.Parse(tbCodigoUser.Text.Trim()));
        }


















    }
}
