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
    public partial class Administrar_alunos : Form
    {

        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable alunos = new DataTable();
        public Administrar_alunos()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                cmd.CommandText = "SELECT * FROM alunos";
                MySqlDataReader dados = cmd.ExecuteReader();
                alunos.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = alunos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            cmd.CommandText = "SELECT * FROM alunos";
            MySqlDataReader dados = cmd.ExecuteReader();
            alunos.Clear();
            alunos.Load(dados);
            dados.Close();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = alunos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            try
            {
                cmd.CommandText = "DELETE FROM alunos WHERE matricula = @matricula";
                cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
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
                if(textBox7.Text != null)
                {
                    cmd.CommandText =
                    "INSERT INTO alunos (matricula, usuario_codusuario ,nome, endereco, dataingresso, dataconclusaoprevista, cursos_codcurso) " +
                    "VALUES (@matricula, @usuario_codusuario, @nome, @endereco, DATE(@dataingresso), DATE(@dataconclusao), @curso_codcurso);";

                    cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
                    cmd.Parameters.AddWithValue("@usuario_codusuario", textBox7.Text);
                    cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox3.Text);
                    cmd.Parameters.AddWithValue("@dataingresso", textBox4.Text);
                    cmd.Parameters.AddWithValue("@dataconclusao", textBox5.Text);
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
                cmd.CommandText = "UPDATE alunos SET " +
                    "nome=@nome, endereco=@endereco, dataingresso=DATE(@dataingresso), dataconclusaoprevista=DATE(@dataconclusao), cursos_codcurso=@curso_codcurso" +
                    " WHERE matricula = @matricula";
                cmd.Parameters.AddWithValue("@matricula", textBox1.Text);
                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@endereco", textBox3.Text);
                cmd.Parameters.AddWithValue("@dataingresso", textBox4.Text);
                cmd.Parameters.AddWithValue("@dataconclusao", textBox5.Text);
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
