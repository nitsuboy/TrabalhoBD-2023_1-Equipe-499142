﻿namespace TBD_Biblioteca
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            Título = new DataGridViewTextBoxColumn();
            AUTOR = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "TÍTULO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "AUTOR";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(418, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "CATEGÓRIA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(587, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "EDITORA";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Título, AUTOR, Categoria, Editora, Ano });
            dataGridView1.Location = new Point(26, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(857, 348);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(783, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 5;
            textBox4.Text = "ANO";
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.Width = 175;
            // 
            // AUTOR
            // 
            AUTOR.HeaderText = "Autor";
            AUTOR.MinimumWidth = 6;
            AUTOR.Name = "AUTOR";
            AUTOR.Width = 150;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 175;
            // 
            // Editora
            // 
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.Width = 150;
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.MinimumWidth = 6;
            Ano.Name = "Ano";
            Ano.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(26, 95);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 6;
            button1.Text = "CONSULTAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(895, 608);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Consulta";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn AUTOR;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Ano;
        private Button button1;
    }
}