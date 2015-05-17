using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace clases
{
    public class CValidacion
    {





        #region ******************* ATRIBUTOS **************************
        //==============================================================
        public System.Windows.Forms.TextBox aTexto;
        public System.Windows.Forms.RadioButton aRadio;
        public System.Windows.Forms.ListBox aLista;
        public System.Windows.Forms.DataGridView aGrid;
        public System.Windows.Forms.TabControl aTabControl;
        public string string_aValorControl;
        //==============================================================
        #endregion ******************* ATRIBUTOS ***********************

        #region ******************* PROPIEDADES ************************
        //============================================================== 
        public CValidacion()
        {
            aTexto = null;
            aRadio = null;
            aLista = null;
            aGrid = null;
            aTabControl = null;
            string_aValorControl = string.Empty;
        }

        //==============================================================
        #endregion ******************* CONSTRUCTOR *********************

        #region ******************* METODOS ****************************
        //==============================================================

        public void texto_KeyPress(string st_ValorTexto, string valor, object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (valor == "string")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                /* else if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9'))
                 {|| (Char.IsSymbol(e.KeyChar))
                     e.Handled = true;
                 }*/
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            if (valor == "int")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                /* else if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9'))
                 {
                     e.Handled = true;
                 }*/

            }


            if (valor == "TipoIP")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                if (st_ValorTexto.Contains(".."))
                {
                    e.Handled = true;
                }
                /* else if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9'))
                 {
                     e.Handled = true;
                 }*/

            }

            if (valor == "LetrasNumeros")
            {
                e.Handled = true;
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 'Ñ' || e.KeyChar == 'ñ')
                {
                    e.Handled = false;
                }
            }

            if (valor == "LetrasNumerosEspacio")
            {
                e.Handled = true;
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                {
                    e.Handled = false;
                }
                if (e.KeyChar == ' ' || e.KeyChar == 'Ñ' || e.KeyChar == 'ñ')
                {
                    e.Handled = false;
                }
            }

            if (valor == "LetrasNumerosEspacioGuion")
            {
                e.Handled = true;
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                {
                    e.Handled = false;
                }
                if (e.KeyChar == ' ' || e.KeyChar == 'Ñ' || e.KeyChar == 'ñ')
                {
                    e.Handled = false;
                }

                if (e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == ':')
                {
                    e.Handled = false;
                }
            }

            if (valor == "LetrasEspacio")
            {
                e.Handled = true;
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                {
                    e.Handled = false;
                }
                if (e.KeyChar == ' ' || e.KeyChar == 'Ñ' || e.KeyChar == 'ñ')
                {
                    e.Handled = false;
                }
            }

            if (valor == "Numeros")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }

            }
            if (valor == "decimal")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                /*if (Char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
               
              /* if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9'))
                {
                    e.Handled = true;
                }*/
                if (e.ToString() == "-" || e.ToString() == "+" || e.ToString() == "!" || e.ToString() == "_" || e.ToString() == ":" || e.ToString() == ":")
                {
                    e.Handled = true;
                }
                if (e.ToString() == ".")
                {
                    e.Handled = false;
                }
            }
            if (valor == "decimalpositivo")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && st_ValorTexto.Contains(".") == false && st_ValorTexto != "")
                {
                    e.Handled = false;
                }
            }
            if (valor == "decimalnegativo")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && st_ValorTexto.Contains(".") == false && st_ValorTexto != "")
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '-' && st_ValorTexto == "")
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

        }
        public void text_TextChanged(object sender, EventArgs e)
        {
            TextBox NumeroDecimal = (TextBox)(sender);
            string Numero = NumeroDecimal.Text;
            float NumeroFloat = 0;
            try
            {
                NumeroFloat = float.Parse(Numero);

            }
            catch
            {
                if (Numero.Length > 0)
                    Numero = Numero.Substring(0, Numero.Length - 1);
            }
            finally
            {
                NumeroDecimal.Text = Numero;
                NumeroDecimal.SelectionLength = 0;
                NumeroDecimal.SelectionStart = NumeroDecimal.Text.Length;
            }
        }
        public void dgv_CellValueChanged(object sender, EventArgs e, int columna, int fila)
        {
            try
            {
                DataGridView dgvCurva = (DataGridView)(sender);
                string Numero = dgvCurva[columna, fila].Value.ToString();
                float NumeroFloat = 0;
                try
                {
                    NumeroFloat = float.Parse(Numero);

                }
                catch
                {
                    if (Numero.Length > 0)
                        Numero = Numero.Substring(0, Numero.Length - 1);
                }
                finally
                {
                    dgvCurva[columna, fila].Value = Numero;
                    /* dgvCurva[columna, fila].Value.ToString().SelectionLength = 0;
                     dgvCurva[columna, fila].Value.SelectionStart = dgvCurva[columna, fila].Value.Text.Length;*/
                }
            }
            catch
            {
                MessageBox.Show(" THERE ARE EMPTY VALUES ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void verificasoloNumeros(object sender, KeyPressEventArgs e, ErrorProvider errControl)
        {
            TextBox NumeroDecimal = (TextBox)(sender);
            if (char.IsNumber(e.KeyChar))
            {
                errControl.SetError(NumeroDecimal, null);
            }
            else
            {
                errControl.SetError(NumeroDecimal, null);
                //verificar si caracter ingresado no corresponde a la tecla backspace
                if (e.KeyChar != (char)Keys.Back)
                {
                    errControl.SetError(NumeroDecimal, "Ingrese numeros");
                    //No aceptar el caracter ingresado
                    e.Handled = true;
                }
                else { errControl.SetError(NumeroDecimal, null); }
            }
        }
        public void verifcasoloLetra(object sender, KeyPressEventArgs e, ErrorProvider errControl)
        {
            TextBox Letra = (TextBox)(sender);
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                errControl.SetError(Letra, null);
            }
            else
            {
                //Verificar si el caracter ingresado no corresponde a la tecla backspace
                if (e.KeyChar != (char)Keys.Back)
                {
                    errControl.SetError(Letra, "Ingrese letras");
                    //No aceptar el caracter
                    e.Handled = true;
                }
                else { errControl.SetError(Letra, null); }
            }
        }
        public void ingresarCamposVacios(string st_nombre, object sender, ErrorProvider errControl)
        {
            TextBox cajaTexto = (TextBox)(sender);
            string Aux = cajaTexto.Text.Trim();
            if (Aux.Length == 0)
            {
                //Asignar error
                errControl.SetError(cajaTexto, string.Format("{0}: {1}", st_nombre, "Campo requerido"));
                cajaTexto.Focus();
            }
            else
                errControl.SetError(cajaTexto, null);
        }


        public bool EsTextoVacioOMenorLongitud(TextBox tbTexto, int Longitud)
        {
            if (tbTexto.Text.Trim() == "")
                return true;
            else
                if (tbTexto.Text.Trim().Length < Longitud)
                    return true;
                else
                    return false;
        }

        public bool EsTextoVacioOMenorLongitud(RichTextBox tbTexto, int Longitud)
        {
            if (tbTexto.Text.Trim() == "")
                return true;
            else
                if (tbTexto.Text.Trim().Length < Longitud)
                    return true;
                else
                    return false;
        }

        public bool ExisteSeleccion(ComboBox cbComboBox)
        {
            if ((cbComboBox.SelectedIndex >= 0) && (cbComboBox.SelectedItem != null))
                return true;
            else
                return false;
        }
        //==============================================================
        #endregion ******************* METODOS *************************
  





    }
}
