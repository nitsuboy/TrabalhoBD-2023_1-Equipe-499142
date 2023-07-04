namespace TBD_Biblioteca
{
    partial class Administrador
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
            livros_b = new Button();
            alunos_b = new Button();
            professores_b = new Button();
            funcionarios_b = new Button();
            usuarios_b = new Button();
            autores_b = new Button();
            cursos_b = new Button();
            categorias_b = new Button();
            reservas_b = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 47);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 1;
            label1.Text = "Administrador";
            // 
            // livros_b
            // 
            livros_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            livros_b.ForeColor = SystemColors.ControlText;
            livros_b.Location = new Point(462, 144);
            livros_b.Name = "livros_b";
            livros_b.Size = new Size(241, 60);
            livros_b.TabIndex = 2;
            livros_b.Text = "Administrar Livros";
            livros_b.UseVisualStyleBackColor = true;
            livros_b.Click += livros_b_Click;
            // 
            // alunos_b
            // 
            alunos_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alunos_b.ForeColor = SystemColors.ControlText;
            alunos_b.Location = new Point(167, 221);
            alunos_b.Name = "alunos_b";
            alunos_b.Size = new Size(247, 60);
            alunos_b.TabIndex = 3;
            alunos_b.Text = "Administrar Alunos";
            alunos_b.UseVisualStyleBackColor = true;
            alunos_b.Click += alunos_b_Click;
            // 
            // professores_b
            // 
            professores_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            professores_b.ForeColor = SystemColors.ControlText;
            professores_b.Location = new Point(167, 301);
            professores_b.Name = "professores_b";
            professores_b.Size = new Size(247, 60);
            professores_b.TabIndex = 4;
            professores_b.Text = "Administrar Professores";
            professores_b.UseVisualStyleBackColor = true;
            professores_b.Click += professores_b_Click;
            // 
            // funcionarios_b
            // 
            funcionarios_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            funcionarios_b.ForeColor = SystemColors.ControlText;
            funcionarios_b.Location = new Point(167, 383);
            funcionarios_b.Name = "funcionarios_b";
            funcionarios_b.Size = new Size(247, 60);
            funcionarios_b.TabIndex = 6;
            funcionarios_b.Text = "Administrar Funcionarios";
            funcionarios_b.UseVisualStyleBackColor = true;
            funcionarios_b.Click += funcionarios_b_Click;
            // 
            // usuarios_b
            // 
            usuarios_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usuarios_b.ForeColor = SystemColors.ControlText;
            usuarios_b.Location = new Point(167, 144);
            usuarios_b.Name = "usuarios_b";
            usuarios_b.Size = new Size(247, 60);
            usuarios_b.TabIndex = 7;
            usuarios_b.Text = "Administrar Usuarios";
            usuarios_b.UseVisualStyleBackColor = true;
            usuarios_b.Click += usuarios_b_Click;
            // 
            // autores_b
            // 
            autores_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autores_b.ForeColor = SystemColors.ControlText;
            autores_b.Location = new Point(462, 224);
            autores_b.Name = "autores_b";
            autores_b.Size = new Size(241, 60);
            autores_b.TabIndex = 8;
            autores_b.Text = "Administrar Autores";
            autores_b.UseVisualStyleBackColor = true;
            autores_b.Click += autores_b_Click;
            // 
            // cursos_b
            // 
            cursos_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cursos_b.ForeColor = SystemColors.ControlText;
            cursos_b.Location = new Point(167, 466);
            cursos_b.Name = "cursos_b";
            cursos_b.Size = new Size(247, 60);
            cursos_b.TabIndex = 9;
            cursos_b.Text = "Administrar Cursos";
            cursos_b.UseVisualStyleBackColor = true;
            cursos_b.Click += cursos_b_Click;
            // 
            // categorias_b
            // 
            categorias_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categorias_b.ForeColor = SystemColors.ControlText;
            categorias_b.Location = new Point(462, 304);
            categorias_b.Name = "categorias_b";
            categorias_b.Size = new Size(241, 60);
            categorias_b.TabIndex = 10;
            categorias_b.Text = "Administrar Categorias";
            categorias_b.UseVisualStyleBackColor = true;
            categorias_b.Click += categorias_b_Click;
            // 
            // reservas_b
            // 
            reservas_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reservas_b.ForeColor = SystemColors.ControlText;
            reservas_b.Location = new Point(462, 385);
            reservas_b.Name = "reservas_b";
            reservas_b.Size = new Size(241, 60);
            reservas_b.TabIndex = 11;
            reservas_b.Text = "Administrar Reservas";
            reservas_b.UseVisualStyleBackColor = true;
            reservas_b.Click += reservas_b_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 603);
            Controls.Add(reservas_b);
            Controls.Add(categorias_b);
            Controls.Add(cursos_b);
            Controls.Add(autores_b);
            Controls.Add(usuarios_b);
            Controls.Add(funcionarios_b);
            Controls.Add(professores_b);
            Controls.Add(alunos_b);
            Controls.Add(livros_b);
            Controls.Add(label1);
            Name = "Administrador";
            Text = "Admnistrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button livros_b;
        private Button alunos_b;
        private Button professores_b;
        private Button funcionarios_b;
        private Button usuarios_b;
        private Button autores_b;
        private Button cursos_b;
        private Button categorias_b;
        private Button reservas_b;
    }
}