﻿namespace TBD_Biblioteca
{
    partial class Consulta_professores_usuario
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
            dataGridView1 = new DataGridView();
            Busca_b = new Button();
            filtro_tb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(887, 504);
            dataGridView1.TabIndex = 1;
            // 
            // Busca_b
            // 
            Busca_b.Location = new Point(787, 16);
            Busca_b.Margin = new Padding(3, 4, 3, 4);
            Busca_b.Name = "Busca_b";
            Busca_b.Size = new Size(113, 45);
            Busca_b.TabIndex = 2;
            Busca_b.Text = "Buscar";
            Busca_b.UseVisualStyleBackColor = true;
            Busca_b.Click += Busca_b_Click;
            // 
            // filtro_tb
            // 
            filtro_tb.Location = new Point(14, 25);
            filtro_tb.Margin = new Padding(3, 4, 3, 4);
            filtro_tb.Name = "filtro_tb";
            filtro_tb.PlaceholderText = "Digite o nome do curso";
            filtro_tb.Size = new Size(314, 27);
            filtro_tb.TabIndex = 3;
            // 
            // Consulta_professores_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(filtro_tb);
            Controls.Add(Busca_b);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Consulta_professores_usuario";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Busca_b;
        private TextBox filtro_tb;
    }
}