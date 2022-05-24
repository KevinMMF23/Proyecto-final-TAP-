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
    public partial class MenuDeTodo : Form
    {
        public MenuDeTodo()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WF2.MenuCompras m = new WF2.MenuCompras();
            m.Show();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WF1.MenuInicio me = new WF1.MenuInicio();
           me.Show();
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRACTICA_4.Tabla ta = new PRACTICA_4.Tabla();
            ta.Show();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRACTICA_3.Grafica g = new PRACTICA_3.Grafica();
            g.Show();
        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion i = new IniciarSesion();
            i.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuDeTodo_Load(object sender, EventArgs e)
        {

        }

        private void registrarDomicilioDistintoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrarse r = new Registrarse();
            r.Show();
        }

        private void cerrarTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void internasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
