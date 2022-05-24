using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDeTodo
{
    internal class Validacion
    {
        public void numeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("SOLO NUMEROS");
                }
            }
            catch (Exception ex) { }
        }
        public void Letras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("SOLO LETRAS");
                }
            }
            catch (Exception ex) { }
        }
    }
}
