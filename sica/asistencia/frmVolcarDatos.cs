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
    public partial class frmVolcarDatos : Form
    {
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        public bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private string IPMachineNumber = "192.168.1.201";
        //Make sure you have enrolled the fingerprint templates you will save.
        private int iCanSaveTmp = 0;
        private int PortNumber;
        private CConection ConexionBD;
        string string_ArchivoConfiguracion;

        public frmVolcarDatos(int pIdMachine, string pIPMachine, int pPortNumber, string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            iMachineNumber = pIdMachine;
            IPMachineNumber = pIPMachine;
            PortNumber = pPortNumber;
            ConectarseAlReloj();
            VerNroRegistros();
            ConexionBD = new CConection();
        }

        public void VerNroRegistros()
        {
            int idwErrorCode = 0;
            int iValue = 0;
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            {
                lbNroReloj.Text = "Hay " + iValue.ToString() + " registros en el reloj";
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
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
                MessageBox.Show("No se puede conectar al dispositivo \r\nErrorCode=" + idwErrorCode.ToString() + " \r\nRevise su Conexion e Intente nuevamente ", "Error");
                this.Dispose();
                this.Close();
            }
            Cursor = Cursors.Default;
        }

        private void DesconectarseReloj()
        {
            Cursor = Cursors.WaitCursor;
            if (bIsConnected == true)
            {
                axCZKEM1.StartIdentify();
                axCZKEM1.Disconnect();
                bIsConnected = false;
                return;
            }
            Cursor = Cursors.Default;
        }

        public void VolcarDatosReloj()
        {
            ConectarseAlReloj();

            if (bIsConnected)
            {
                int idwErrorCode = 0;

                string idwEnrollNumber = "";
                int idwVerifyMode = 0;
                int idwInOutMode = 0;

                int idwYear = 0;
                int idwMonth = 0;
                int idwDay = 0;
                int idwHour = 0;
                int idwMinute = 0;
                int idwSecond = 0;
                int idwWorkCode = 0;
                int idwReserved = 0;

                int iGLCount = 0;
                int iIndex = 0;

                Cursor = Cursors.WaitCursor;
                DataSet dsVolcarDatosReloj = new DataSet();
                dsVolcarDatosReloj.Tables.Add("REGISTRO");
                dsVolcarDatosReloj.Tables[0].Columns.Add("DNI");
                dsVolcarDatosReloj.Tables[0].Columns.Add("FECHA");
                dsVolcarDatosReloj.Tables[0].Columns.Add("HORA");
                dsVolcarDatosReloj.Tables[0].Columns.Add("MODO");

                axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                {
                    while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out idwEnrollNumber, out idwVerifyMode, out idwInOutMode,
                             out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkCode))//, ref idwReserved))//get records from the memory
                    {
                        object[] DATA = { idwEnrollNumber.ToString(),
                        string.Format("{0}-{1}-{2}",idwYear,idwMonth,idwDay),
                        string.Format("{0}:{1}:{2}",idwHour,idwMinute,idwSecond),
                        string.Format("{0}",idwVerifyMode),
                    };
                        int ddnnii = 0;
                        int.TryParse(DATA[0].ToString().Trim(), out ddnnii);
                        if(ddnnii>0)
                            dsVolcarDatosReloj.Tables[0].Rows.Add(DATA);
                        iIndex++;
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    axCZKEM1.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {
                        MessageBox.Show("No se pudieron leer los datos del Reloj,ErrorCode: " + idwErrorCode.ToString(), "Error");
                    }
                    else
                    {
                        MessageBox.Show("No hay mas datos!", "Error");
                    }
                }
                axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
                AgregarDatosAsistencia(dsVolcarDatosReloj);

                Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("El Reloj esta desconectado\r\nNo Se importo el registro del reloj");
                Cursor = Cursors.Default;
            }
        }


        private void AgregarDatosAsistencia(DataSet dsVolcarDatosReloj)
        {
            if (dsVolcarDatosReloj.Tables[0].Rows.Count > 0)
            {
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                bool SeRegistro = false;
                string Mensaje = "";
                object[] VariablesNames = { "pDNI", "pFechaMarcacion", "pHoraMarcacion","pModo" };
                object[] VariablesValues = { "pDNI", "pFechaMarcacion", "pHoraMarcacion","pModo" };

                int NroElementos = dsVolcarDatosReloj.Tables[0].Rows.Count;
                bool SeHizoRollBack = false;

                try
                {
                    for (int i = 0; i < NroElementos; i++)
                    {
                        VariablesValues = dsVolcarDatosReloj.Tables[0].Rows[i].ItemArray;
                        Mensaje = ConexionBD.EjecutarProcedimientoReturnMensaje("spuReg_RegistrarAsistencia", VariablesNames, VariablesValues);
                    }
                    ConexionBD.COMMIT();
                    SeRegistro = true;
                }
                catch (Exception ex)
                {
                    ConexionBD.ROLLBACK();
                    MessageBox.Show("Operacion Cancelada "+ex.Message);
                    SeRegistro = false;
                    SeHizoRollBack = true;
                }
                finally
                {
                    ConexionBD.Desconectar();
                }
                if(SeRegistro)
                    MessageBox.Show("Datos Importados Correctamente");
                

            }
            else
                MessageBox.Show("No hubo ningun registro para agregar");
        }



        private void btnVolcarDatos_Click(object sender, EventArgs e)
        {
            VolcarDatosReloj();
        }

        /// <summary>
        /// EVENTO CLICK PARA ELIMINAR DATOS DEL RELOJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTA SEGURO QUE QUIERE BORRAR LOS DATOS DEL RELOJ", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BorrarDatosDelReloj();
            }
        }
        /// <summary>
        /// METODO PARA BRRAR DATOS DEL RELOJ
        /// </summary>
        private void BorrarDatosDelReloj()
        {
            ConectarseAlReloj();
            if (bIsConnected == false)
            {
                MessageBox.Show("El reloj debe estar conectado", "Error");
                return;
            }
            int idwErrorCode = 0;

            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.ClearGLog(iMachineNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Todos los registros fueron borrados del Reloj!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("No se completo la operacion de borrado\r\n,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            VerNroRegistros();
        }   
    }
}