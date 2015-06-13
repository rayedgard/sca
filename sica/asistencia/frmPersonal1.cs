using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using zkemkeeper;
using clases;

namespace asistencia
{
    public partial class frmPersonal1 : Form
    {
        CValidacion ValidarDatos;
        CConection ConexionBD;
        //bool HuellaCargada = false;
        bool SeGuardaronDatosHuella = false;
        string CodigoTarjetaIden = "";
        object[] VariablesPersonal = { "pDocumentoDNI", "pCodigoTarjeta", "pNombres", "pPaterno", "pMaterno", "pSexo", "pFoto", "pFechaNacimiento", "pEmail", "pDireccion", "pIdProvincia", "pIdDistrito", "pTelefono", "pCelular", "pOcupacion", "pUsuario", "pContrasenia" };


        //-----fin vacaciones--------
        object[] VariablesEliminarPersonal = { "pDocumentoDNI", "pIdCodPersonalEmpresa" };
        object[] DatosPersonal = new object[17];


        //-----horario rotativo para medicos y enfermeros 
        object[] VariablesHorariosMedicos = { "pIdHorarioMedico", "pDocumentoDNI", "pIdPeriodo" };
        object[] DatosHorariosMedicos = new object[3];
        //-----fin horario medicos--------


        //-----horario rotativo para medicos y enfermeros 
        object[] VariablesDia = { "pIdDia", "pDocumentoDNI" };
        object[] DatosDia = new object[2];
        //-----fin horario medicos--------


        //-----para vacaciones--------
        object[] VariablesVacaciones = { "pDocumentoDNI", "pNumeroVacaciones", "pPeriodo" };
        object[] DatosVacaciones = new object[3];

        object[] VariablesContrato = { "pDocumentoDNI", "pIdCodPersonalEmpresa", "pIdAgencia", "pIdArea", "pIdCargo", "pIdTipoHorario", "pFechaInicio", "pFechaFin", "pSueldo", "pEmailEmpresa", "pCelularEmpresa", "pTelefonoEmpresa", "pEnableSINO", "pIdModalidad" };
        object[] DatosContrato = new object[13];

        string string_ArchivoConfiguracion;

        
        int int_IdMachine = 1;
        string st_IPMachine = "192.168.1.201";
        int int_PortNumber = 4370;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private string IPMachineNumber = "192.168.1.201";
        //Make sure you have enrolled the fingerprint templates you will save.
        private int iCanSaveTmp = 0;
        private int PortNumber = 4370;
        private int idHorario;
   
        public frmPersonal1(string p_IPReloj, int p_PuertoReloj, string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            IPMachineNumber = p_IPReloj;
            st_IPMachine = p_IPReloj;
            PortNumber = p_PuertoReloj;

            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            CargarDatos();
            lbHabilitado.Text = "";
        }

        public void CargarDatos()
        {
            //Cargar Provincias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbProvincia, true, "spuGeo_ListarProvincias");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbAgencia, true, "spuGeo_ListarAgencias");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbAreasTrabajo, true, "spuGeo_ListarAreas");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbCargos, true, "spuGeo_ListarCargos");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbModalidadContrato, true, "spuGeo_ListarModalidades");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbHorarios, true, "spuGeo_ListarHorarios");
            //Cosas por defecto
            cbProvincia.Refresh();
            cbAgencia.Refresh();
            cbAreasTrabajo.Refresh();
            cbModalidadContrato.Refresh();
            cbCargos.Refresh();
            cbHorarios.Refresh();
            ConexionBD.Desconectar();
            //Cargar Distritos
            if (cbProvincia.SelectedValue != null)
                CargarDistritos(cbProvincia.SelectedValue.ToString());
        }

