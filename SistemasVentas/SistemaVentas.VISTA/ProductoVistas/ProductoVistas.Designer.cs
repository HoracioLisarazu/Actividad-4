namespace SistemaVentas.VISTA.ProductoVistas
{
    partial class ProductoVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoVistas));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(871, 343);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 53);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 103);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "FECHA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(326, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(637, 54);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 5;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(215, 617);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 6;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(618, 617);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 7;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(224, 172);
            button4.Name = "button4";
            button4.Size = new Size(140, 38);
            button4.TabIndex = 8;
            button4.Text = "AÑADIR PRODUCTOS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProductoVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 659);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ProductoVistas";
            Text = "ProductoVistas";
            Load += ProductoVistas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}