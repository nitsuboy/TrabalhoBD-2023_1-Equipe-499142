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
    public partial class Consulta_reservas_biblio : Form
    {
        DataTable reservas = new DataTable();
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();

        public Consulta_reservas_biblio()
        {
            InitializeComponent();
            CarregarReservas();
        }

        private void CarregarReservas()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Reservas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reservas);
                dataGridView1.DataSource = reservas;

                MessageBox.Show("cu largo");
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

        private void Consulta_reservas_biblio_Load(object sender, EventArgs e)
        {
            CarregarReservas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarReservas();
        }
    }
}
