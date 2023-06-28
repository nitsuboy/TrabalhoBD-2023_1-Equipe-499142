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

            try
            {
                conn.Open();
                cmd.Connection = conn;
                InitializeComponent();
                CarregarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarReservas()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Reservas";
                MySqlDataReader dados = cmd.ExecuteReader();
                reservas.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
