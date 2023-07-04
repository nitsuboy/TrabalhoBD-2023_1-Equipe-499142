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
    public partial class Admnistrar_funcionarios : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable funcionarios = new DataTable();
        public Admnistrar_funcionarios()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM funcionarios";
                MySqlDataReader dados = cmd.ExecuteReader();
                funcionarios.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM funcionarios";
            MySqlDataReader dados = cmd.ExecuteReader();
            funcionarios.Clear();
            funcionarios.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = funcionarios;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM funcionarios WHERE matricula = @matricula";
                cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
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
            textBox4.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            if (textBox3.Text != null)
            {
                try
                {
                    cmd.CommandText =
                        "INSERT INTO funcionarios (matricula, usuario_codusuario, nome, endereco) " +
                        "VALUES (@matricula, @usuario_codusuario, @nome, @endereco);";

                    cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
                    cmd.Parameters.AddWithValue("@usuario_codusuario", textBox3.Text);
                    cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else{
                MessageBox.Show("Usuário não encontrado");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "UPDATE funcionarios SET " +
                    "matricula=@matricula, usuario_codusuario=@usuario_codusuario, nome=@nome, endereco=@endereco" +
                    " WHERE matricula = @matricula";
                cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
                cmd.Parameters.AddWithValue("@usuario_codusuario", textBox3.Text);
                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@endereco", textBox4.Text);
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
