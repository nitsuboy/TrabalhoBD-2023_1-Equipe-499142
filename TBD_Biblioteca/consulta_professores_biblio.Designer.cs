namespace TBD_Biblioteca
{
    partial class consulta_professores_biblio
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
            filtro_tb = new TextBox();
            Busca_b = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // filtro_tb
            // 
            filtro_tb.Location = new Point(12, 13);
            filtro_tb.Margin = new Padding(3, 4, 3, 4);
            filtro_tb.Name = "filtro_tb";
            filtro_tb.PlaceholderText = "Digite o nome do curso";
            filtro_tb.Size = new Size(314, 27);
            filtro_tb.TabIndex = 4;
            // 
            // Busca_b
            // 
            Busca_b.Location = new Point(645, 4);
            Busca_b.Margin = new Padding(3, 4, 3, 4);
            Busca_b.Name = "Busca_b";
            Busca_b.Size = new Size(113, 45);
            Busca_b.TabIndex = 5;
            Busca_b.Text = "Buscar";
            Busca_b.UseVisualStyleBackColor = true;
            Busca_b.Click += Busca_b_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(777, 504);
            dataGridView1.TabIndex = 6;
            // 
            // consulta_professores_biblio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 574);
            Controls.Add(dataGridView1);
            Controls.Add(Busca_b);
            Controls.Add(filtro_tb);
            Name = "consulta_professores_biblio";
            Text = "consulta_professores_biblio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filtro_tb;
        private Button Busca_b;
        private DataGridView dataGridView1;
    }
}