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
    public partial class Consulta_alunos_adm : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        DataTable alunos = new DataTable();

        public Consulta_alunos_adm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "DELETE FROM alunos WHERE matricula= " + textBox1.Text;
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
                    "UPDATE alunos" +
                    " SET " +
                    "nome= '" + textBox2.Text +
                    "', endereco= '" + textBox3.Text +
                    "', dataconclusaoprevista= DATE('" + textBox4.Text + "')" +
                    " WHERE matricula= " + textBox1.Text;
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
