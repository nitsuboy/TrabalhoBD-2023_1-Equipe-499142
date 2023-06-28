namespace TBD_Biblioteca
{
    partial class Consulta_livros_biblio
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
            textBox = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(46, 24);
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Nome, Autor, Editora, Categoria ou Ano de publicação do livro a ser consultado.";
            textBox.Size = new Size(586, 27);
            textBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(654, 24);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(697, 329);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(46, 403);
            button2.Name = "button2";
            button2.Size = new Size(124, 32);
            button2.TabIndex = 3;
            button2.Text = "Empréstimo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(627, 403);
            button3.Name = "button3";
            button3.Size = new Size(116, 32);
            button3.TabIndex = 4;
            button3.Text = "Devolução";
            button3.UseVisualStyleBackColor = true;
            // 
            // Livros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox);
            Name = "Livros";
            Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}