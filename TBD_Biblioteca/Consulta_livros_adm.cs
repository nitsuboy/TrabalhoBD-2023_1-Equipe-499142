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
    public partial class Consulta_livros_adm : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable livros = new DataTable();
        public Consulta_livros_adm()
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
            try
            {
                cmd.CommandText = "DELETE FROM livros WHERE isbn= '" + textBox1.Text + "'";
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
                    "UPDATE livros" +
                    " SET " +
                    "titulo= '" + textBox2.Text +
                    "', editora= '" + textBox3.Text +
                    "', anodelancamento= " + textBox4.Text +
                    " WHERE isbn= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
