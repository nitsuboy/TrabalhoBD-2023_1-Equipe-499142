using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD_Biblioteca
{
    public partial class Bilbiotecario : Form
    {
        public Bilbiotecario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var livros = new Consulta_livros_biblio();
            livros.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuarios = new Consulta_usuarios_biblio();
            usuarios.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var reservas = new Consulta_reservas_biblio();
            reservas.ShowDialog();
        }
    }
}
