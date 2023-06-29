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
    public partial class Adicionar_reserva_biblio : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();
        public string ISBNSelecionado { get; set; } // Propriedade para armazenar o ISBN selecionado
        public bool ReservaConcluida { get; private set; } // Propriedade para indicar se a reserva foi concluída

        public Adicionar_reserva_biblio()
        {
            conn.Open();
            cmd.Connection = conn;
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Digite uma matrícula válida");
                return;
            }

            if (!string.IsNullOrEmpty(ISBNSelecionado))
            {
                cmd.CommandText = "INSERT INTO reservas (Usuario_CodUsuario, Livros_ISBN, reservadata) VALUES (@Usuario_CodUsuario, @ISBN, NOW())";
                cmd.Parameters.AddWithValue("@CodUsuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@ISBN", ISBNSelecionado);

                try
                {
                    cmd.ExecuteNonQuery();
                    ReservaConcluida = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
                finally
                {
                    cmd.Parameters.Clear();
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado");
            }
        }
    }
}
