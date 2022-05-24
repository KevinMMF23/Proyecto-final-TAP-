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
    public partial class Registrarse : Form
    {
        Validacion vr = new Validacion();
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("¡El nuevo domicilio ha sido agregado a tu cuenta\n¡"+"Ciudad: "+textBoxCiudad.Text+"\n"
                +"Domicilio: "+textBoxDireccion.Text+"\n"+"Codigo postal: "+textBoxCodigoPostal.Text+"\n"+"Número exterior: "
                +textBoxNumeroExterior.Text);
            Close();
        
        }

        private void textBoxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            vr.Letras(e);
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            vr.Letras(e);
        }

        private void textBoxCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            vr.numeros(e);
        }

        private void textBoxNumeroExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            vr.numeros(e);
        }
    }
}
