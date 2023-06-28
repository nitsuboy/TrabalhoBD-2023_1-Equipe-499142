﻿using MySql.Data.MySqlClient;
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
    public partial class Consulta_livros_usuario : Form
    {
        MySqlConnection conn = new MySqlConnection(Program.connstring());
        MySqlCommand cmd = new MySqlCommand();
        public Consulta_livros_usuario()
        {
            try
            {
                conn.Open();
                cmd.Connection= conn;
                InitializeComponent();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void Busca_b_Click(object sender, EventArgs e)
        {
            string[] tabela = {"livros","titulo"};
            DataTable livros = new DataTable();
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
            catch (Exception){}
            
            try
            {
                cmd.CommandText = "SELECT * FROM "+ tabela[0] +" WHERE " + tabela[1] + " LIKE \"%" + filtro_tb.Text + "%\";";
                MySqlDataReader dados = cmd.ExecuteReader();
                livros.Load(dados);
                dados.Close();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}