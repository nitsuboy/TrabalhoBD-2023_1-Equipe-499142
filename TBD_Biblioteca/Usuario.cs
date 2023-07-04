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
    public partial class Usuario : Form
    {
        Form livros = new Consulta_livros_usuario();
        public Usuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var livros = new Consulta_livros_usuario();
            livros.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var professores = new Consulta_professores_usuario();
            professores.ShowDialog();
        }
    }
}
