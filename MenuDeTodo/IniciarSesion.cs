using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDeTodo
{
    public partial class IniciarSesion : Form
    {
        Validacion vi = new Validacion();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Iniciaste sesión!\n Con el correo: "+textBoxCorreo.Text+"\n y contraseña: "+textBoxContraseña.Text);
            Close();
        }

        private void btnOlvidasteCorreoOContra_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            labelNuevoCorreo.Visible = true;
            textBoxNuevoCorreo.Visible = true;
            labelNuevaContraseña.Visible = true;
            textBoxNuevaContraseña.Visible = true;
            btnIngresar2.Visible = true;
        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Iniciaste sesión!\n Con el nuevo correo: " + textBoxNuevoCorreo.Text+ "\n y nueva contraseña: " +textBoxNuevaContraseña.Text);
            Close();
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            vi.Letras(e);
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            vi.numeros(e);
        }

        private void textBoxNuevoCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            vi.Letras(e);
        }

        private void textBoxNuevaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            vi.numeros(e);
        }
    }
}
