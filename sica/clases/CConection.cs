using System;
using System.Data;
using System.Collections;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace clases
{
    public class CConection
    {


        /* ATRIBUTOS */
        private DataSet aDatos;
        public MySqlConnection aConexionBD; // ----- Solo para uso interno
        private MySqlDataAdapter aAdaptador; // ----- Solo para uso interno 192.168.1.10localhost
        private MySqlCommand aComando;
        private string strCadenaConexion;
        private MySqlTransaction ATransaccion;

        private string aHost;
        private string aDB;
        private string aUser;
        string string_ArchivoConfiguracion;
        private string aPass;

        public CConection()
        {
            aHost = "";
            aDB = "";
            aUser = "";
            aPass = "";
            //ConectaBaseDatos("BDConfig.ini");
        }

        /// <summary>
        /// Se conectara al servidor dado y iniciara o no una transaccion
        /// </summary>
        /// <param name="IniciarTransaccion">True si se desea iniciar transacciones</param>
        public void Conectar(bool IniciarTransaccion, string ArchivoConfig)
        {
            string_ArchivoConfiguracion = ArchivoConfig;
            ConectaBaseDatos("BDConfig.ini");
            aConexionBD = new MySqlConnection(strCadenaConexion);

            if (aConexionBD.State == ConnectionState.Open)
                aConexionBD.Close();

            aConexionBD.Open();
            if (IniciarTransaccion)
                ATransaccion = aConexionBD.BeginTransaction();
        }
        public void ConectaBaseDatos(string BDArchivo)
        {

            //Realizar la coneccion a la base de datos con el Archivo de coneccion
            if (File.Exists(BDArchivo))
            {  //Existe archivo de configuracion de base de datos
                FileStream stream = new FileStream(BDArchivo, FileMode.Open, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(stream);
                reader.ReadLine();
                string Servidor = reader.ReadLine();
                string DB = reader.ReadLine();
                string usuario = reader.ReadLine();
                string contrasenia = reader.ReadLine();
                reader.Close();
                //Coneccion con windows login
                strCadenaConexion = string.Format("server={0};DataBase={1};Username={2};Password={3};", Servidor, DB, usuario, contrasenia);
                //ConeccionSQLINI = new SqlConnection("Data Source=" + Servidor + ";DataBase=" + Base + ";Integrated Security=True");
                //Coneccion con sa login
                //ConeccionSQLINI = new SqlConnection("workstation id=" + Servidor + "packet size=4096;user id=sa;data source=" + Servidor + ";persist security info=True;initial catalog=" + Base + ";password=" + Password);
                //return ConeccionSQLINI;
            }
            else
            {
                strCadenaConexion = string.Format("server={0};DataBase={1};Username={2};Password={3};", "localhost", "hospital", "root", "myql");
                //System.Environment.SpecialFolder folder = System.Environment.SpecialFolder.CommonApplicationData;
                CConfigXML configXml_ArchivoConfiguracion = new CConfigXML(string_ArchivoConfiguracion);
                string server = configXml_ArchivoConfiguracion.GetValue("principal", "servidor", "localhost");
                string database = configXml_ArchivoConfiguracion.GetValue("principal", "database", "hospital");
                string user = configXml_ArchivoConfiguracion.GetValue("principal", "usuario", "root");
                string passwordd = configXml_ArchivoConfiguracion.GetValue("principal", "contrasenia", "mysql");
                strCadenaConexion = string.Format("server={0};DataBase={1};Username={2};Password={3};", server, database, user, passwordd);
            }

        }
        public void COMMIT()
        {
            ATransaccion.Commit();
        }

        public void ROLLBACK()
        {
            ATransaccion.Rollback();
        }


        public void Desconectar()
        {
            aConexionBD.Close();
        }

        // Ejecutar una sentencia MySQL
        public DataSet EjecutarSentenciaMySQL(string TextoSQL)
        {
            DataSet Resultado = new DataSet();
            // ----- Crear objeto de comandos SQL para definir sentencia SQL 
            aAdaptador = new MySqlDataAdapter(TextoSQL, aConexionBD);

            // ----- Ejecutar Comando 
            aAdaptador.SelectCommand.CommandText = System.Data.CommandType.Text.ToString();
            aAdaptador.Fill(Resultado);

            return Resultado;
        }
        public DataSet EjecutarSentenciaMySQLRemoto(string TextoSQL)
        {
            DataSet Resultado = new DataSet();
            // ----- Crear objeto de comandos SQL para definir sentencia SQL 
            aAdaptador = new MySqlDataAdapter(TextoSQL, aConexionBD);
            aAdaptador.SelectCommand.ExecuteScalar();
            // ----- Ejecutar Comando 
            aAdaptador.SelectCommand.CommandText = System.Data.CommandType.Text.ToString();
            aAdaptador.Fill(Resultado);

            return Resultado;
        }
        /// <summary>
        /// Ejecuta el Procedimiento y devuelve un data set con el resultado de la consulta 
        /// </summary>
        /// <param name="NombreProcedimiento">Nombre del Procedimiento</param>
        /// <param name="Parametros"> EL Arraylist contiene elementos que son object[] Parametros = {pNombreVariable,pValorVariable}</param>
        /// <returns></returns>

        public DataSet EjecutarProcedimientoReturnDataSet(string NombreProcedimiento, ArrayList Parametros)
        {
            DataSet Resultado = new DataSet();
            aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
            aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            object[] ParametroElem;
            int NroParametros = Parametros.Count;

            for (int i = 0; i < NroParametros; i++)
            {
                ParametroElem = (object[])(Parametros[i]);
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParametroElem[0], ParametroElem[1]);
            }

            aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            return Resultado;
        }



        public string EjecutarProcedimientoReturnMensaje(string NombreProcedimiento, ArrayList Parametros)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                object[] ParametroElem;
                int NroParametros = Parametros.Count;
                for (int i = 0; i < NroParametros; i++)
                {
                    ParametroElem = (object[])(Parametros[i]);
                    aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParametroElem[0], ParametroElem[1]);
                }
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                string mensaje = "NO SE RETORNO NINGUN MENSAJE";
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Resultado.Tables[0].Rows[0][0].ToString();
                return mensaje;
            }
        }
        /// <summary>
        /// En este caso los parametros se mandan en dos arreglos el primero con los nombres y el segundo con sus valores respectivamente
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <param name="ParamNames"></param>
        /// <param name="ParamValues"></param>
        /// <returns></returns>
        public DataSet EjecutarProcedimientoReturnDataSet(string NombreProcedimiento, object[] ParamNames, object[] ParamValues)
        {
            DataSet Resultado = new DataSet();
            aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
            aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            int NroParametros = ParamNames.Length;

            for (int i = 0; i < NroParametros; i++)
            {
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamNames[i], ParamValues[i]);
            }

            aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            return Resultado;
        }

        public DataSet EjecutarProcedimientoReturnDataSet(string NombreProcedimiento, object ParamName, object ParamValue)
        {
            DataSet Resultado = new DataSet();
            aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
            aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamName, ParamValue);


            aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            return Resultado;
        }

        public void EjecutarProcedimientoReturnComboBox(ComboBox pComboBox, bool SeleccionarPrimero, string NombreProcedimiento, object ParamName, object ParamValue)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamName, ParamValue);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);

                try
                {
                    pComboBox.Items.Clear();
                }
                catch
                {
                    pComboBox.DataSource = null;
                }

                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                {
                    pComboBox.DataSource = Resultado.Tables[0];
                    pComboBox.DisplayMember = Resultado.Tables[0].Columns[1].ToString();
                    pComboBox.ValueMember = Resultado.Tables[0].Columns[0].ToString();

                    if ((SeleccionarPrimero) && pComboBox.Items.Count > 0)
                        pComboBox.SelectedIndex = 0;
                }
            }
        }



        /// <summary>
        /// ValueMember sera el primer parametro, DisplayMember el segundo
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <param name="ParamNames"></param>
        /// <param name="ParamValues"></param>
        /// <returns></returns>
        public void EjecutarProcedimientoReturnComboBox(ComboBox pComboBox, bool SeleccionarPrimero, string NombreProcedimiento, object[] ParamNames, object[] ParamValues)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                int NroParametros = ParamNames.Length;
                for (int i = 0; i < NroParametros; i++)
                    aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamNames[i], ParamValues[i]);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);

                try
                {
                    pComboBox.Items.Clear();
                }
                catch
                {
                    pComboBox.DataSource = null;
                }

                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                {
                    pComboBox.DataSource = Resultado.Tables[0];
                    pComboBox.DisplayMember = Resultado.Tables[0].Columns[1].ToString();
                    pComboBox.ValueMember = Resultado.Tables[0].Columns[0].ToString();

                    if ((SeleccionarPrimero) && pComboBox.Items.Count > 0)
                        pComboBox.SelectedIndex = 0;
                }
            }
        }

        public void EjecutarProcedimientoReturnComboBox(ComboBox pComboBox, bool SeleccionarPrimero, string NombreProcedimiento)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);

                try
                {
                    pComboBox.Items.Clear();
                }
                catch
                {
                    pComboBox.DataSource = null;
                }

                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                {
                    pComboBox.DataSource = Resultado.Tables[0];
                    pComboBox.ValueMember = Resultado.Tables[0].Columns["VALUE MEMBER"].ToString();
                    pComboBox.DisplayMember = Resultado.Tables[0].Columns["DISPLAY MEMBER"].ToString();

                    if ((SeleccionarPrimero) && pComboBox.Items.Count > 0)
                        pComboBox.SelectedIndex = 0;
                }
            }
        }






        public void EjecutarProcedimientoReturnComboBox(DataGridViewComboBoxColumn pComboBox, bool SeleccionarPrimero, string NombreProcedimiento)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);

                try
                {
                    pComboBox.Items.Clear();
                }
                catch
                {
                    pComboBox.DataSource = null;
                }

                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                {
                    pComboBox.DataSource = Resultado.Tables[0];
                    pComboBox.ValueMember = Resultado.Tables[0].Columns["VALUE MEMBER"].ToString();
                    pComboBox.DisplayMember = Resultado.Tables[0].Columns["DISPLAY MEMBER"].ToString();

                    //if ((SeleccionarPrimero) && pComboBox.Items.Count > 0)
                    //    pComboBox.SelectedIndex = 0;
                }
            }
        }






        public void EjecutarProcedimientoReturnListBox(ListBox pListBox, bool SeleccionarPrimero, string NombreProcedimiento)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);

                try
                {
                    pListBox.Items.Clear();
                }
                catch
                {
                    pListBox.DataSource = null;
                }

                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                {
                    pListBox.DataSource = Resultado.Tables[0];
                    pListBox.ValueMember = Resultado.Tables[0].Columns["VALUE MEMBER"].ToString();
                    pListBox.DisplayMember = Resultado.Tables[0].Columns["DISPLAY MEMBER"].ToString();

                    if ((SeleccionarPrimero) && pListBox.Items.Count > 0)
                        pListBox.SelectedIndex = 0;
                }
            }
        }



        public string EjecutarProcedimientoReturnMensaje(string NombreProcedimiento, object[] ParamNames, object[] ParamValues)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                int NroParametros = ParamNames.Length;
                for (int i = 0; i < NroParametros; i++)
                    aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamNames[i], ParamValues[i]);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                string mensaje = "NO SE RETORNO NINGUN MENSAJE";
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Resultado.Tables[0].Rows[0][0].ToString();
                return mensaje;
            }
        }

        public string EjecutarProcedimientoReturnMensaje(string NombreProcedimiento, object ParamName, object ParamValue)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamName, ParamValue);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                string mensaje = "NO SE RETORNO NINGUN MENSAJE";
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Resultado.Tables[0].Rows[0][0].ToString();
                return mensaje;
            }
        }



        /// <summary>
        /// PROCEDIMIENTO QUE DEVUELVE UN ENTERO, ASIGNANDO ARREGLOS DE PARAMETROS Y VALORES RESPECTIVAMENTE 
        /// </summary>
        /// <param name="NombreProcedimiento">NOMBRE DEL PROCEDIMIENTO</param>
        /// <param name="ParamNames">PARAMETROS (NOMBRES)</param>
        /// <param name="ParamValues">VALORES DE LOS PARAMETROS</param>
        /// <returns></returns>
        public int EjecutarProcedimientoReturnEntero(string NombreProcedimiento, object[] ParamNames, object[] ParamValues)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                int NroParametros = ParamNames.Length;
                for (int i = 0; i < NroParametros; i++)
                    aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamNames[i], ParamValues[i]);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                int mensaje = 0;
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Convert.ToInt32(Resultado.Tables[0].Rows[0][0]);
                return mensaje;
            }
        }

        //---------------FIN ..................///

        /// <summary>
        /// PROCEDIMIENTO QUE DEVUELVE UN ENTERO, ASIGNANDO UN PARAMETRO Y UN VALORE
        /// </summary>
        /// <param name="NombreProcedimiento">NOMBRE DEL PROCEDIMIENTO</param>
        /// <param name="ParamName">NOMBRE DEL PARAMETRO</param>
        /// <param name="ParamValue">VALOR DEL PROCEDIMIENTO</param>
        /// <returns></returns>
        public int EjecutarProcedimientoReturnEntero(string NombreProcedimiento, object ParamName, object ParamValue)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamName, ParamValue);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                int mensaje = 0;
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Convert.ToInt32(Resultado.Tables[0].Rows[0][0]);
                return mensaje;
            }
        }
        /*------------FIN------------------*/






        public string EjecutarProcedimientoReturnMensaje(string NombreProcedimiento)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
                string mensaje = "NO SE RETORNO NINGUN MENSAJE";
                if (Resultado != null && Resultado.Tables != null && Resultado.Tables[0] != null && Resultado.Tables[0].Rows != null)
                    mensaje = Resultado.Tables[0].Rows[0][0].ToString();
                return mensaje;
            }
        }







        public void EjecutarProcedimientoReturnVoid(string NombreProcedimiento, object[] ParamNames, object[] ParamValues)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                int NroParametros = ParamNames.Length;
                for (int i = 0; i < NroParametros; i++)
                    aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamNames[i], ParamValues[i]);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            }
        }

        public void EjecutarProcedimientoReturnVoid(string NombreProcedimiento, object ParamName, object ParamValue)
        {
            using (DataSet Resultado = new DataSet())
            {
                aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
                aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                aAdaptador.SelectCommand.Parameters.AddWithValue("?" + ParamName, ParamValue);
                aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            }
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado y lo devuelve en un data set
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <returns></returns>
        public DataSet EjecutarProcedimientoReturnDataSet(string NombreProcedimiento)
        {
            DataSet Resultado = new DataSet();
            aAdaptador = new MySqlDataAdapter(NombreProcedimiento, aConexionBD);
            aAdaptador.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            aAdaptador.Fill(Resultado, "ta" + NombreProcedimiento);
            return Resultado;
        }



















        /// <summary>
        /// Este procedimiento guarda datos haciendo uso de procedimientos almacenados
        /// puede ser insercion,modificacion o eliminacion segun lo que haga el procedimiento
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// Aca se envia el nombre del procedimiento almacenado
        /// <param name="Parametros"></param>
        /// Aca se envia un arraylist cuyos elementos son arreglos de dos elementos
        /// el primer elemento debe ser el nombre del parametro
        /// el segundo el valor del parametro
        public void EjecutarProcedimientoReturnVoid(string NombreProcedimiento, ArrayList Parametros)
        {
            aComando = new MySqlCommand();
            aComando.CommandText = NombreProcedimiento;
            aComando.CommandType = CommandType.StoredProcedure;

            object[] ParametroElem;
            int NroParametros = Parametros.Count;

            for (int i = 0; i < NroParametros; i++)
            {
                ParametroElem = (object[])(Parametros[i]);
                aComando.Parameters.AddWithValue("?" + ParametroElem[0], ParametroElem[1]);
            }

            aComando.Connection = aConexionBD;
            int N = aComando.ExecuteNonQuery();
        }

        public string FechaFormatoMySQL(string fecha, int tipo)
        {
            string Fecha = "";
            string fe = "";
            string time = "";
            int Dis = fecha.Length;
            if (Dis > 10)
                Dis = 10;
            fe = fecha.Substring(0, Dis);
            string[] DatosFecha = fe.Split("/".ToCharArray());

            if (tipo == 1)
            {
                Fecha = DatosFecha[2].ToString().Substring(0, 4) + "-" + DatosFecha[1] + "-" + DatosFecha[0];
            }
            else
            {
                time = fecha.Substring(10);
                Fecha = DatosFecha[2].ToString().Substring(0, 4) + "-" + DatosFecha[1] + "-" + DatosFecha[0] + " " + time;
            }
            return Fecha;
        }

        public string FechaFormatoMySQL(DateTime dtfecha, int ConTiempo)
        {
            string Fecha = "";
            if (ConTiempo == 0)
            {
                Fecha = dtfecha.Year.ToString() + "-" + dtfecha.Month.ToString() + "-" + dtfecha.Day.ToString();
            }
            else
            {
                Fecha = Fecha = dtfecha.Year.ToString() + "-" + dtfecha.Month.ToString() + "-" + dtfecha.Day.ToString() + " " + dtfecha.Hour.ToString() + ":" + dtfecha.Minute.ToString() + ":" + dtfecha.Second.ToString();
            }
            return Fecha;
        }

        public ArrayList LLenarParametros(ArrayList Parametros, string NombreParametro, string ValorParametro)
        {
            ArrayList ListaParametros = Parametros;
            string[] Parametro = { NombreParametro, ValorParametro };
            ListaParametros.Add(Parametro);
            return ListaParametros;
        }

        public ArrayList LLenarParametros(ArrayList Parametros, string NombreParametro, object ValorParametro)
        {
            ArrayList ListaParametros = Parametros;
            string[] Parametro = { NombreParametro, ValorParametro.ToString() };
            ListaParametros.Add(Parametro);
            return ListaParametros;
        }

        public ArrayList LLenarParametros(ArrayList Parametros, string NombreParametro, byte[] ValorParametro)
        {
            ArrayList ListaParametros = Parametros;
            object[] Parametro = { NombreParametro, ValorParametro };
            ListaParametros.Add(Parametro);
            return ListaParametros;
        }

        public ArrayList LLenarParametros(ArrayList Parametros, string NombreParametro, double ValorParametro)
        {
            ArrayList ListaParametros = Parametros;
            // Hallamos el separador de decimales y de millares, el de millares lo quitamos y el de decimales le damos punto
            string SeparadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string SeparadorMillares = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;

            string NumeroDecimal = ValorParametro.ToString();
            NumeroDecimal = NumeroDecimal.Replace(SeparadorMillares, "");
            NumeroDecimal = NumeroDecimal.Replace(SeparadorDecimal, ".");
            string[] Parametro = { NombreParametro, NumeroDecimal.Trim() };
            ListaParametros.Add(Parametro);
            return ListaParametros;
        }
        public string NumeroFormatoMySQl(decimal NumeroDecimalN)
        {
            string SeparadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string SeparadorMillares = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;

            string NumeroDecimal = NumeroDecimalN.ToString();
            NumeroDecimal = NumeroDecimal.Replace(SeparadorMillares, "");
            NumeroDecimal = NumeroDecimal.Replace(SeparadorDecimal, ".");

            return NumeroDecimal;
        }
        public DateTime FormatoVisualNet(string Fecha)
        {
            object[] FechaActual = Fecha.Split('/');
            int Dia = DateTime.Now.Day;
            int Mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;

            int.TryParse(FechaActual[0].ToString(), out Dia);
            int.TryParse(FechaActual[1].ToString(), out Mes);
            int.TryParse(FechaActual[2].ToString().Substring(0, 4), out anio);

            DateTime FechaActualizacion = new DateTime(anio, Mes, Dia);
            return FechaActualizacion;
        }


        public byte[] Image2Bytes(Image img)
        {
            img = RedimensionarImagen(img);

            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            // Cerrarlo y volverlo a abrir
            // o posicionarlo en el primer byte
            //fs.Close();
            //fs = new FileStream(sTemp, FileMode.Open, FileAccess.Read);
            fs.Position = 0;
            //
            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;
            //
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }


        public Image RedimensionarImagen(Image Img)
        {
            int nWidth = Img.Width;
            int nHeight = Img.Height;

            if (nHeight > 100 || nWidth > 100)
            {
                float Factor = (float)(((double)Math.Max(nWidth, nHeight)) / 100.0);
                nWidth = (int)(nWidth / Factor);
                nHeight = (int)(nHeight / Factor);

                Bitmap b = new Bitmap(nWidth, nHeight);
                Graphics g = Graphics.FromImage((Image)b);

                g.DrawImage(Img, 0, 0, nWidth, nHeight);
                g.Dispose();

                return (Image)b;
            }
            else
                return Img;

        }

        public object[] RecuperarDatosEnArregloUnaFila(string NombreProcedimiento, object[] ParametrosNames, object[] ParametrosValues)
        {
            DataSet dsAuxiliar = EjecutarProcedimientoReturnDataSet(NombreProcedimiento, ParametrosNames, ParametrosValues);
            object[] Respuesta = { "LA CONSULTA NO GENERO NINGUN RESULTADO" };

            if (dsAuxiliar.Tables.Count > 0)
            {
                int NroColumnas = dsAuxiliar.Tables[0].Columns.Count;
                int NroFilas = dsAuxiliar.Tables[0].Rows.Count;

                for (int i = 0; i < NroFilas; i++)
                {
                    Respuesta = new object[NroColumnas];
                    for (int j = 0; j < NroColumnas; j++)
                    {
                        Respuesta[j] = dsAuxiliar.Tables[0].Rows[i][j];
                    }
                }
            }

            return Respuesta;
        }







        //--------procedimiento para obtener un dato entero.-------------------
        /// <summary>
        /// Funsion para obtener un entero
        /// </summary>
        /// <param name="NombreProcedimiento">Procedimiento</param>
        /// <param name="ParametrosNames">Nombre del parametro</param>
        /// <param name="ParametrosValues">Valor del parametro</param>
        /// <returns></returns>
        public object[] RecuperaDatoVacaciones(string NombreProcedimiento, object ParametrosNames, object ParametrosValues)
        {
            DataSet dsAuxiliar = EjecutarProcedimientoReturnDataSet(NombreProcedimiento, ParametrosNames, ParametrosValues);
            object[] Respuesta = { 0 };

            if (dsAuxiliar.Tables.Count > 0)
            {
                int NroColumnas = dsAuxiliar.Tables[0].Columns.Count;
                int NroFilas = dsAuxiliar.Tables[0].Rows.Count;

                for (int i = 0; i < NroFilas; i++)
                {
                    Respuesta = new object[NroColumnas];
                    for (int j = 0; j < NroColumnas; j++)
                    {
                        Respuesta[j] = dsAuxiliar.Tables[0].Rows[i][j];
                    }
                }
            }

            return Respuesta;
        }

        //---------------------fin ------------------------








        public object[] RecuperarDatosEnArregloUnaFila(string NombreProcedimiento, object ParametroName, object ParametroValue)
        {
            DataSet dsAuxiliar = EjecutarProcedimientoReturnDataSet(NombreProcedimiento, ParametroName, ParametroValue);
            object[] Respuesta = { "LA CONSULTA NO GENERO NINGUN RESULTADO" };

            if (dsAuxiliar.Tables.Count > 0)
            {
                int NroColumnas = dsAuxiliar.Tables[0].Columns.Count;
                int NroFilas = dsAuxiliar.Tables[0].Rows.Count;

                for (int i = 0; i < NroFilas; i++)
                {
                    Respuesta = new object[NroColumnas];
                    for (int j = 0; j < NroColumnas; j++)
                    {
                        Respuesta[j] = dsAuxiliar.Tables[0].Rows[i][j];
                    }
                }
            }

            return Respuesta;
        }


        public object[] RecuperarDatosEnArregloUnaFila(string NombreProcedimiento)
        {
            DataSet dsAuxiliar = EjecutarProcedimientoReturnDataSet(NombreProcedimiento);
            object[] Respuesta = { "LA CONSULTA NO GENERO NINGUN RESULTADO" };

            if (dsAuxiliar.Tables.Count > 0)
            {
                int NroColumnas = dsAuxiliar.Tables[0].Columns.Count;
                int NroFilas = dsAuxiliar.Tables[0].Rows.Count;

                for (int i = 0; i < NroFilas; i++)
                {
                    Respuesta = new object[NroColumnas];
                    for (int j = 0; j < NroColumnas; j++)
                    {
                        Respuesta[j] = dsAuxiliar.Tables[0].Rows[i][j];
                    }
                }
            }

            return Respuesta;
        }

        public DataSet RecuperarTabla(string sentenciasql)
        {
            DataSet Resultado = new DataSet();
            aAdaptador = new MySqlDataAdapter(sentenciasql, aConexionBD);
            aComando = new MySqlCommand(sentenciasql);

            aAdaptador.Fill(Resultado);
            return Resultado;
        }















    }
}
