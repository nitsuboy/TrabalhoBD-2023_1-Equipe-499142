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
            
        }
    }
}
