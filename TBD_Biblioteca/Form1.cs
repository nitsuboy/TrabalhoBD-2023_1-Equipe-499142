using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TBD_Biblioteca
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();
        public Form1()
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

        private void login_Click(object sender, EventArgs e)
        {  
            try
            {
                cmd.CommandText = "select * from usuarios where nomeUsuario = '" + Username.Text + "' ";
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
                            var form2 = new Form2();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                            break;
                        case "administrador":
                            break;
                        case "bibliotecario":
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
    }
}