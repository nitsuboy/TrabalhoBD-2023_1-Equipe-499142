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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TBD_Biblioteca
{
    public partial class Consulta : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();

        public Consulta()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
            }
            catch
            {
                MessageBox.Show("falha ao conectar ao banco de dados");
            }
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            DataTable livros = new DataTable(); 
            try
            {
                cmd.CommandText = "SELECT * FROM livros";
                MySqlDataReader dados = cmd.ExecuteReader();
                livros.Load(dados);
                dados.Close();
                dataGridView1.DataSource= livros;   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
