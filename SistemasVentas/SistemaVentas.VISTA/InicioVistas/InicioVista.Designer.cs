namespace SistemaVentas.VISTA.InicioVistas
{
    partial class InicioVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioVista));
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(153, 344);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE DE USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(223, 417);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 3;
            label3.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Cursor = Cursors.AppStarting;
            textBox1.Location = new Point(409, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(409, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(365, 499);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 6;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(635, 499);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 7;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 50);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1287, 742);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(376, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 137);
            panel3.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(126, 89);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 9;
            button3.Text = "CREAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 34);
            label5.Name = "label5";
            label5.Size = new Size(285, 21);
            label5.TabIndex = 10;
            label5.Text = "¿DESEAS CREAR UNA CUENTA?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 75);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(380, 21);
            label4.Name = "label4";
            label4.Size = new Size(329, 36);
            label4.TabIndex = 9;
            label4.Text = "SISTEMA DE VENTAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(404, 100);
            label1.Name = "label1";
            label1.Size = new Size(287, 36);
            label1.TabIndex = 6;
            label1.Text = "INICIO DE SESION";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(467, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // InicioVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 739);
            Controls.Add(panel2);
            Name = "InicioVista";
            Text = "InicioVista";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private Button button3;
        private Label label5;
    }
}