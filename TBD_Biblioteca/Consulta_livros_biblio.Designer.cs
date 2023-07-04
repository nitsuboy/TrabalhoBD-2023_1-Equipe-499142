namespace TBD_Biblioteca
{
    partial class Consulta_livros_biblio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            filtro_tb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(664, 12);
            button1.Name = "button1";
            button1.Size = new Size(106, 93);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Busca_b_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 397);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ano de Lançamento", "Autor", "Editora", "Categoria" });
            checkedListBox1.Location = new Point(12, 13);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(361, 92);
            checkedListBox1.TabIndex = 4;
            // 
            // filtro_tb
            // 
            filtro_tb.Location = new Point(424, 13);
            filtro_tb.Name = "filtro_tb";
            filtro_tb.PlaceholderText = "Filtrar por nome";
            filtro_tb.Size = new Size(182, 27);
            filtro_tb.TabIndex = 5;
            // 
            // Consulta_livros_biblio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(filtro_tb);
            Controls.Add(checkedListBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Consulta_livros_biblio";
            Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private CheckedListBox checkedListBox1;
        private TextBox filtro_tb;
    }
}