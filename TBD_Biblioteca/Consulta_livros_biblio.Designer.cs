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
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            filtro_tb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(639, 12);
            button1.Name = "button1";
            button1.Size = new Size(104, 92);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Busca_b_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(697, 280);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(46, 403);
            button2.Name = "button2";
            button2.Size = new Size(203, 32);
            button2.TabIndex = 3;
            button2.Text = "Registrar Empréstimo";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ano de Lançamento", "Autor", "Editora", "Categoria" });
            checkedListBox1.Location = new Point(46, 13);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(361, 70);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // filtro_tb
            // 
            filtro_tb.Location = new Point(413, 14);
            filtro_tb.Margin = new Padding(3, 5, 3, 5);
            filtro_tb.Name = "filtro_tb";
            filtro_tb.PlaceholderText = "Filtrar por nome";
            filtro_tb.Size = new Size(220, 27);
            filtro_tb.TabIndex = 5;
            // 
            // Consulta_livros_biblio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(filtro_tb);
            Controls.Add(checkedListBox1);
            Controls.Add(button2);
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
        private Button button2;
        private CheckedListBox checkedListBox1;
        private TextBox filtro_tb;
    }
}