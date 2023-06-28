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
        Form livros = new Consulta();
        Form alugue = new Form4();
        public Usuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var livros = new Consulta();
            livros.ShowDialog();
        }
    }
}
