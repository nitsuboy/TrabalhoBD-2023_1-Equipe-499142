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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TBD_Biblioteca
{
    public partial class Consulta_livros_biblio : Form
    {
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();
        DataTable livros = new DataTable();
        public Consulta_livros_biblio()
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

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void RecarregarTabela()
        {
            string[] tabela = { "livros", "titulo" };
            try
            {
                conn.Close();
            }
            catch { }

            switch ((0 < checkedListBox1.CheckedItems.Count ? checkedListBox1.CheckedItems[0] : ""))
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
                default:
                    tabela[0] = "livros";
                    tabela[1] = "titulo";
                    break;
            }

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM " + tabela[0] + " WHERE " + tabela[1] + " LIKE \"%" + filtro_tb.Text + "%\";";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                livros.Clear();
                adapter.Fill(livros);
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form add = new reserva(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            add.ShowDialog();
            RecarregarTabela();
        }
    }
}
