namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVista
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
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(351, 19);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 2;
            button1.Text = "SELECCIONAR USUARIO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 87);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE USUARIO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 140);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(386, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 148);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 7;
            label4.Text = "FECHA REGISTRO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(69, 296);
            button2.Name = "button2";
            button2.Size = new Size(119, 28);
            button2.TabIndex = 9;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(351, 296);
            button3.Name = "button3";
            button3.Size = new Size(119, 28);
            button3.TabIndex = 10;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 410);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
    }
}