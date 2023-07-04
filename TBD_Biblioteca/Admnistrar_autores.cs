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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TBD_Biblioteca
{
    public partial class Admnistrar_autores : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable autores = new DataTable();
        public Admnistrar_autores()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM autores";
                MySqlDataReader dados = cmd.ExecuteReader();
                autores.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = autores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM autores";
            MySqlDataReader dados = cmd.ExecuteReader();
            autores.Clear();
            autores.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = autores;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM autores WHERE email = @email";
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.ExecuteNonQuery();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];

            textBox2.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText =
                    "INSERT INTO autores (email, nome, nacionalidade) " +
                    "VALUES (@email, @nome, @nacionalidade);";

                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@nacionalidade", textBox3.Text);
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
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "UPDATE autores SET " +
                    "email=@email, nome=@nome, nacionalidade=@nacionalidade WHERE email = @email";
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@nacionalidade", textBox3.Text);
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
