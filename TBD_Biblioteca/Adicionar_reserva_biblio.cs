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
using MySqlX.XDevAPI;

namespace TBD_Biblioteca
{
    public partial class reserva : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();
        string ISBN = "";

        public reserva(string isbn)
        {
            ISBN = isbn;
            conn.Open();
            cmd.Connection = conn;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    cmd.CommandText = "select usuario_codusuario from alunos where Matricula = " + textBox1.Text;
                    break;
                case 1:
                    cmd.CommandText = "select usuario_codusuario from professores where matsiape = " + textBox1.Text;
                    break;
                case 2:
                    cmd.CommandText = "select usuario_codusuario from funcionarios where Matricula = " + textBox1.Text;
                    break;
                default:
                    MessageBox.Show("selecione uma opção");
                    break;
            }
            try
            {
                MySqlDataReader dados = cmd.ExecuteReader();
                string cod = "";
                while (dados.Read())
                {
                    cod = dados.GetString(0);
                }
                dados.Close();
                cmd.CommandText = "INSERT INTO reservas (Usuario_CodUsuario, Livros_ISBN,reservadata) VALUES (" + cod + ",'" + ISBN + "',now())";
                cmd.ExecuteNonQuery();
                MessageBox.Show("reserva efetuada");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
