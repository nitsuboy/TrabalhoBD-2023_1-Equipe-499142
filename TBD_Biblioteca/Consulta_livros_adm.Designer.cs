namespace TBD_Biblioteca
{
    partial class Consulta_livros_adm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(406, 20);
            label1.Name = "label1";
            label1.Size = new Size(307, 37);
            label1.TabIndex = 1;
            label1.Text = "Administração dos livros";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(53, 86);
            textBox1.MinimumSize = new Size(0, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o ISBN";
            textBox1.Size = new Size(204, 40);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 229);
            button1.Name = "button1";
            button1.Size = new Size(139, 62);
            button1.TabIndex = 4;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(208, 229);
            button2.Name = "button2";
            button2.Size = new Size(164, 62);
            button2.TabIndex = 5;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1115, 420);
            dataGridView1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(263, 86);
            textBox2.MinimumSize = new Size(0, 40);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Titulo";
            textBox2.Size = new Size(689, 40);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(53, 155);
            textBox3.MinimumSize = new Size(0, 40);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Editora";
            textBox3.Size = new Size(606, 40);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(665, 155);
            textBox4.MinimumSize = new Size(0, 40);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "AnoDeLançamento";
            textBox4.Size = new Size(287, 40);
            textBox4.TabIndex = 9;
            // 
            // Consulta_livros_adm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Consulta_livros_adm";
            Text = "Administração dos livros";
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
    }
}