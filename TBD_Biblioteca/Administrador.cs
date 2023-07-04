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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        private void adm_AdmLivrosButton_Click(object sender, EventArgs e)
        {
            Form AdministrarLivros = new Consulta_livros_adm();
            AdministrarLivros.ShowDialog();
        }
        private void adm_AdmAlunosButton_Click(object sender, EventArgs e)
        {
            //Form AdministrarAlunos = new Consulta_alunos_adm();
            //AdministrarAlunos.ShowDialog();
        }
        private void adm_AdmProfessoresButton_Click(object sender, EventArgs e)
        {
            //Form AdministrarProfessores = new Consulta_professores_adm();
            //AdministrarProfessores.ShowDialog();
        }
    }
}
