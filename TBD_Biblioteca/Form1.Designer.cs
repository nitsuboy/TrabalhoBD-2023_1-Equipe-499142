namespace TBD_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CADASTRAR = new Button();
            openFileDialog1 = new OpenFileDialog();
            Username = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CADASTRAR
            // 
            CADASTRAR.Cursor = Cursors.Hand;
            CADASTRAR.FlatAppearance.BorderSize = 0;
            CADASTRAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CADASTRAR.Location = new Point(250, 422);
            CADASTRAR.Name = "CADASTRAR";
            CADASTRAR.Size = new Size(150, 50);
            CADASTRAR.TabIndex = 1;
            CADASTRAR.Text = "ENTRAR";
            CADASTRAR.UseVisualStyleBackColor = true;
            CADASTRAR.Click += CADASTRAR_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(207, 214);
            Username.Name = "Username";
            Username.PlaceholderText = "USERNAME";
            Username.Size = new Size(251, 34);
            Username.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(207, 295);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "SENHA";
            textBox2.Size = new Size(251, 34);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 67);
            label1.Name = "label1";
            label1.Size = new Size(185, 72);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 560);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(Username);
            Controls.Add(CADASTRAR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CADASTRAR;
        private OpenFileDialog openFileDialog1;
        private TextBox Username;
        private TextBox textBox2;
        private Label label1;
    }
}