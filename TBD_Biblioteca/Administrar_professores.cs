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
    public partial class Administrar_professores : Form
    {

        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable professores = new DataTable();
        public Administrar_professores()
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox8.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();
            textBox7.Text = row.Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM professores WHERE matsiape = @matsiape";
                cmd.Parameters.AddWithValue("@matsiape", textBox1.Text);
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
            cmd.Parameters.Clear();
            try
            {
                if (textBox7.Text != null)
                {
                    cmd.CommandText =
                    "INSERT INTO professores (matsiape, usuario_codusuario ,nome, endereco, telefonecelular, regimetrabalho, datacontratacao, cursos_codcurso) " +
                    "VALUES (@matsiape, @usuario_codusuario, @nome, @endereco, @telefonecelular, @regimetrabalho,STR_TO_DATE(@datacontratacao, '%d/%m/%Y %H:%i:%s'), @curso_codcurso);";

                    cmd.Parameters.AddWithValue("@matsiape", textBox1.Text);
                    cmd.Parameters.AddWithValue("@usuario_codusuario", textBox7.Text);
                    cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telefonecelular", textBox4.Text);
                    cmd.Parameters.AddWithValue("@regimetrabalho", textBox8.Text);
                    cmd.Parameters.AddWithValue("@datacontratacao", textBox5.Text);
                    cmd.Parameters.AddWithValue("@curso_codcurso", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Usuário não existente");
                }

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
                cmd.CommandText = "UPDATE professores SET " +
                    "nome=@nome, endereco=@endereco, telefonecelular=@telefonecelular, regimetrabalho=@regimetrabalho, datacontratacao=STR_TO_DATE(@datacontratacao, '%d/%m/%Y %H:%i:%s'), cursos_codcurso=@curso_codcurso" +
                    " WHERE matsiape = @matsiape";
                cmd.Parameters.AddWithValue("@matsiape", textBox1.Text);
                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@endereco", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefonecelular", textBox4.Text);
                cmd.Parameters.AddWithValue("@regimetrabalho", textBox8.Text);
                cmd.Parameters.AddWithValue("@datacontratacao", textBox5.Text);
                cmd.Parameters.AddWithValue("@curso_codcurso", textBox6.Text);
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