        public void CargarDistritos(string pIdProvincia)
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbDistrito, true, "spuGeo_ListarDistritos", "pIdProvincia", pIdProvincia);
            cbDistrito.Refresh();
            ConexionBD.Desconectar();
        }


        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ////obtener datos de la base de datos para vacaciones
                //DatosVacaciones = ConexionBD.RecuperaDatoVacaciones("spuRep_numeroVacaciones", "pDNI", pDNI);
                //fin datos vacaciones
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    tbNombres.Text = DatosPersonal[2].ToString();
                    tbPaterno.Text = DatosPersonal[3].ToString();
                    tbMaterno.Text = DatosPersonal[4].ToString();
                    rbMasculino.Checked = true;
                    if (DatosPersonal[5].ToString().Trim() == "F")
                        rbFemenino.Checked = true;
                    try
                    {
                        pbFoto.Image = ConexionBD.Bytes2Image((byte[])DatosPersonal[6]);
                    }
                    catch
                    {
                        pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.siluetaPersona);
                    }
                    dtFechaNacimiento.Value = new DateTime(int.Parse(DatosPersonal[9].ToString()), int.Parse(DatosPersonal[8].ToString()), int.Parse(DatosPersonal[7].ToString()));
                    tbEmail.Text = DatosPersonal[10].ToString();
                    tbDireccion.Text = DatosPersonal[11].ToString();
                    cbProvincia.SelectedValue = DatosPersonal[12].ToString();
                    cbDistrito.SelectedValue = DatosPersonal[13].ToString();
                    tbTelefono.Text = DatosPersonal[14].ToString();
                    tbCelular.Text = DatosPersonal[15].ToString();
                    tbProfesion.Text = DatosPersonal[16].ToString();

                    //para cargar los datos devacaciones
                    //tbVacaciones.Text = DatosVacaciones[0].ToString();

                    //evio de datos para ESTADO del personal 

                    clases.Cfunciones.Globales.dni = pDNI;
                    clases.Cfunciones.Globales.NombresYapellidos = DatosPersonal[2].ToString() + " " + DatosPersonal[3].ToString() + " " + DatosPersonal[4].ToString();

                }

            }
        }


        public void BuscarContratoPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DatosContrato = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarContratoPersonal", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosContrato.Length > 1)
                {
                    tbCodigoEmpresa.Text = DatosContrato[1].ToString();
                    cbAgencia.SelectedValue = DatosContrato[2].ToString();
                    cbAreasTrabajo.SelectedValue = DatosContrato[3].ToString();
                    cbCargos.SelectedValue = DatosContrato[4].ToString();
                    cbHorarios.SelectedValue = DatosContrato[5].ToString();
                    dtFechaInicio.Value = new DateTime(int.Parse(DatosContrato[8].ToString()), int.Parse(DatosContrato[7].ToString()), int.Parse(DatosContrato[6].ToString()));
                    dtFechaFin.Value = new DateTime(int.Parse(DatosContrato[11].ToString()), int.Parse(DatosContrato[10].ToString()), int.Parse(DatosContrato[9].ToString()));
                    tbRemuneracion.Text = DatosContrato[12].ToString();
                    tbEmailEmpresa.Text = DatosContrato[13].ToString();
                    tbCelularEmpresa.Text = DatosContrato[14].ToString();
                    tbTelefonoEmpresa.Text = DatosContrato[15].ToString();
                    if (Convert.ToInt32(DatosContrato[16]) == 0)
                    {
                        lbHabilitado.Text = "Personal HABILITADO con registro biométrico";
                        lbHabilitado.BackColor = Color.LightBlue;
                    }
                    if (Convert.ToInt32(DatosContrato[16]) == 1)
                    { 
                        lbHabilitado.Text="Personal HABILITADO con registro manual";
                        lbHabilitado.BackColor = Color.LightBlue;
                    }
                    if (Convert.ToInt32(DatosContrato[16]) == 2)
                    { 
                        lbHabilitado.Text="Personal DESHABILITADO no labora";
                        lbHabilitado.BackColor = Color.Red;
                    }
                    //envio de datos para ESTADO
                    clases.Cfunciones.Globales.estado = Convert.ToInt32(DatosContrato[16]);
                    //------------------
                    cbModalidadContrato.SelectedValue = DatosContrato[17].ToString();
                    SeGuardaronDatosHuella = true;
                }

            }
        }


        public void LimpiarDatos()
        {
            DatosPersonal = new object[17];
            DatosContrato = new object[13];
            CodigoTarjetaIden = "";
            tbDNI.Text = "";
            tbDNI.ReadOnly = false;
            tbNombres.ReadOnly = false;
            tbPaterno.ReadOnly = false;
            tbNombres.Text = "";
            tbPaterno.Text = "";
            tbMaterno.Text = "";
            tbTelefono.Text = "";
            tbCelular.Text = "";
            tbEmail.Text = "";
            tbProfesion.Text = "";
            tbDireccion.Text = "";
            pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.siluetaPersona);
            tbCodigoEmpresa.Text = "";
            tbCelularEmpresa.Text = "";
            tbTelefonoEmpresa.Text = "";
            tbEmailEmpresa.Text = "";
            tbRemuneracion.Text = "";
            //tbVacaciones.Text = "0";//para vacaciones
            SeGuardaronDatosHuella = false;
            lbHabilitado.Text = "";
        }

        public void GuardarDatos()
        {
            epValida.Clear();
            if (tbDNI.Text == "")
            {
                epValida.SetError(tbDNI, "EL VALOR DEL DNI NO DEBE ESTAR VACIO");
                return;
            }
            if (tbNombres.Text == "")
            {
                epValida.SetError(tbNombres, "EL VALOR DE NOMBRES NO DEBE ESTAR VACIO");
                return;
            }
            if (tbPaterno.Text == "")
            {
                epValida.SetError(tbPaterno, "EL VALOR DEL APELLIDO PATERNO NO DEBE ESTAR VACIO");
                return;
            }
            if (tbMaterno.Text == "")
            {
                epValida.SetError(tbMaterno, "EL VALOR DEL APELLIDO MATERNO NO DEBE ESTAR VACIO");
                return;
            }
            if (tipo == Tipo.guardar || tipo == Tipo.habilitar)
            {
                GuardarLosDatos();
            }

        }


        private void GuardarLosDatos()
        {
            // Cargar los datos VariablesPersonal = {"DocumentoDNI","CodHuellaDigital","Nombres","Paterno","Materno",
            //                                       "Sexo","Foto","FechaNacimiento","Email","Direccion","IdProvincia",
            //                                       "IdDistrito","Telefono","Celular","Ocupacion","Usuario","Contrasenia"};
            DatosPersonal = new object[17];
            DatosPersonal[0] = tbDNI.Text.Trim();
            DatosPersonal[1] = CodigoTarjetaIden;
            DatosPersonal[2] = tbNombres.Text;
            DatosPersonal[3] = tbPaterno.Text;
            DatosPersonal[4] = tbMaterno.Text;
            DatosPersonal[5] = "M";
            if (rbFemenino.Checked)
                DatosPersonal[5] = "F";
            DatosPersonal[6] = ConexionBD.Image2Bytes(pbFoto.Image);
            DatosPersonal[7] = ConexionBD.FechaFormatoMySQL(dtFechaNacimiento.Value, 0);
            DatosPersonal[8] = tbEmail.Text;
            DatosPersonal[9] = tbDireccion.Text;
            DatosPersonal[10] = cbProvincia.SelectedValue;
            DatosPersonal[11] = cbDistrito.SelectedValue;
            DatosPersonal[12] = tbTelefono.Text;
            DatosPersonal[13] = tbCelular.Text;
            DatosPersonal[14] = tbProfesion.Text;
            DatosPersonal[15] = tbDNI.Text.Trim();
            DatosPersonal[16] = "1";


            //----------------------------


            // Cargar los datos de contrato
            // VariablesContrato ={"DocumentoDNI","IdCodPersonalEmpresa","IdAgencia","IdArea","IdCargo","IdTipoHorario",
            // "FechaInicio","FechaFin","Sueldo","EmailEmpresa","celularEmpresa","TelefonoEmpresa","EnableSINO" };
            DatosContrato = new object[14];
            DatosContrato[0] = tbDNI.Text.Trim();
            DatosContrato[1] = tbCodigoEmpresa.Text;
            DatosContrato[2] = cbAgencia.SelectedValue;
            DatosContrato[3] = cbAreasTrabajo.SelectedValue;
            DatosContrato[4] = cbCargos.SelectedValue;
            DatosContrato[5] = cbHorarios.SelectedValue;
            DatosContrato[6] = ConexionBD.FechaFormatoMySQL(dtFechaInicio.Value, 0);
            DatosContrato[7] = ConexionBD.FechaFormatoMySQL(dtFechaFin.Value, 0);
            DatosContrato[8] = tbRemuneracion.Text;
            if (DatosContrato[8].ToString().Trim() == "")
                DatosContrato[8] = 0;
            DatosContrato[9] = tbEmailEmpresa.Text;
            DatosContrato[10] = tbCelularEmpresa.Text;
            DatosContrato[11] = tbTelefonoEmpresa.Text;
            DatosContrato[12] = 0;//0 habilitado registro digital, 1 = habilitado registromanual, 2 = deshabilitado no labora 
            DatosContrato[13] = cbModalidadContrato.SelectedValue;


            // Cargar los datos de contrato
            // VariablesContrato ={"DocumentoDNI","IdCodPersonalEmpresa","IdAgencia","IdArea","IdCargo","IdTipoHorario",
            // "FechaInicio","FechaFin","Sueldo","EmailEmpresa","celularEmpresa","TelefonoEmpresa","EnableSINO" };
            DatosHorariosMedicos = new object[3];
            DatosHorariosMedicos[0] = "";
            DatosHorariosMedicos[1] = tbDNI.Text.Trim();
            DatosHorariosMedicos[2] = cbHorarios.SelectedValue;

            // para almacenar los registros preliminares del horario personal de cada dia de horario rotativo
            DatosDia = new object[2];
            DatosDia[0] = "";
            DatosDia[1] = tbDNI.Text.Trim();


            DatosVacaciones[0] = tbDNI.Text;
            DatosVacaciones[1] = 0;
            DatosVacaciones[2] = "";



            // Guardar los datos
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool TransaccionCompletada = false;
            string Mensaje = "";
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_GuardarDatosPersonal", VariablesPersonal, DatosPersonal);
                //para vacaciones
                ConexionBD.EjecutarProcedimientoReturnVoid("spuRep_GuardarVacaciones", VariablesVacaciones, DatosVacaciones);
                //-------------fin para cvacaciones-----------
                ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_GuardarContratoPersonal", VariablesContrato, DatosContrato);

                //-----------------codigo para guardar los valores en la table de horarios rotativos------//
                DataTable DatosCargo = (DataTable)cbCargos.DataSource;
                idHorario = Convert.ToInt32(DatosCargo.Rows[cbCargos.SelectedIndex]["HORARIO"]);
                if (idHorario >= 300)
                {
                    ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_GuardarHorarioPersonalMedico", VariablesHorariosMedicos, DatosHorariosMedicos);



                }
                else
                {
                    ConexionBD.EjecutarProcedimientoReturnVoid("nuevo_eliminaConfiguracionMedica", "pDocumentoDNI", tbDNI.Text.Trim());

                }
                //---------- fin codigo para horarios rotativos---------------//




                ConexionBD.COMMIT();
                TransaccionCompletada = true;
            }
            catch (Exception ex)
            {
                ConexionBD.ROLLBACK();
                TransaccionCompletada = false;
                Mensaje = ex.Message;
            }
            finally
            {
                ConexionBD.Desconectar();
            }


            if (TransaccionCompletada)
            {
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos();
            }
            else
                MessageBox.Show("NO SE PUDO GUARDAR LOS DATOS, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            }
            Cursor = Cursors.Default;
        }

        private void EliminarPersonal()
        {
            //ConectarseAlReloj();
            //if(!ValidarDatos.EsTextoVacioOMenorLongitud(tbDNI, 4) && bIsConnected)
            //{
            if (MessageBox.Show("¿Esta seguro que quiere eliminar al personal? \r\nSe boraran los datos de aistencia, permisos y otros", "CUIDADO!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //VariablesEliminarPersonal = { "DocumentoDNI", "IdCodPersonalEmpresa" };
                DatosPersonal = new object[2];
                DatosPersonal[0] = tbDNI.Text.Trim();
                DatosPersonal[1] = tbCodigoEmpresa.Text;

                //Guardar los datos
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                bool TransaccionCompletada = false;
                string Mensaje = "";
                try
                {
                    ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_EliminarPersonal", VariablesEliminarPersonal, DatosPersonal);
                    TransaccionCompletada = true;
                    //ConexionBD.COMMIT();
                    //EliminarDatosReloj(tbDNI.Text.Trim());
                }
                catch (Exception ex)
                {
                    //ConexionBD.ROLLBACK();
                    //TransaccionCompletada = false;
                    //Mensaje = ex.Message;
                }
                //finally
                //{
                //    ConexionBD.Desconectar();
                //}


                if (TransaccionCompletada)
                {
                    MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                    MessageBox.Show("NO SE PUDO ELIMINAR EL PERSONAL, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            // }
            //else
            //    MessageBox.Show("EL CAMPO DNI ES OBLIGATORIO ADEMAS DEBE CONECTARSE AL RELOJ, INGRESE DNI CORRECTO", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public void EliminarDatosReloj(string pDNI)
        {
            /* public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
             private bool bIsConnected = false;//the boolean value identifies whether the device is connected
             private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
             private string IPMachineNumber = "192.168.1.201";
             //Make sure you have enrolled the fingerprint templates you will save.
             private int iCanSaveTmp = 0;
             private int PortNumber = 4370;*/


            axCZKEM1.EnableDevice(iMachineNumber, false);
            axCZKEM1.DelUserTmp(1, int.Parse(tbDNI.Text.Trim()), 15);
            axCZKEM1.SSR_DelUserTmpExt(iMachineNumber, tbDNI.Text.Trim(), 15);
            axCZKEM1.DeleteEnrollData(1, int.Parse(tbDNI.Text.Trim()), 1, 12); //1,12
            axCZKEM1.SSR_DeleteEnrollData(1, tbDNI.Text.Trim(), 12);
            axCZKEM1.RefreshData(iMachineNumber);
            axCZKEM1.EnableDevice(iMachineNumber, true);
            axCZKEM1.StartIdentify();
            DesconectarseReloj();
        }

        private void DesconectarseReloj()
        {
            Cursor = Cursors.WaitCursor;
            if (bIsConnected == true)
            {
                axCZKEM1.StartIdentify();
                axCZKEM1.Disconnect();
                bIsConnected = false;

            }
            Cursor = Cursors.Default;

        }

        private void validaNumeros(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            //((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }

        private void validaDecimales(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(tbRemuneracion.Text, "decimalpositivo", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        public void CargarHorarios(int valor)
        {

            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            try
            {
                DataSet HorariosLista1 = ConexionBD.EjecutarProcedimientoReturnDataSet("nuevo_ListarHorariosRotativos");
                DataSet HorariosLista2 = ConexionBD.EjecutarProcedimientoReturnDataSet("spuGeo_ListarHorarios");
                if (valor >= 300)
                {
                    cbHorarios.DataSource = HorariosLista1.Tables[0].DefaultView;
                    cbHorarios.DisplayMember = "DISPLAY MEMBER";
                    cbHorarios.ValueMember = "VALUE MEMBER";
                }
                else
                {
                    cbHorarios.DataSource = HorariosLista2.Tables[0].DefaultView;
                    cbHorarios.DisplayMember = "DISPLAY MEMBER";
                    cbHorarios.ValueMember = "VALUE MEMBER";
                }


            }
            catch
            { }
            ConexionBD.Desconectar();

            //ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            //ConexionBD.EjecutarProcedimientoReturnComboBox(cbHorarioDefault, true, "spuGeo_ListarHorarios");
            //ConexionBD.EjecutarProcedimientoReturnComboBox(cbHorarioDefault, true, "nuevo_ListarHorariosRotativos");
            //cbHorarioDefault.Refresh();
            //ConexionBD.Desconectar();
        }














        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();
            LimpiarDatos();

        }

        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar, buscar, habilitar, eliminar
        }
        private Tipo tipo;
#endregion


        private void habilitaBoton()
        {
            btnGuardar.Enabled = tipo == Tipo.guardar || tipo == Tipo.habilitar;
            btnEliminar.Enabled = tipo == Tipo.habilitar;
            btnHabilitar.Enabled = tipo == Tipo.buscar || tipo == Tipo.habilitar;
            btnEstado.Enabled = tipo == Tipo.buscar ;
            gbDatos.Enabled = tipo == Tipo.guardar || tipo == Tipo.habilitar;
            gbContrato.Enabled = tipo == Tipo.guardar || tipo == Tipo.habilitar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            LimpiarDatos();
            frmBuscarDNI busca = new frmBuscarDNI(string_ArchivoConfiguracion);
            busca.ShowDialog();

            if (busca.pDNI.ToString().Length < 8)
            {
                if (busca.pDNI.ToString().Length == 5)
                {
                    tbDNI.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 6)
                {
                    tbDNI.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 7)
                {
                    tbDNI.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNI.Text = busca.pDNI;
               
                
            }

            if (busca.pDNI.ToString().Length > 0)
            {
                tipo = Tipo.buscar;
                habilitaBoton();
            }


            
        }









        private void pbFoto_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }


        private void CargarFoto()
        {
            this.ofd_CargarImagen.Title = "Cargar Fotografía";
            this.ofd_CargarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            this.ofd_CargarImagen.Filter = "Imagenes (*.gif)|*.gif|Imagenes(*.bmp)|*.bmp|Imagenes(*.jpg)|*.jpg|Imagenes(*.png)|*.png";

            this.ofd_CargarImagen.DefaultExt = "jpg";
            this.ofd_CargarImagen.FilterIndex = 3;
            this.ofd_CargarImagen.FileName = "";

            if (this.ofd_CargarImagen.ShowDialog() == DialogResult.OK)
            {
                if (this.ofd_CargarImagen.FileName != string.Empty)
                {
                    try
                    {
                        this.pbFoto.Image = Image.FromFile(this.ofd_CargarImagen.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.siluetaPersona);
                    }

                }
                else
                {
                    pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.siluetaPersona);
                }


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            tipo = Tipo.guardar;
            habilitaBoton();
            tbDNI.Focus();
            tbDNI.Select();
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbDNI.Text.Length == 8)
            {
                BuscarDatosPersonal(tbDNI.Text);
                BuscarContratoPersonal(tbDNI.Text);
                tipo = Tipo.habilitar;
                habilitaBoton();
            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbProvincia.SelectedValue != null) && (cbProvincia.ValueMember != null) && (cbProvincia.ValueMember.Trim() != "") && (cbProvincia.SelectedValue.ToString().Length <= 10))
                CargarDistritos((cbProvincia.SelectedValue.ToString()));
        }

        private void cbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbCargos.SelectedValue != null) && (cbCargos.ValueMember != null) && (cbCargos.ValueMember.Trim() != ""))
            {
                DataTable DatosCargo = (DataTable)cbCargos.DataSource;
                tbRemuneracion.Text = DatosCargo.Rows[cbCargos.SelectedIndex]["SUELDO"].ToString();
                if ((cbHorarios.SelectedValue != null) && (cbHorarios.ValueMember != null) && (cbHorarios.ValueMember.Trim() != ""))
                {
                    idHorario = Convert.ToInt32(DatosCargo.Rows[cbCargos.SelectedIndex]["HORARIO"]);
                    CargarHorarios(idHorario);

                    cbHorarios.SelectedValue = DatosCargo.Rows[cbCargos.SelectedIndex]["HORARIO"];
                }
            }
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFechaFin.Value = dtFechaInicio.Value;
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaInicio.Value > dtFechaFin.Value)
                dtFechaFin.Value = dtFechaInicio.Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonal();
            tipo = Tipo.eliminar;
            habilitaBoton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text.Trim() != "" && tbDNI.Text.Trim().Length == 8 && tbNombres.Text.Trim() != "" && tbPaterno.Text.Trim() != "" && (!ValidarDatos.EsTextoVacioOMenorLongitud(tbNombres, 3)) && (!ValidarDatos.EsTextoVacioOMenorLongitud(tbPaterno, 3)))
            {
                tbDNI.ReadOnly = true;
                tbNombres.ReadOnly = true;
                tbPaterno.ReadOnly = true;

                frmRegistrarHuellas RegistrarDatosAcceso = new frmRegistrarHuellas(string_ArchivoConfiguracion, int_IdMachine, st_IPMachine, int_PortNumber, tbDNI.Text.Trim(), tbNombres.Text + " " + tbPaterno.Text);

                SeGuardaronDatosHuella = false;
                try
                {
                    RegistrarDatosAcceso.ShowDialog();
                    SeGuardaronDatosHuella = RegistrarDatosAcceso.SeGuardaronDatos;
                    CodigoTarjetaIden = RegistrarDatosAcceso.NroTarjetaIdentificacion;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: "+ex.Message);
                }
            }
            else
                MessageBox.Show("Debe Ingresar el DNI y los Nombres del Usuario", "FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            tipo = Tipo.habilitar;
            habilitaBoton();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbHabilitado_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPersonal1_Load(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            frmHabilitaPersonal habilita = new frmHabilitaPersonal(string_ArchivoConfiguracion);
            habilita.ShowDialog();

        }



    }
}
