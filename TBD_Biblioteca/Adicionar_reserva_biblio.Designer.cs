namespace TBD_Biblioteca
{
    partial class reserva
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 196);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "DIgite a matrícula";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(443, 171);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aluno", "Professor", "Funcionário" });
            comboBox1.Location = new Point(71, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(71, 275);
            button2.Name = "button2";
            button2.Size = new Size(152, 40);
            button2.TabIndex = 3;
            button2.Text = "Efetuar empréstimo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 85);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 4;
            label1.Text = "Selecione o tipo de usuário";
            // 
            // reserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 433);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "reserva";
            Text = "Adicionar_reserva_biblio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label1;
    }
}