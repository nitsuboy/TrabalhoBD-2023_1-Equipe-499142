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
    public partial class Cadastro : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();
        public Cadastro()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText =
                    "INSERT INTO usuarios (nomeusuario, senha, qntlivros, tipousuario, niveldeacesso) " +
                    "VALUES (@nomeusuario, @senha, @qntlivros, @tipousuario, 'usuario'); SELECT LAST_INSERT_ID();";

                cmd.Parameters.AddWithValue("@nomeusuario", textBox6.Text);
                cmd.Parameters.AddWithValue("@senha", textBox7.Text);
                cmd.Parameters.AddWithValue("@qntlivros", 0);
                cmd.Parameters.AddWithValue("@tipousuario", comboBox1.Text);

                int codigoUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                if (comboBox1.SelectedIndex == 0)
                {
                    cmd.CommandText = "INSERT INTO alunos"+
                                      " (matricula, usuario_codusuario, nome, endereco, dataingresso, dataconclusaoprevista, cursos_codcurso) " +
                                      "VALUES (@matricula, @codigoUsuario, @nome, @endereco, @dataingresso, @dataconclusaoprevista, @cursos_codcurso)";

                    cmd.Parameters.AddWithValue("@matricula", textBox2.Text);
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
                    cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox4.Text);
                    cmd.Parameters.AddWithValue("@dataingresso", DateTime.Now);
                    cmd.Parameters.AddWithValue("@dataconclusaoprevista", DateTime.Now.AddDays(2555));
                    cmd.Parameters.AddWithValue("@cursos_codcurso", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    cmd.CommandText = "INSERT INTO professores"+
                                      " (matsiape, usuario_codusuario, nome, endereco, telefonecelular, regimetrabalho, datacontratacao) " +
                                      "VALUES (@matsiape, @codigoUsuario, @nome, @endereco, @telefonecelular, 'DE', @datacontratacao)";

                    cmd.Parameters.AddWithValue("@matsiape", textBox2.Text);
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
                    cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox4.Text);
                    cmd.Parameters.AddWithValue("@telefonecelular", textBox5.Text);
                    cmd.Parameters.AddWithValue("@datacontratacao", DateTime.Now);
                    
                    cmd.ExecuteNonQuery();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    cmd.CommandText = "INSERT INTO funcionarios" +
                                      " (matricula, usuario_codusuario, nome, endereco) " +
                                      "VALUES (@matricula, @codigoUsuario, @nome, @endereco)";

                    cmd.Parameters.AddWithValue("@matricula", textBox2.Text);
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
                    cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox4.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show( comboBox1.Text +" cadastrado com sucesso! Código do usuário: " + codigoUsuario);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

    }
}
