namespace TBD_Biblioteca
{
    partial class login
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
            login_b = new Button();
            Username = new TextBox();
            senha = new TextBox();
            label1 = new Label();
            cadastro = new Button();
            SuspendLayout();
            // 
            // login_b
            // 
            login_b.Cursor = Cursors.Hand;
            login_b.FlatAppearance.BorderSize = 0;
            login_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_b.Location = new Point(113, 287);
            login_b.Name = "login_b";
            login_b.Size = new Size(150, 51);
            login_b.TabIndex = 1;
            login_b.Text = "ENTRAR";
            login_b.UseVisualStyleBackColor = true;
            login_b.Click += login_b_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(64, 149);
            Username.Name = "Username";
            Username.PlaceholderText = "USERNAME";
            Username.Size = new Size(251, 34);
            Username.TabIndex = 2;
            Username.TextChanged += Username_TextChanged;
            // 
            // senha
            // 
            senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            senha.Location = new Point(64, 219);
            senha.Name = "senha";
            senha.PlaceholderText = "SENHA";
            senha.Size = new Size(251, 34);
            senha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 72);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // cadastro
            // 
            cadastro.Cursor = Cursors.Hand;
            cadastro.FlatAppearance.BorderSize = 0;
            cadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastro.Location = new Point(113, 359);
            cadastro.Name = "cadastro";
            cadastro.Size = new Size(150, 51);
            cadastro.TabIndex = 5;
            cadastro.Text = "CADASTRAR";
            cadastro.UseVisualStyleBackColor = true;
            cadastro.Click += cadastro_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 463);
            Controls.Add(cadastro);
            Controls.Add(label1);
            Controls.Add(senha);
            Controls.Add(Username);
            Controls.Add(login_b);
            Name = "login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button login_b;
        private TextBox Username;
        private TextBox senha;
        private Label label1;
        private Button cadastro;
    }
}