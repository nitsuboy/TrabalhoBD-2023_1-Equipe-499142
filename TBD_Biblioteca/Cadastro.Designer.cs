namespace TBD_Biblioteca
{
    partial class Cadastro
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
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(501, 39);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(182, 341);
            textBox1.MinimumSize = new Size(4, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ex: Gabriel Augusto Farias Gomes";
            textBox1.Size = new Size(558, 34);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 301);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(758, 301);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 3;
            label3.Text = "Matrícula:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(758, 341);
            textBox2.MinimumSize = new Size(4, 40);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ex: 499142";
            textBox2.Size = new Size(174, 34);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(182, 397);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 5;
            label4.Text = "CodCurso:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(182, 429);
            textBox3.MinimumSize = new Size(4, 40);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ex: 10";
            textBox3.Size = new Size(299, 34);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(501, 397);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 7;
            label5.Text = "Endereço:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(501, 429);
            textBox4.MinimumSize = new Size(4, 40);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Ex: Rua Pedro Aguiar Carneiro";
            textBox4.Size = new Size(431, 34);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(182, 484);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 9;
            label6.Text = "Telefone:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(182, 515);
            textBox5.MinimumSize = new Size(4, 40);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Ex: (88) 940028922";
            textBox5.Size = new Size(253, 34);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aluno", "Professor", "Funcionario" });
            comboBox1.Location = new Point(182, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(182, 129);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 12;
            label7.Text = "Tipo:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(528, 664);
            button1.Name = "button1";
            button1.Size = new Size(150, 55);
            button1.TabIndex = 13;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(182, 248);
            textBox6.MinimumSize = new Size(4, 40);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Ex: GabrielAfg";
            textBox6.Size = new Size(433, 34);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(633, 248);
            textBox7.MinimumSize = new Size(4, 40);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Ex: 123456";
            textBox7.Size = new Size(299, 34);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(182, 200);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 16;
            label8.Text = "UserName:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(633, 200);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 17;
            label9.Text = "Senha:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(413, 315);
            label10.Name = "label10";
            label10.Size = new Size(0, 28);
            label10.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(679, 484);
            label11.Name = "label11";
            label11.Size = new Size(145, 28);
            label11.TabIndex = 21;
            label11.Text = "Carga horária:";
            // 
            // button2
            // 
            button2.Location = new Point(454, 515);
            button2.Name = "button2";
            button2.Size = new Size(59, 40);
            button2.TabIndex = 22;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "DE", "20H", "40H" });
            comboBox2.Location = new Point(679, 516);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 23;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label label7;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
        private ComboBox comboBox2;
    }
}