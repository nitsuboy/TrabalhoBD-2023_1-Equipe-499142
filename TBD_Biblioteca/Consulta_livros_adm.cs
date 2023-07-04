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
    public partial class Consulta_livros_adm : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();
        DataTable livros = new DataTable();
        public Consulta_livros_adm()
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
            string[] tabela = { "livros", "titulo" };
            try
            {
                switch (checkedListBox1.CheckedItems[0])
                {
                    case "Autor":
                        tabela[0] = "livrosporautor";
                        tabela[1] = "autor";
                        break;
                    case "Editora":
                        tabela[0] = "livrosporeditora";
                        tabela[1] = "editora";
                        break;
                    case "Categoria":
                        tabela[0] = "livrosporcategoria";
                        tabela[1] = "categoria";
                        break;
                    case "Ano de Lançamento":
                        tabela[0] = "livrosporano";
                        tabela[1] = "ano";
                        break;
                }
            }
            catch (Exception) { }

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM " + tabela[0] + " WHERE " + tabela[1] + " LIKE \"%" + filtro_tb.Text + "%\";";
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void Busca_b_Click(object sender, EventArgs e)
        {
            RecarregarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            cmd.CommandText = "INSERT INTO reservas (Usuario_CodUsuario, Livros_ISBN,reservadata) VALUES (" + Globals.user + ",'" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "',now())";
            try
            {
                DialogResult res = MessageBox.Show("você deseja reservar esse livro ?", "reserva", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("reserva efetuada");
                    conn.Close();
                    RecarregarTabela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
