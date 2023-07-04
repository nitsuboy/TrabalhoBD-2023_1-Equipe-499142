namespace TBD_Biblioteca
{
    partial class Consulta_alunos_adm
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 35);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 2;
            label1.Text = "Administração de alunos";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 106);
            textBox1.MinimumSize = new Size(0, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a matrícula";
            textBox1.Size = new Size(177, 40);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(68, 227);
            button1.Name = "button1";
            button1.Size = new Size(143, 68);
            button1.TabIndex = 5;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(246, 227);
            button2.Name = "button2";
            button2.Size = new Size(147, 68);
            button2.TabIndex = 6;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1058, 376);
            dataGridView1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(251, 106);
            textBox2.MinimumSize = new Size(0, 40);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nome";
            textBox2.Size = new Size(595, 40);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(68, 168);
            textBox3.MinimumSize = new Size(0, 40);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Endereço";
            textBox3.Size = new Size(493, 40);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(567, 168);
            textBox4.MinimumSize = new Size(0, 40);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Data Conclusão(Ano-Mes-Dia)";
            textBox4.Size = new Size(279, 40);
            textBox4.TabIndex = 10;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(68, 35);
            button3.Name = "button3";
            button3.Size = new Size(95, 42);
            button3.TabIndex = 13;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Consulta_alunos_adm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Consulta_alunos_adm";
            Text = "Administrar Alunos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
    }
}