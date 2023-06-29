using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBD_Biblioteca
{
    public partial class Consulta_professores_adm : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();

        DataTable professores = new DataTable();
        public Consulta_professores_adm()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM professores";
                MySqlDataReader dados = cmd.ExecuteReader();
                professores.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = professores;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM professores";
            MySqlDataReader dados = cmd.ExecuteReader();
            professores.Clear();
            professores.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = professores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "DELETE FROM professores WHERE matsiape= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText =
                    "UPDATE professores" +
                    " SET " +
                    "nome= '" + textBox2.Text +
                    "', regimetrabalho= '" + textBox3.Text +
                    "', endereco= '" + textBox4.Text +
                    "', telefonecelular= '" + textBox5.Text +
                    "' WHERE matsiape= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
