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
    public partial class Consulta_reservas_biblio : Form
    {
        DataTable reservas = new DataTable();
        MySqlConnection conn = new MySqlConnection(Globals.conn);
        MySqlCommand cmd = new MySqlCommand();

        public Consulta_reservas_biblio()
        {
            cmd.Connection = conn;
            InitializeComponent();
            CarregarReservas();
        }

        private void CarregarReservas()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM Reservas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reservas);
                dataGridView1.DataSource = reservas;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                DialogResult res = MessageBox.Show("Você deseja dar baixa nessa reserva ?", "reserva", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    cmd.CommandText = "DELETE FROM reservas WHERE (Usuario_CodUsuario, Livros_ISBN) = (@coduser, @isbn)";
                    cmd.Parameters.AddWithValue("@coduser", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@isbn", dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("baixa feita");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            CarregarReservas();
        }
    }
}
