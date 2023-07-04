using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TBD_Biblioteca
{
    public partial class Consulta_professores_usuario : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();
        DataTable livros = new DataTable();
        public Consulta_professores_usuario()
        {
            try
            {
                cmd.Connection = conn;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecarregarTabela()
        {
            
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM professoresporcurso WHERE curso LIKE \"%" + filtro_tb.Text + "%\";";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                livros.Clear();
                adapter.Fill(livros);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Busca_b_Click(object sender, EventArgs e)
        {
            RecarregarTabela();
        }

    }
}
