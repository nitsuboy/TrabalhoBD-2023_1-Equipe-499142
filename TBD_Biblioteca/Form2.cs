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
    public partial class Form2 : Form
    {
        Form livros = new Form3();
        Form alugue = new Form4();
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var livros = new Form3();
            livros.ShowDialog();
        }
    }
}
