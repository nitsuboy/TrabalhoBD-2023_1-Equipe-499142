using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TBD_Biblioteca
{
    public partial class login : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();
        public login()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
            }
            catch
            {
                MessageBox.Show("falha ao conectar ao banco de dados");
            }
            InitializeComponent();
        }

        private void login_b_Click(object sender, EventArgs e)
        {  
            try
            {
                cmd.CommandText = "select * from usuarios where nomeUsuario = '" + Username.Text + "'";
                MySqlDataReader dados = cmd.ExecuteReader();
                string[] s = {"",""};
                while (dados.Read())
                { 
                    s[0] = dados.GetString(2);
                    s[1] = dados.GetString(5);
                }
                dados.Close();
                if (string.Equals(senha.Text, s[0]) && !string.Equals("", s[0]))
                {
                    switch (s[1])
                    {
                        case "usuario":
                            this.Hide();
                            var user = new Usuario();
                            user.Closed += (s, args) => this.Close();
                            user.Show();
                            break;
                        case "administrador":
                            break;
                        case "bibliotecario":
                            this.Hide();
                            var bib = new Bilbiotecario();
                            bib.Closed += (s, args) => this.Close();
                            bib.Show();
                            break;
                    }
                    
                }
                else
                {
                    MessageBox.Show("senha ou usuario incorreto");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            Form cad = new Cadastro();
            cad.ShowDialog();
        }
    }
}