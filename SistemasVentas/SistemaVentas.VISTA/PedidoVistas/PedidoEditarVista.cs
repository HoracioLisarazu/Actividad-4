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
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        Pedido pedido = new Pedido();
        PedidoBss bss = new PedidoBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            pedido = bss.ObtenerIdBss(idx);
            pedido.Fecha = Convert.ToDateTime(textBox1.Text);
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedido.Fecha = Convert.ToDateTime(textBox1.Text);
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            textBox3.Text = pedido.Estado;



            bss.EditarPedidoBss(pedido);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
