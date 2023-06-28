using MySql.Data.MySqlClient;
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
    public partial class Consulta_usuarios_biblio : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();
        public Consulta_usuarios_biblio()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable livros = new DataTable();
            try
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    cmd.CommandText = "SELECT * FROM usuarios";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM usuarios WHERE TipoUsuario = " + (comboBox1.SelectedIndex + 1);
                }
                MySqlDataReader dados = cmd.ExecuteReader();
                livros.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
