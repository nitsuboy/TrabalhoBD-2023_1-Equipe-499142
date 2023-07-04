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
        private void usuarios_b_Click(object sender, EventArgs e)
        {
            Form usuario = new Admnistrar_usuarios();
            usuario.ShowDialog();
        }

        private void alunos_b_Click(object sender, EventArgs e)
        {
            Form alunos = new Administrar_alunos();
            alunos.ShowDialog();
        }

        private void professores_b_Click(object sender, EventArgs e)
        {
            Form professores = new Administrar_professores();
            professores.ShowDialog();
        }

        private void funcionarios_b_Click(object sender, EventArgs e)
        {
            Form funcionarios = new Admnistrar_funcionarios();
            funcionarios.ShowDialog();
        }

        private void cursos_b_Click(object sender, EventArgs e)
        {
            Form cursos = new Admnistrar_cursos();
            cursos.ShowDialog();
        }

        private void livros_b_Click(object sender, EventArgs e)
        {
            Form livros = new Admnistrar_livros();
            livros.ShowDialog();
        }

        private void autores_b_Click(object sender, EventArgs e)
        {
            Form autores = new Admnistrar_autores();
            autores.ShowDialog();
        }

        private void categorias_b_Click(object sender, EventArgs e)
        {
            Form categorias = new Admnistrar_categorias();
            categorias.ShowDialog();
        }

        private void reservas_b_Click(object sender, EventArgs e)
        {
            Form reservas = new Admnistrar_reservas();
            reservas.ShowDialog();
        }
    }
}
