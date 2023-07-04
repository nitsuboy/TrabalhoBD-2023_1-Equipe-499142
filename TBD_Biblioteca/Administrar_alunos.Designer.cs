namespace TBD_Biblioteca
{
    partial class Administrar_alunos
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.MinimumSize = new Size(0, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Matricula";
            textBox1.Size = new Size(173, 40);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(191, 12);
            textBox2.MinimumSize = new Size(0, 40);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nome aluno";
            textBox2.Size = new Size(294, 40);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(491, 12);
            textBox3.MinimumSize = new Size(0, 40);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Endereço aluno";
            textBox3.Size = new Size(279, 40);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(12, 58);
            textBox4.MinimumSize = new Size(0, 40);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Data igresso";
            textBox4.Size = new Size(228, 40);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(246, 58);
            textBox5.MinimumSize = new Size(0, 40);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Data conclusao";
            textBox5.Size = new Size(234, 40);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(491, 58);
            textBox6.MinimumSize = new Size(0, 40);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Codigo curso";
            textBox6.Size = new Size(129, 40);
            textBox6.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(12, 104);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 14;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(137, 104);
            button3.Name = "button3";
            button3.Size = new Size(119, 40);
            button3.TabIndex = 15;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(262, 104);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 16;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 397);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(626, 58);
            textBox7.MinimumSize = new Size(0, 40);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Codigo usuario";
            textBox7.Size = new Size(144, 40);
            textBox7.TabIndex = 18;
            // 
            // Administrar_alunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(textBox7);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Administrar_alunos";
            Text = "Administrar_alunos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox7;
    }
}