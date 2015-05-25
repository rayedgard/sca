using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;

namespace asistencia
{
    public partial class frmReporteGeneral : Form
    {

        CValidacion ValidarDatos;
        CConection ConexionBD;
        string NombreModalidad;
        string NombreMunicipalidad;
        string string_ArchivoConfiguracion;

        string areaModalidad = "";

        public frmReporteGeneral(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            /*dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            cbTipoDeReporte.SelectedIndex = 0;*/



            CargarDatosReporte();


            cbFiltrado.Items.Add("MODALIDAD");
            cbFiltrado.Items.Add("AREAS");
            cbFiltrado.SelectedIndex = 0;
        }




        public void CargarDatosReporte()
        {
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            NombreMunicipalidad = ConexionBD.EjecutarProcedimientoReturnMensaje("spuGeo_RecuperarNombreMunicipalidad");
            ConexionBD.Desconectar();
        }







        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDNI busca = new frmBuscarDNI(string_ArchivoConfiguracion);
            busca.ShowDialog();

            if (busca.pDNI.ToString().Length < 8)
            {
                if (busca.pDNI.ToString().Length == 5)
                {
                    tbDNIPersonal.Text = "000" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 6)
                {
                    tbDNIPersonal.Text = "00" + busca.pDNI;
                }
                if (busca.pDNI.ToString().Length == 7)
                {
                    tbDNIPersonal.Text = "0" + busca.pDNI;
                }
            }
            else
            {
                tbDNIPersonal.Text = busca.pDNI;
            }
        }

        private void tbDNIPersonal_TextChanged(object sender, EventArgs e)
        {
            lbNombreUsuario.Text = "";
            BuscarDatosPersonal(tbDNIPersonal.Text);
        }

