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
    public partial class Admnistrar_reservas : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable reservas = new DataTable();
        public Admnistrar_reservas()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM reservas";
                MySqlDataReader dados = cmd.ExecuteReader();
                reservas.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM reservas";
            MySqlDataReader dados = cmd.ExecuteReader();
            reservas.Clear();
            reservas.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = reservas;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM reservas WHERE usuario_codusuario = @usuario_codusuario AND livros_isbn = @livros_isbn";
                cmd.Parameters.AddWithValue("@codcategoria", textBox1.Text);
                cmd.Parameters.AddWithValue("@livros_isbn", textBox2.Text);
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

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText =
                    "INSERT INTO reservas (usuario_codusuario, livros_isbn, reservadata) " +
                    "VALUES (@usuario_codusuario, @livros_isbn, @reservadata);";

                cmd.Parameters.AddWithValue("@usuario_codusuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@livros_isbn", textBox2.Text);
                cmd.Parameters.AddWithValue("@reservadata", textBox3.Text);

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
                cmd.CommandText = "UPDATE reservas SET " +
                    "usuario_codusuario=@usuario_codusuario, livros_isbn=@livros_isbn, reservadata=@reservadata WHERE usuario_codusuario = @usuario_codusuario";

                cmd.Parameters.AddWithValue("@usuario_codusuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@livros_isbn", textBox2.Text);
                cmd.Parameters.AddWithValue("@reservadata", textBox3.Text);
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
