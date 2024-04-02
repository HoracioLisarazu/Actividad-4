using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.PedidoVistas
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pe = new Pedido();
            pe.Fecha = Convert.ToDateTime(textBox1.Text);
            pe.Total = Convert.ToDecimal(textBox2.Text);
            pe.Estado = textBox3.Text;



            bss.InsertarPedidoBss(pe);
            MessageBox.Show("Se guardaron correctamente los datos");
        }
    }
}
