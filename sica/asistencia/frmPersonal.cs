using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using clases;

namespace asistencia
{
    public partial class frmPersonal : Form
    {



        CValidacion ValidarDatos;
        CConection ConexionBD;
        //bool HuellaCargada = false;
        bool SeGuardaronDatosHuella = false;
        string CodigoTarjetaIden = "";
        object[] VariablesPersonal = { "pDocumentoDNI", "pNombres", "pPaterno", "pMaterno", "pSexo", "pFoto", "pFechaNacimiento", "pEmail", "pDireccion", "pIdDistrito", "pTelefono", "pCelular", "pOcupacion", "pUsuario", "pContrasenia","pIdCodPersonaEmpresa","pIdAgencia","pIdArea","pIdModalidad","pFechaInicio","pFechaFin","pEnableSINO"};
        object[] DatosPersonal = new object[22];

        //para eliminar los datos
        object[] VariablesEliminarPersonal = { "pDocumentoDNI", "pIdCodPersonalEmpresa" };
        
     
        //datos de reloj
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
        //fin datos de reloj
        
        
        string string_ArchivoConfiguracion;


        public frmPersonal(string p_IPReloj, int p_PuertoReloj, string ArchivoCOnfig)
        {
      
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            IPMachineNumber = p_IPReloj;
            st_IPMachine = p_IPReloj;
            PortNumber = p_PuertoReloj;

            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            CargarDatos();
        }



