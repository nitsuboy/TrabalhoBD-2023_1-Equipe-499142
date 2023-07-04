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
            this.login_b = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_b
            // 
            this.login_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_b.FlatAppearance.BorderSize = 0;
            this.login_b.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_b.Location = new System.Drawing.Point(106, 283);
            this.login_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(131, 38);
            this.login_b.TabIndex = 1;
            this.login_b.Text = "Cadastrar";
            this.login_b.UseVisualStyleBackColor = true;
            this.login_b.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(56, 111);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "USERNAME";
            this.Username.Size = new System.Drawing.Size(220, 29);
            this.Username.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senha.Location = new System.Drawing.Point(56, 164);
            this.senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.senha.Name = "senha";
            this.senha.PlaceholderText = "SENHA";
            this.senha.Size = new System.Drawing.Size(220, 29);
            this.senha.TabIndex = 3;
            this.senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // cadastro
            // 
            this.cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastro.FlatAppearance.BorderSize = 0;
            this.cadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastro.Location = new System.Drawing.Point(106, 228);
            this.cadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(131, 38);
            this.cadastro.TabIndex = 5;
            this.cadastro.Text = "Entrar";
            this.cadastro.UseVisualStyleBackColor = true;
            this.cadastro.Click += new System.EventHandler(this.login_b_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 347);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.login_b);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button login_b;
        private TextBox Username;
        private TextBox senha;
        private Label label1;
        private Button cadastro;
    }
}