namespace TBD_Biblioteca
{
    partial class Bilbiotecario
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 0;
            label1.Text = "Bibliotecário";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(291, 101);
            button1.Name = "button1";
            button1.Size = new Size(186, 48);
            button1.TabIndex = 1;
            button1.Text = "Consultar Livros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(291, 179);
            button2.Name = "button2";
            button2.Size = new Size(186, 50);
            button2.TabIndex = 2;
            button2.Text = "Consultar Usuários";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(291, 257);
            button3.Name = "button3";
            button3.Size = new Size(183, 54);
            button3.TabIndex = 3;
            button3.Text = "Consultar Reservas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bilbiotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "bilbiotecario";
            Text = "bilbiotecario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}