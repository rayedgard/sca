using clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asistencia
{
    public partial class frmCiudades : Form
    {
      
        CConection ConexionBD;
        CValidacion ValidarDatos;
        private string IdPaisActual = "0";
        private string IdUbicacionActual = "PERU";
        private int AgregarEditarOEliminar = 1; //toma valores 1,2 o 3
        private int PaisDptoProvODistrito = 1; // toma valores 1,2,3,4
        string string_ArchivoConfiguracion;
        public frmCiudades(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ConexionBD = new CConection();
            ValidarDatos = new CValidacion();
            ListarPaisesExistentes();
        }

        public void ListarPaisesExistentes()
        {
            //Cargar dagencias
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            DataSet PaisesDptosCiudades = ConexionBD.EjecutarProcedimientoReturnDataSet("spugeo_ListarPaisesyCiudades");
            object[] ValoresFila = new object[8];

            string ClavePais = "";
            string ClaveDpto = "";
            string ClaveProv = "";
            string ClaveDist = "";
            tvPaisesDptos.Nodes.Clear();

            if (PaisesDptosCiudades.Tables[0].Rows.Count >= 1)
            {
                for (int i = 0; i < PaisesDptosCiudades.Tables[0].Rows.Count; i++)
                {
                    ClavePais = PaisesDptosCiudades.Tables[0].Rows[i][0].ToString();
                    if (PaisesDptosCiudades.Tables[0].Rows[i][0] != null)
                        ClaveDpto = PaisesDptosCiudades.Tables[0].Rows[i][2].ToString();
                    else
                        ClaveDpto = "";

                    if (PaisesDptosCiudades.Tables[0].Rows[i][4] != null)
                        ClaveProv = PaisesDptosCiudades.Tables[0].Rows[i][4].ToString();
                    else
                        ClaveProv = "";

                    if (PaisesDptosCiudades.Tables[0].Rows[i][6] != null)
                        ClaveDist = PaisesDptosCiudades.Tables[0].Rows[i][6].ToString();
                    else
                        ClaveDist = "";

                    if (ClavePais.Trim() != "" && tvPaisesDptos.Nodes[ClavePais] == null)
                    {
                        tvPaisesDptos.Nodes.Add(ClavePais, PaisesDptosCiudades.Tables[0].Rows[i][1].ToString());
                    }

                    if (ClavePais.Trim() != "" && ClaveDpto.Trim() != "" && tvPaisesDptos.Nodes[ClavePais].Nodes[ClaveDpto] == null)
                    {
                        tvPaisesDptos.Nodes[ClavePais].Nodes.Add(ClaveDpto, PaisesDptosCiudades.Tables[0].Rows[i][3].ToString());
                    }

                    if (ClavePais.Trim() != "" && ClaveDpto.Trim() != "" && ClaveProv.Trim() != "" && tvPaisesDptos.Nodes[ClavePais].Nodes[ClaveDpto].Nodes[ClaveProv] == null)
                    {
                        tvPaisesDptos.Nodes[ClavePais].Nodes[ClaveDpto].Nodes.Add(ClaveProv, PaisesDptosCiudades.Tables[0].Rows[i][5].ToString());
                    }

                    if (ClavePais.Trim() != "" && ClaveDpto.Trim() != "" && ClaveProv.Trim() != "" && ClaveDist.Trim() != "" && tvPaisesDptos.Nodes[ClavePais].Nodes[ClaveDpto].Nodes[ClaveProv].Nodes[ClaveDist] == null)
                    {
                        tvPaisesDptos.Nodes[ClavePais].Nodes[ClaveDpto].Nodes[ClaveProv].Nodes.Add(ClaveDist, PaisesDptosCiudades.Tables[0].Rows[i][7].ToString());
                    }

                }
            }
            ConexionBD.Desconectar();
            // tvPaisesDptos.ExpandAll();
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreAgencia.Text.Trim() != "")
            {

                AgregarEditarOEliminar = 4;
                PaisDptoProvODistrito = 1;
                IdUbicacionActual = "PERU";
                GuardarDatosPaisDptoProvincia(tbNombreAgencia.Text);
                tbNombreAgencia.Text = "";
            }
        }



        private void GuardarDatosPaisDptoProvincia(string pNuevoNombre)
        {
            ConexionBD.Conectar(true, string_ArchivoConfiguracion);
            bool Seguardo = false;
            try
            {
                object[] NombresVariables = { "pEditarEliminarAgregar", "pUbicacionClave", "pNombreUbicacion", "pNuevoNombre" };
                IdUbicacionActual = IdUbicacionActual.Replace("//", "|");
                object[] Valores = { AgregarEditarOEliminar, PaisDptoProvODistrito, IdUbicacionActual.Replace("/", "|"), pNuevoNombre };
                ConexionBD.EjecutarProcedimientoReturnVoid("spugeo_ModificarAgegarEliminarCiudadesPaises", NombresVariables, Valores);
                ConexionBD.COMMIT();
                Seguardo = true;
            }
            catch (Exception ex)
            {
                ConexionBD.ROLLBACK();
                Seguardo = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.Desconectar();
            }

            if (Seguardo)
            {
                MessageBox.Show("DATOS GUARDADOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosAgregarPaisDptoProvincia();
                ListarPaisesExistentes();
            }
            else
                MessageBox.Show("HUBO UN ERROR AL GUARDAR LOS DATOS, INTENTELO NUEVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void LimpiarDatosAgregarPaisDptoProvincia()
        {
            tbNombreAgencia.Text = "";
        }

        private void tvPaisesDptos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                lbOperacion.Text = "Añadir Departamentos";
                tbNombreUbicacion.Text = "";
                PaisDptoProvODistrito = 1;
                AgregarEditarOEliminar = 3;
                cmsMenuOpcionesPaises.Show(tvPaisesDptos, PuntoClick);

            }
            else
            {
                if (e.Node.Parent.Level == 0)
                {

                    lbOperacion.Text = "Añadir Provincias";
                    tbNombreUbicacion.Text = "";
                    PaisDptoProvODistrito = 2;
                    AgregarEditarOEliminar = 3;
                    cmsMenuOpcionesDptos.Show(tvPaisesDptos, PuntoClick);
                }
                else
                    if (e.Node.Parent.Level == 1)
                    {

                        lbOperacion.Text = "Añadir Distritos";
                        tbNombreUbicacion.Text = "";
                        PaisDptoProvODistrito = 3;
                        AgregarEditarOEliminar = 3;
                        cmsMenuOpcionesProv.Show(tvPaisesDptos, PuntoClick);
                    }
                    else
                    {

                        lbOperacion.Text = "Editar Distrito";
                        tbNombreUbicacion.Text = e.Node.Text;
                        PaisDptoProvODistrito = 4;
                        AgregarEditarOEliminar = 1;
                        cmsMenuOpcionesDist.Show(tvPaisesDptos, PuntoClick);
                    }
            }
            // mostrar la ubicacion actual
            lbUbicacionActual.Text = e.Node.FullPath;
            IdUbicacionActual = e.Node.FullPath;
        }


        Point PuntoClick;

        private void tvPaisesDptos_MouseUp(object sender, MouseEventArgs e)
        {
            //' Show menu only if Right Mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                PuntoClick = new Point(e.X, e.Y);
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (tbNombreUbicacion.Text.Trim() != "")
            {
                GuardarDatosPaisDptoProvincia(tbNombreUbicacion.Text);
            }
        }

        private void cmsMenuOpcionesPaises_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Trim().ToUpper() == "AGREGAR DEPARTAMENTOS")
            {
                AgregarEditarOEliminar = 3;
                tbNombreAgencia.Text = "";
                tbNombreUbicacion.Focus();
                tbNombreUbicacion.Select();
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "EDITAR PAIS")
            {
                AgregarEditarOEliminar = 1;
                tbNombreAgencia.Text = IdUbicacionActual;

                tipo = Tipo.modificar1;
                habilitaBoton();
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "ELIMINAR PAIS")
            {
                AgregarEditarOEliminar = 2;
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este pais? \r\n El Pais no se eliminara si no hay otro con quien reemplazarlo para los datos de agencia y persona", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GuardarDatosPaisDptoProvincia(tbNombreUbicacion.Text);
                    lbUbicacionActual.Text = "PAIS/DEPARTAMENTO/PROVINCIA/DISTRITO";
                    lbOperacion.Text = "Nombre de Ubicacion";

                    tipo = Tipo.eliminar;
                    habilitaBoton();
                }
            }

        }

        private void cmsMenuOpcionesDptos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Trim().ToUpper() == "AGREGAR PROVINCIAS")
            {
                AgregarEditarOEliminar = 3;
                tbNombreUbicacion.Text = "";

                tbNombreUbicacion.Focus();
                tbNombreUbicacion.Select();

            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "EDITAR DEPARTAMENTO")
            {
                AgregarEditarOEliminar = 1;
                tbNombreUbicacion.Text = tvPaisesDptos.SelectedNode.Text;

                
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "ELIMINAR DEPARTAMENTO")
            {
                AgregarEditarOEliminar = 2;
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este departamento? \r\n El Departamento no se eliminara si no hay otro con quien reemplazarlo para los datos de agencia y persona", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GuardarDatosPaisDptoProvincia(tbNombreUbicacion.Text);
                    lbUbicacionActual.Text = "PAIS/DEPARTAMENTO/PROVINCIA/DISTRITO";
                    lbOperacion.Text = "Nombre de Ubicacion";

                    tipo = Tipo.eliminar;
                    habilitaBoton();
                }
            }
        }

        private void cmsMenuOpcionesProv_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Trim().ToUpper() == "AGREGAR DISTRITOS")
            {
                AgregarEditarOEliminar = 3;
                tbNombreUbicacion.Text = "";

                tbNombreUbicacion.Focus();
                tbNombreUbicacion.Select();
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "EDITAR PROVINCIA")
            {
                AgregarEditarOEliminar = 1;
                tbNombreUbicacion.Text = tvPaisesDptos.SelectedNode.Text;
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "ELIMINAR PROVINCIA")
            {
                AgregarEditarOEliminar = 2;
                if (MessageBox.Show("¿Esta seguro que quiere eliminar esta provincia? \r\n La provincia no se eliminara si no hay otro con quien reemplazarlo para los datos de agencia y persona", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GuardarDatosPaisDptoProvincia(tbNombreUbicacion.Text);
                    lbUbicacionActual.Text = "PAIS/DEPARTAMENTO/PROVINCIA/DISTRITO";
                    lbOperacion.Text = "Nombre de Ubicacion";

                    tipo = Tipo.eliminar;
                    habilitaBoton();

                }
            }
        }

        private void cmsMenuOpcionesDist_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Trim().ToUpper() == "EDITAR DISTRITO")
            {
                AgregarEditarOEliminar = 1;
                tbNombreUbicacion.Text = tvPaisesDptos.SelectedNode.Text;
            }
            if (e.ClickedItem.Text.Trim().ToUpper() == "ELIMINAR DISTRITO")
            {
                AgregarEditarOEliminar = 2;
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este distrito? \r\n El distrito no se eliminara si no hay otro con quien reemplazarlo para los datos de agencia y persona", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GuardarDatosPaisDptoProvincia(tbNombreUbicacion.Text);
                    lbUbicacionActual.Text = "PAIS/DEPARTAMENTO/PROVINCIA/DISTRITO";
                    lbOperacion.Text = "Nombre de Ubicacion";

                    tipo = Tipo.eliminar;
                    habilitaBoton();
                }
            }
        }





        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar1, guardar2, modificar1, modificar2, eliminar
        }
        private Tipo tipo;




        private void habilitaBoton()
        {
            btnGuardar1.Enabled = tipo == Tipo.guardar1 || tipo == Tipo.modificar1;
            btnGuardar2.Enabled = tipo == Tipo.guardar2 || tipo == Tipo.modificar2;
            


        }
        #endregion

        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            ((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

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



        
        #endregion

        private void tbNombreAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {

            tipo = Tipo.guardar1;
            habilitaBoton();
         
        }

        private void tbNombreUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            tipo = Tipo.guardar2;
            habilitaBoton();
        }



    }
}
