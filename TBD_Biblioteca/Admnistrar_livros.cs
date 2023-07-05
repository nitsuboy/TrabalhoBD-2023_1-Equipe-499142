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
    public partial class Admnistrar_livros : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable livros = new DataTable();
        public Admnistrar_livros()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM livros";
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
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM livros";
            MySqlDataReader dados = cmd.ExecuteReader();
            livros.Clear();
            livros.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = livros;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM livros WHERE isbn = @isbn";
                cmd.Parameters.AddWithValue("@isbn", textBox1.Text);
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
            var row = dataGridView1.SelectedRows[0];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText =
                    "INSERT INTO livros (isbn, titulo, anodelancamento, editora, quancopias, categoria_codcategoria) " +
                    "VALUES (@isbn, @titulo, @anodelancamento, @editora, @quancopias, @categoria_codcategoria);";

                cmd.Parameters.AddWithValue("@isbn", textBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", textBox2.Text);
                cmd.Parameters.AddWithValue("@anodelancamento", textBox3.Text);
                cmd.Parameters.AddWithValue("@editora", textBox4.Text);
                cmd.Parameters.AddWithValue("@quancopias", textBox5.Text);
                cmd.Parameters.AddWithValue("@categoria_codcategoria", textBox6.Text);
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
                cmd.CommandText = "UPDATE livros SET " +
                    "isbn=@isbn, titulo=@titulo, anodelancamento=@anodelancamento, editora=@editora, quancopias=@quancopias, categoria_codcategoria=@categoria_codcategoria" +
                    " WHERE isbn = @isbn";
                cmd.Parameters.AddWithValue("@isbn", textBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", textBox2.Text);
                cmd.Parameters.AddWithValue("@anodelancamento", textBox3.Text);
                cmd.Parameters.AddWithValue("@editora", textBox4.Text);
                cmd.Parameters.AddWithValue("@quancopias", textBox5.Text);
                cmd.Parameters.AddWithValue("@categoria_codcategoria", textBox6.Text);
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
