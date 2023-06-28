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
<<<<<<< HEAD
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 41);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "TELA ADMINISTRADOR";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(178, 139);
            button1.Name = "button1";
            button1.Size = new Size(175, 60);
            button1.TabIndex = 1;
            button1.Text = "Livros";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(178, 218);
            button2.Name = "button2";
            button2.Size = new Size(175, 60);
            button2.TabIndex = 2;
            button2.Text = "Alunos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(178, 302);
            button3.Name = "button3";
            button3.Size = new Size(175, 60);
            button3.TabIndex = 3;
            button3.Text = "Professor";
            button3.UseVisualStyleBackColor = true;
=======
            this.login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
>>>>>>> 4ac2b12718381d87070a16c3001fc91313bd66bf
            // 
            // login
            // 
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(99, 215);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 38);
            this.login.TabIndex = 1;
            this.login.Text = "ENTRAR";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(56, 112);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "USERNAME";
            this.Username.Size = new System.Drawing.Size(220, 29);
            this.Username.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senha.Location = new System.Drawing.Point(56, 164);
            this.senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.senha.Name = "senha";
            this.senha.PlaceholderText = "SENHA";
            this.senha.Size = new System.Drawing.Size(220, 29);
            this.senha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // Form1
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 491);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adiministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button login;
        private TextBox Username;
        private TextBox senha;
        private Label label1;
    }
>>>>>>> 4ac2b12718381d87070a16c3001fc91313bd66bf
}