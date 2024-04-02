namespace SistemaVentas.VISTA.PedidoVistas
{
    partial class PedidoInsertarVista
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
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(539, 371);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 35;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(355, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 23);
            textBox2.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 230);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 25;
            label2.Text = "ESTADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 108);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 24;
            label1.Text = "FECHA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 184);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 39;
            label3.Text = "MONTO TOTAL DEL PEDIDO";
            // 
            // PedidoInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PedidoInsertarVista";
            Text = "PedidoInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
    }
}