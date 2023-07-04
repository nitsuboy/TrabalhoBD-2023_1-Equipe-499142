namespace TBD_Biblioteca
{
    partial class Usuario
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
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(192, 127);
            button1.Name = "button1";
            button1.Size = new Size(242, 53);
            button1.TabIndex = 0;
            button1.Text = "Consultar/Reservar Livros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(320, 50);
            label1.TabIndex = 1;
            label1.Text = "TELA DE USUÁRIO";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(192, 203);
            button2.Name = "button2";
            button2.Size = new Size(242, 53);
            button2.TabIndex = 2;
            button2.Text = "Consultar Professores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 319);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Usuario";
            Text = "Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}