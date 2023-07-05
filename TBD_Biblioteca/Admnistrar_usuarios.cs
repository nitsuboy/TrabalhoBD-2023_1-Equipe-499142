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
    public partial class Admnistrar_usuarios : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable usuarios = new DataTable();
        public Admnistrar_usuarios()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM usuarios";
                MySqlDataReader dados = cmd.ExecuteReader();
                usuarios.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM usuarios";
            MySqlDataReader dados = cmd.ExecuteReader();
            usuarios.Clear();
            usuarios.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = usuarios;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM usuarios WHERE codusuario = @codigo";
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
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
                    "INSERT INTO usuarios (nomeusuario, senha, qntlivros, tipousuario, niveldeacesso) " +
                    "VALUES (@nomeusuario, @senha, @qntlivros, @tipousuario, @niveldeacesso);";

                cmd.Parameters.AddWithValue("@nomeusuario", textBox2.Text);
                cmd.Parameters.AddWithValue("@senha", textBox3.Text);
                cmd.Parameters.AddWithValue("@qntlivros", textBox4.Text);
                cmd.Parameters.AddWithValue("@tipousuario", textBox5.Text);
                cmd.Parameters.AddWithValue("@niveldeacesso", textBox6.Text);
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
                cmd.CommandText = "UPDATE usuarios SET " +
                    "nomeusuario=@nomeusuario, senha=@senha, qntlivros=@qntlivros, tipousuario=@tipousuario, niveldeacesso=@niveldeacesso" +
                    " WHERE codusuario = @codusuario";
                cmd.Parameters.AddWithValue("@codusuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@nomeusuario", textBox2.Text);
                cmd.Parameters.AddWithValue("@senha", textBox3.Text);
                cmd.Parameters.AddWithValue("@qntlivros", textBox4.Text);
                cmd.Parameters.AddWithValue("@tipousuario", textBox5.Text);
                cmd.Parameters.AddWithValue("@niveldeacesso", textBox6.Text);
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