        public void CargarDatos()
        {
            //Cargar Provincias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbProvincia, true, "spuGeo_ListarProvincias");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbAgencia, true, "spuGeo_ListarAgencias");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbAreasTrabajo, true, "spuGeo_ListarAreas");
            ConexionBD.EjecutarProcedimientoReturnComboBox(cbModalidadContrato, true, "spuGeo_ListarModalidades");
     
            //Cosas por defecto
            cbProvincia.Refresh();
            cbAgencia.Refresh();
            cbAreasTrabajo.Refresh();
            cbModalidadContrato.Refresh();
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

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbProvincia.SelectedValue != null) && (cbProvincia.ValueMember != null) && (cbProvincia.ValueMember.Trim() != "") && (cbProvincia.SelectedValue.ToString().Length <= 10))
                CargarDistritos((cbProvincia.SelectedValue.ToString()));
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbDNI.Text.Length == 8)
            {
                BuscarDatosPersonal(tbDNI.Text);
              
            }

        }



        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    tbNombres.Text = DatosPersonal[1].ToString();
                    tbPaterno.Text = DatosPersonal[2].ToString();
                    tbMaterno.Text = DatosPersonal[3].ToString();
                    rbMasculino.Checked = true;
                    if (DatosPersonal[4].ToString().Trim() == "F")
                        rbFemenino.Checked = true;
                    try
                    {
                        pbFoto.Image = ConexionBD.Bytes2Image((byte[])DatosPersonal[5]);
                    }
                    catch
                    {
                        pbFoto.Image = (System.Drawing.Image)(asistencia.Properties.Resources.siluetaPersona);
                    }
                    dtFechaNacimiento.Value = new DateTime(int.Parse(DatosPersonal[8].ToString()), int.Parse(DatosPersonal[7].ToString()), int.Parse(DatosPersonal[6].ToString()));
                    tbEmail.Text = DatosPersonal[9].ToString();
                    tbDireccion.Text = DatosPersonal[10].ToString();
                    cbProvincia.SelectedValue = DatosPersonal[11].ToString();
                    cbDistrito.SelectedValue = DatosPersonal[12].ToString();
                    tbTelefono.Text = DatosPersonal[13].ToString();
                    tbCelular.Text = DatosPersonal[14].ToString();
                    tbProfesion.Text = DatosPersonal[15].ToString();


                    tbCodigoEmpresa.Text = DatosPersonal[18].ToString();
                    cbAgencia.SelectedValue = DatosPersonal[19].ToString();
                    cbAreasTrabajo.SelectedValue = DatosPersonal[20].ToString();
                    cbModalidadContrato.SelectedValue = DatosPersonal[21].ToString();

                    dtFechaInicio.Value = new DateTime(int.Parse(DatosPersonal[24].ToString()), int.Parse(DatosPersonal[23].ToString()), int.Parse(DatosPersonal[22].ToString()));
                    dtFechaFin.Value = new DateTime(int.Parse(DatosPersonal[27].ToString()), int.Parse(DatosPersonal[26].ToString()), int.Parse(DatosPersonal[25].ToString()));
           
                }

            }
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
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
        }






        public void LimpiarDatos()
        {
            DatosPersonal = new object[17];

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
            cbAgencia.SelectedIndex=0;
            cbAreasTrabajo.SelectedIndex=0;
            cbProvincia.SelectedIndex=0;
            

        }

    


        private void valida_texto(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasEspacio", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void valida_numeros(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "Numeros", sender, e);
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked)
                ((RadioButton)(sender)).ForeColor = Color.Firebrick;
            else
                ((RadioButton)(sender)).ForeColor = Color.DimGray;
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked)
                ((RadioButton)(sender)).ForeColor = Color.Firebrick;
            else
                ((RadioButton)(sender)).ForeColor = Color.DimGray;
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









      

        private void GuardarLosDatos()
        {
          
            DatosPersonal = new object[22];
            DatosPersonal[0] = tbDNI.Text.Trim();
            DatosPersonal[1] = tbNombres.Text;
            DatosPersonal[2] = tbPaterno.Text;
            DatosPersonal[3] = tbMaterno.Text;
            DatosPersonal[4] = "M";
            if (rbFemenino.Checked)
                DatosPersonal[4] = "F";
            DatosPersonal[5] = ConexionBD.Image2Bytes(pbFoto.Image);
            DatosPersonal[6] = ConexionBD.FechaFormatoMySQL(dtFechaNacimiento.Value, 0);
            DatosPersonal[7] = tbEmail.Text;
            DatosPersonal[8] = tbDireccion.Text;
            DatosPersonal[9] = cbDistrito.SelectedValue;
            DatosPersonal[10] = tbTelefono.Text;
            DatosPersonal[11] = tbCelular.Text;
            DatosPersonal[12] = tbProfesion.Text;
            DatosPersonal[13] = tbDNI.Text.Trim();
            DatosPersonal[14] = "1234";
            DatosPersonal[15] = tbCodigoEmpresa.Text;
            DatosPersonal[16] = cbAgencia.SelectedValue;
            DatosPersonal[17] = cbAreasTrabajo.SelectedValue;
            DatosPersonal[18] = cbModalidadContrato.SelectedValue;
            DatosPersonal[19] = ConexionBD.FechaFormatoMySQL(dtFechaInicio.Value, 0);
            DatosPersonal[20] = ConexionBD.FechaFormatoMySQL(dtFechaFin.Value, 0);
            DatosPersonal[21] = "0";
            

            // Guardar los datos
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool TransaccionCompletada = false;
            string Mensaje = "";
            try
            {
                ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_GuardarDatosPersonal", VariablesPersonal, DatosPersonal);
               
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbDNI, 8))
            {
                if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbNombres, 3))
                {
                    if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbPaterno, 3))
                    {
                        if (ValidarDatos.ExisteSeleccion(cbDistrito))
                        {
                            if (ValidarDatos.ExisteSeleccion(cbAgencia) && ValidarDatos.ExisteSeleccion(cbAreasTrabajo) && ValidarDatos.ExisteSeleccion(cbModalidadContrato))
                            {
                                //if (SeGuardaronDatosHuella)//pbHuella.Image.)
                                //{
                                GuardarLosDatos();
                                //}
                                /*else
                                    MessageBox.Show("CARGUE LA HUELLA DIGITAL", "FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                            }
                            else
                                MessageBox.Show("DEBE SELECCIONAR LOS CAMPOS DE AGENCIA, AREA DE TRABAJO, CARGO, MODALIDAD Y HORARIOS ", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("EL CAMPO DISTRITO ES OBLIGATORIO, SELECCIONE UN DISTRITO", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("EL CAMPO APELLIDO PATERNO ES OBLIGATORIO, INGRESE EL APELLIDO", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("EL CAMPO NOMBRE ES OBLIGATORIO, INGRESE UN NOMBRE", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("EL CAMPO DNI ES OBLIGATORIO, INGRESE DNI CORRECTO", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void pbReloj_Click(object sender, EventArgs e)
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
                catch
                {
                }
            }
            else
                MessageBox.Show("Debe Ingresar el DNI y los Nombres del Usuario", "FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonal();
        }


        private void EliminarPersonal()
        {
            ConectarseAlReloj();
            if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbDNI, 8) && bIsConnected)
            {
                if (MessageBox.Show("¿Esta seguro que quiere eliminar al personal? \r\nSe boraran los datos de aistencia, permisos y otros", "CUIDADO!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //VariablesEliminarPersonal = { "DocumentoDNI", "IdCodPersonalEmpresa" };
                    DatosPersonal = new object[2];
                    DatosPersonal[0] = tbDNI.Text.Trim();
                    DatosPersonal[1] = tbCodigoEmpresa.Text;

                    // Guardar los datos
                    ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                    bool TransaccionCompletada = false;
                    string Mensaje = "";
                    try
                    {
                        ConexionBD.EjecutarProcedimientoReturnVoid("spuPri_EliminarPersonal", VariablesEliminarPersonal, DatosPersonal);
                        TransaccionCompletada = true;
                        ConexionBD.COMMIT();
                        EliminarDatosReloj(tbDNI.Text.Trim());
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
                        MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                    else
                        MessageBox.Show("NO SE PUDO ELIMINAR EL PERSONAL, REVISE LOS DATOS \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else
                MessageBox.Show("EL CAMPO DNI ES OBLIGATORIO ADEMAS DEBE CONECTARSE AL RELOJ, INGRESE DNI CORRECTO", "ERROR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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


    }
}