        public void BuscarDatosPersonal(string pDNI)
        {
            if (pDNI.Length == 8)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                object[] DatosPersonal = ConexionBD.RecuperarDatosEnArregloUnaFila("spupri_BuscarPersona", "pDocumentoDNI", pDNI);
                ConexionBD.Desconectar();

                if (DatosPersonal.Length > 1)
                {
                    lbNombreUsuario.Text = DatosPersonal[2].ToString() + " " + DatosPersonal[3].ToString() + " " + DatosPersonal[4].ToString();
                }
                else
                {
                    lbNombreUsuario.Text = "";
                }
            }
        }

        private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrado.SelectedItem.ToString().Trim() == "MODALIDAD")/*CAMBIAR PARA LOS FOLTRADOS POR SEDES O AREAS*/
            {

                //Cargar POR MODALIDAD
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbModalidades, true, "spuGeo_ListarModalidades");
                ConexionBD.Desconectar();
                //Cargar Distritos

                lblAreas.Text = "MODALIDAD";


            }
            if (cbFiltrado.SelectedItem.ToString().Trim() == "AREAS")
            {
                //Cargar POR MODALIDAD
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                ConexionBD.EjecutarProcedimientoReturnComboBox(cbModalidades, true, "spuGeo_ListarAreas");
                ConexionBD.Desconectar();
                //Cargar Distritos

                lblAreas.Text = "AREAS";
            }
            //fin filtrado


            areaModalidad = cbFiltrado.SelectedItem.ToString().Trim();
        }
        int estadoPersonal = 0;
        private void btnVerReportePersonal_Click(object sender, EventArgs e)
        {
            if (rbtPersonalActivo.Checked)
            { estadoPersonal = 0; }/*PARA EL PERSONAL QUE REGISTRA ASISTENCIA EN LOS RELOJES BIOMETRICOS*/
            if (rbtPersonalInactivo.Checked)
            { estadoPersonal = 1; }/*PARA EL PERSONAL QUE REGISTRA MANUALMENTE*/
            if (rbtTodoPersonal.Checked)
            { estadoPersonal = 2;}/*PARA EL PERSONAL QUE NO REGISTRA ASISTENCIA --- YA NO LABORA.----*/

            pBoolMostrarResumen = false;
            int dni = 0;
            int.TryParse(tbDNIPersonal.Text.Trim(), out dni);
            dgvReportePersonal.Rows.Clear();
            dgvResumen.Rows.Clear();
            dgvResumen2.Rows.Clear();

            if (dni != 0)
            {
                ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                try
                {
                    pBoolMostrarResumen = true;
                    CargarReporteEnGrid(dni.ToString(), false, true, estadoPersonal);
                }
                catch
                {
                }
                finally
                {
                    ConexionBD.Desconectar();
                }


            }
            else
            {
                if (tbDNIPersonal.Text.Trim() == "")
                {

                    vertodoslosusuarios(false, false);
                }
            }
        }




        private void vertodoslosusuarios(bool bSoloTardanzas, bool MostrarSumatoria)
        {
            DataSet ListaDnis = null;
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            try
            {
                ListaDnis = ConexionBD.EjecutarProcedimientoReturnDataSet("spuRep_ListaDNIsPersonal");
                if (ListaDnis != null && ListaDnis.Tables != null && ListaDnis.Tables[0] != null && ListaDnis.Tables[0].Rows != null && ListaDnis.Tables[0].Rows.Count > 0)
                {
                    int NroDNIs = ListaDnis.Tables[0].Rows.Count;
                    object[] dnipersonal = { "" };

                    /*para el progresbar*/
                    //aqui cargamos los valores del progresbar
                    prbCarga.Visible = true;
                    prbCarga.Minimum = 0;
                    // PARA HACER LA DIFERENCIA ENTRE LAS FECHAS
                    TimeSpan ts = (dtpFechaFInPersonal.Value.Date - dtpFechaInicioPersonal.Value.Date);

                    // DESPUES DE HACER LA DIFERENCIA LO CONVERTIMOS EN DIAS.
                    prbCarga.Maximum = NroDNIs;
                    prbCarga.Step = 1;
                    prbCarga.BackColor = Color.Blue;
                    //------fin progresbar---------



                    for (int j = 0; j < NroDNIs; j = j + prbCarga.Step)
                    {
                        dnipersonal = ListaDnis.Tables[0].Rows[j].ItemArray;
                        CargarReporteEnGrid(dnipersonal[0].ToString().Trim(), bSoloTardanzas, MostrarSumatoria, estadoPersonal);

                        prbCarga.PerformStep();

                    }
                    prbCarga.Value = 0;
                    prbCarga.Visible = false;
                }
            }
            catch
            {

            }
            finally
            {
                ConexionBD.Desconectar();
            }
        }







        private void CargarReporteEnGrid(string pDNI, bool MostrarSoloFaltas, bool MostrarSumatorias, int estado)
        {
            string pModalidad = "-1";
            pTotalFaltas = 0;
            pTotalTardanzas = 0;
            pTotalTrajados = 0;
            pDiasVacacion = 0;
            int dias = (dtpFechaFInPersonal.Value.Day -dtpFechaInicioPersonal.Value.Day)+1;


            int diasNoLaborabnles = ConexionBD.EjecutarProcedimientoReturnEntero("nuevo_muestraDiasNoLaborables", "pFecha", string.Format("{0}-{1}-{2}", dtpFechaFInPersonal.Value.Year, dtpFechaFInPersonal.Value.Month, dtpFechaFInPersonal.Value.Day));
           
            
            int diasLibres = 0;
            ////////vacaciones y extras
            extras = 0;
            extrasTotal = 0;
            /*parametro que almacena y actualiza los minutos para descuientos*/
            int descuentos = 0;
            int asistioNormal = 0;

            if (cbSoloEstaModalidad.Checked && cbModalidades.Text.Trim() != "" && cbModalidades.SelectedValue != null)
            {
                pModalidad = cbModalidades.SelectedValue.ToString().Trim();
                NombreModalidad = cbModalidades.SelectedText;

            }



            object[] ParamNames = { "pFechaConsulta", "pIdArea", "pIdCargo", "pDocumentoDNI", "pHabilitado", "pAreaModalidad" };
            object[] ParamValues = { "2005-05-05", pModalidad, "1", "45659875", 0, "pAreaModalidad" };
            ParamValues[3] = pDNI;
            ParamValues[0] = string.Format("{0}-{1}-{2}", dtpFechaInicioPersonal.Value.Year, dtpFechaInicioPersonal.Value.Month, dtpFechaInicioPersonal.Value.Day);
            ParamValues[4] = estado; /*AQUI ADJUNTAMOS EL ESTADO DEL PERSONAL, PARA FILTRAR LOS REPORTES DEL PERSONAL*/
            ParamValues[5] = areaModalidad; /*AQUI ADJUNTAMOS EL ESTADO DEL PERSONAL, PARA FILTRAR LOS REPORTES DEL PERSONAL*/

            string Consulta = "reporte";
            string Consulta3 = "nuevo_determinaAreaPersonal";//PARA LAS AREAS
            DateTime dtFechaInicioAnterior = dtpFechaInicioPersonal.Value;

            DateTime dtFechaPosterior;

            try
            {
                for (int i = 0; dtFechaInicioAnterior.Date <= dtpFechaFInPersonal.Value.Date; i++)
                {
                    ParamValues[0] = string.Format("{0}-{1}-{2}", dtFechaInicioAnterior.Year, dtFechaInicioAnterior.Month, dtFechaInicioAnterior.Day);
                    dtFechaInicioAnterior = dtFechaInicioAnterior.AddDays(1);
                    DataSet Reporte = ConexionBD.EjecutarProcedimientoReturnDataSet(Consulta, ParamNames, ParamValues);
                    DataSet Reporte3 = ConexionBD.EjecutarProcedimientoReturnDataSet(Consulta3, "pDni", pDNI);//par lAS AREAS

                    if (Reporte != null && Reporte.Tables != null && Reporte.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < Reporte.Tables[0].Rows.Count; j++)
                        {
                            if (MostrarSoloFaltas)
                            {
                                int SegundosTarde = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[13].ToString());/*tardanza total de la base*/
                                int TotalTrabajo = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[12].ToString());/*total de horaas trabajadas en la base*/
                                extras = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[14].ToString());/*total de horas extas eb la base*/
                                if (SegundosTarde > 0 || TotalTrabajo <= 0)
                                {
                                    dgvReportePersonal.Rows.Add(Reporte.Tables[0].Rows[j].ItemArray);

                                }

                            }
                            else
                            {
                                int SegundosTarde = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[13].ToString());
                                int TotalTrabajo = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[12].ToString());
                                extras = ConvertirTimeASegundos(Reporte.Tables[0].Rows[j].ItemArray[14].ToString());
                                string Observacion = Reporte.Tables[0].Rows[j].ItemArray[15].ToString();
                               
                                /* aqui calculamos el tiempo exta por periodo*/
                                if (extras > 0)
                                {
                                    extrasTotal = extras + extrasTotal;
                                }

                                pTotalTardanzas = pTotalTardanzas + SegundosTarde;
                                //ultima modificacion para que los reportes salgan con todo
                                if (Observacion.Trim().ToUpper().Equals("FALTA NO JUSTIFICADA") || Observacion.Trim().ToUpper().Equals("FALTA POR TARDANZA NO JUSTIFICADA") || Observacion.Trim().ToUpper().Equals("FALTA NO JUSTIFICADA POR OMISIÓN DE REGISTRO"))
                                {
                                    pTotalFaltas++;
                                }

                                if (Observacion.Trim().ToUpper().Equals("DIA LIBRE O DESCANSO"))
                                {
                                    diasLibres++;
                                }

                                if (TotalTrabajo <= 0)
                                {
                                    if (Observacion.Trim() != "")/*para validar los vacios*/
                                    {
                                        string goce = Observacion.Trim().Substring(0, 1);
                                        string goceName = Observacion.Trim().Substring(1);
                                        if (goce == "1" || goce == "0")
                                        {
                                            Reporte.Tables[0].Rows[j][15] = goceName;
                                            if (goce == "0")
                                                pTotalFaltas++;
                                        }
                                    }

                                }
                                else
                                {
                                    pTotalTrajados = pTotalTrajados + TotalTrabajo;
                                }


                                if (pTotalFaltas == 0 && pTotalTardanzas <= 3659)
                                {
                                    asistioNormal++;

                                }
                                //if (estado2 == 1)
                                //{
                                //    acumulaEstado++;
                                //}

                                dgvReportePersonal.Rows.Add(Reporte.Tables[0].Rows[j].ItemArray);

                            }

                        }



                        //CODIGO PARA DETERMINAR LOS ACUMULADOS DE L
                        dtFechaPosterior = dtpFechaFInPersonal.Value.AddDays(1);
                        if (dtFechaInicioAnterior.Date == dtFechaPosterior.Date)
                        {
                            dgvReportePersonal.Rows.Add("Tardanza:", ConvertirSegundosATime(pTotalTardanzas) + " Hrs", "Aproximado: " + ConvertirSegundosAMinutos(pTotalTardanzas) + "m", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
                            dgvReportePersonal.Rows.Add("Faltas:", (pTotalFaltas).ToString(), " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
                            if (pTotalTardanzas > 3600) 
                            {
                                descuentos = pTotalTardanzas - 3600;
                                dgvReportePersonal.Rows.Add("Descuento:", ConvertirSegundosAMinutos(descuentos) + "m", " Por exeder el tiempo limite de tardanzas");
                            }
                            //object[] DatosVacaciones1 = ConexionBD.RecuperaDatoVacaciones("spuRep_numeroVacaciones", "pDNI", pDNI);
                            //dgvReportePersonal.Rows.Add("VACACIONES:", Convert.ToInt 32(DatosVacaciones1[0]));

                        }

                        Temporal[0] = Reporte.Tables[0].Rows[0].ItemArray[1].ToString();//dni
                        Temporal[1] = Reporte.Tables[0].Rows[0].ItemArray[2].ToString();//nombre
                        Temporal[2] = Reporte3.Tables[0].Rows[0].ItemArray[0].ToString();//area
                      
                    }



                }


                //codigo para almacenar los datos acumulados, resumen de reporte
                /*/PARA UN MEJOR CONTROL DEL REPORTE CAMBIAR 5 POR UN GENERADOR DE DIAS CON FALTA/*/
                if (pTotalFaltas > 0 & pTotalFaltas < (dias-(diasLibres+diasNoLaborabnles)) || pTotalTardanzas > 3659)
                {

                    dgvResumen.Rows.Add(Temporal[0].ToString(), Temporal[3].ToString(),
                        Temporal[1].ToString(),
                        ConvertirSegundosATime(pTotalTardanzas),
                        ConvertirSegundosAMinutos(descuentos),
                        pTotalFaltas
                        );

                }


                /*PARA AGREGAR AL PERSONAL CON ASISTENCIA NORMAL*/
                //if (asistioNormal == 30 )
                //{

                //    dgvResumen.Rows.Add(Temporal[0].ToString(), Temporal[3].ToString(),
                //        Temporal[1].ToString(), Temporal[2].ToString(),
                //        ConvertirSegundosATime(pTotalTardanzas),
                //        ConvertirSegundosAMinutos(descuentos),
                //        pTotalFaltas, "Asistencia Normal"
                //        );

                //}

                //codigo para almacenar los datos acumulados, resumen de reporte
                /*/PARA UN MEJOR CONTROL DEL REPORTE CAMBIAR 6 POR UN GENERADOR DE DIAS CON FALTA/*/
                if (pTotalFaltas >= (dias - (diasLibres + diasNoLaborabnles)) & pTotalTardanzas == 0 & extrasTotal == 0 & pTotalTrajados == 0)
                {
                    dgvResumen2.Rows.Add(Temporal[0].ToString(), Temporal[2].ToString(),
                        Temporal[1].ToString(), pTotalFaltas, "NO REGISTRA ASISTENCIA"
                        );


                    dgvResumen.Rows.Add(Temporal[0].ToString(), Temporal[2].ToString(),
                        Temporal[1].ToString(),
                        ConvertirSegundosATime(pTotalTardanzas),
                        ConvertirSegundosAMinutos(descuentos),
                        pTotalFaltas, "NO REGISTRA ASISTENCIA"
                        );



                }
                /*FIN  RESUMEN*/

                //para las vacaciones diferidas
                //ConexionBD.Conectar(false, string_ArchivoConfiguracion);
                //object[] DatosVacaciones = ConexionBD.RecuperaDatoVacaciones("spuRep_numeroVacaciones", "pDNI", pDNI);
                //ConexionBD.Desconectar();
                //fin vacaciones

                //lbExtras.Text = ConvertirSegundosATime(extrasTotal);
                //lbFaltas.Text = (pTotalFaltas).ToString();
                //lbTrabajados.Text = ConvertirSegundosATime(pTotalTrajados);
                //lbMinutos.Text = ConvertirSegundosAMinutos(pTotalTardanzas);
                //VacacionesR = Convert.ToInt32(DatosVacaciones[0]);
                //lbVacacionesR.Text = VacacionesR.ToString();
                //lbTardanza.Text = ConvertirSegundosATime(pTotalTardanzas);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                // dtpFechaInicioPersonal.Value = dtFechaInicioAnterior;
            }

        }




        private int ConvertirTimeASegundos(string Time)
        {
            string[] tiempo = Time.Trim().Split(':');
            int hora = 0;
            int mint = 0;
            int segd = 0;

            int.TryParse(tiempo[0], out hora);
            int.TryParse(tiempo[1], out mint);
            int.TryParse(tiempo[2], out segd);

            return hora * 3600 + mint * 60 + segd;
        }

        private int ConvertirTimeAMinutos(string Time)
        {
            string[] tiempo = Time.Trim().Split(':');
            int hora = 0;
            int mint = 0;
            int segd = 0;

            int.TryParse(tiempo[0], out hora);
            int.TryParse(tiempo[1], out mint);
            int.TryParse(tiempo[2], out segd);

            return hora * 60 + mint + segd / 60;
        }



        public string ConvertirSegundosATime(int segundosos)
        {
            int hora = segundosos / 3600;
            int minutos = (segundosos - (hora * 3600)) / 60;
            int segundos = (segundosos - (hora * 3600) - (minutos * 60));
            return string.Format("{0}:{1}:{2}", hora, minutos, segundos);
        }

        public string ConvertirSegundosAMinutos(int segundosos)
        {

            double minutos = Convert.ToDouble(segundosos) / 60 - ((Convert.ToDouble(segundosos) % 60) / 60);
            return string.Format("{0:0}", minutos);
        }










        int pTotalFaltas = 0;
        int pTotalTardanzas = 0;
        int pTotalTrajados = 0;
        bool pBoolMostrarResumen = false;
        //datos agregados para el nuevo reporte-------------
        int extras = 0;
        int extrasTotal = 0;
        int VacacionesR = 0;
        int pDiasVacacion = 0;


        object[] Temporal = { "dni", "nombre", "area" };

        private void btnExcelModalidad_Click(object sender, EventArgs e)
        {
            exportaExcel();
        }

         public void exportaExcel()
        {

            string MyDocumentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string TargetFilename = System.IO.Path.Combine(MyDocumentsPath, "Sample.xlsx");
            //  Step 1: Create a DataSet, and put some sample data in it
           DataTable dt = agregadatos(dgvReportePersonal);

            //DataTable dt = ((DataTable)dgvReportePersonal.DataSource);
            //  Step 2: Create the Excel file
            try
            {
                CreateExcelFile.CreateExcelDocument(dt, TargetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            } 
        }


         public DataTable agregadatos(DataGridView datos)
         {
             DataTable dt = new DataTable();
             dt.Columns.Add("Fecha", typeof(System.String));
             dt.Columns.Add("DNI", typeof(System.String));
             dt.Columns.Add("Nombres", typeof(System.String));
             dt.Columns.Add("Entrada", typeof(System.String));
             dt.Columns.Add("Tardanza 1", typeof(System.String));
             dt.Columns.Add("Salida/Refrigerio", typeof(System.String));
             dt.Columns.Add("Entrada/Refrigerio", typeof(System.String));
             dt.Columns.Add("Tardanza 2", typeof(System.String));
             dt.Columns.Add("Salida", typeof(System.String));
             dt.Columns.Add("Permiso Salida", typeof(System.String));
             dt.Columns.Add("Permiso Retorno", typeof(System.String));
             dt.Columns.Add("Horas Permiso", typeof(System.String));
             dt.Columns.Add("Total Horas Trabajadas", typeof(System.String));
             dt.Columns.Add("Tardanzas", typeof(System.String));
             dt.Columns.Add("Horas Extra", typeof(System.String));
             dt.Columns.Add("Observación", typeof(System.String));

             foreach (DataGridViewRow rowGrid in datos.Rows)
             {
                 DataRow row = dt.NewRow();
                
                 row["Fecha"] = rowGrid.Cells[0].Value.ToString();
                 row["DNI"] = rowGrid.Cells[1].Value.ToString();
                 if (rowGrid.Cells[2].Value == null)
                 { row["Nombres"] = ""; }
                 else
                 {row["Nombres"] = rowGrid.Cells[2].Value.ToString(); }
                 
                 if(rowGrid.Cells[3].Value==null)
                 {row["Entrada"]="";}
                 else
                 {row["Entrada"] = rowGrid.Cells[3].Value.ToString();}

                 if(rowGrid.Cells[4].Value==null)
                 {row["Tardanza 1"]="";}
                 else
                 {row["Tardanza 1"] = rowGrid.Cells[4].Value.ToString();}

                 if (rowGrid.Cells[5].Value == null)
                 { row["Salida/Refrigerio"] = ""; }
                 else
                 { row["Salida/Refrigerio"] = rowGrid.Cells[5].Value.ToString(); }

                 if(rowGrid.Cells[6].Value==null)
                 {row["Entrada/Refrigerio"]="";}
                 else
                 {row["Entrada/Refrigerio"] = rowGrid.Cells[6].Value.ToString();}

                   if(rowGrid.Cells[7].Value==null)
                 {row["Tardanza 2"]="";}
                 else
                 {row["Tardanza 2"] = rowGrid.Cells[7].Value.ToString();}

                   if(rowGrid.Cells[8].Value==null)
                 {row["Salida"]="";}
                 else
                 {row["Salida"] = rowGrid.Cells[8].Value.ToString();}

                  if(rowGrid.Cells[9].Value==null)
                 {row["Permiso Salida"]="";}
                 else
                 {row["Permiso Salida"] = rowGrid.Cells[9].Value.ToString();}

                  if(rowGrid.Cells[10].Value==null)
                 {row["Permiso Retorno"]="";}
                 else
                 {row["Permiso Retorno"] = rowGrid.Cells[10].Value.ToString();}

                  if(rowGrid.Cells[11].Value==null)
                 {row["Horas Permiso"]="";}
                 else
                 {row["Horas Permiso"] = rowGrid.Cells[11].Value.ToString();}

                  if(rowGrid.Cells[12].Value==null)
                 {row["Total Horas Trabajadas"]="";}
                 else
                 {row["Total Horas Trabajadas"] = rowGrid.Cells[12].Value.ToString();}

                 if(rowGrid.Cells[13].Value==null)
                 {row["Tardanzas"]="";}
                 else
                 {row["Tardanzas"] = rowGrid.Cells[13].Value.ToString();}

                  if(rowGrid.Cells[14].Value==null)
                 {row["Horas Extra"]="";}
                 else
                 {row["Horas Extra"] = rowGrid.Cells[14].Value.ToString();}


                  if(rowGrid.Cells[15].Value==null)
                 {row["Observación"]="";}
                 else
                 {row["Observación"] = rowGrid.Cells[15].Value.ToString();}




                 dt.Rows.Add(row);
             }

             return dt;
         }

         private void btnPDFExpor_Click(object sender, EventArgs e)
         {
             string MyDocumentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             string TargetFilename = System.IO.Path.Combine(MyDocumentsPath, "Sample.xlsx");
             //  Step 1: Create a DataSet, and put some sample data in it
             //DataTable dt = agregadatos(dgvResumen);

             DataTable dt = ((DataTable)dgvResumen.DataSource);
             //  Step 2: Create the Excel file
             try
             {
                 CreateExcelFile.CreateExcelDocument(dt, TargetFilename);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                 return;
             } 
         }


    }
}
