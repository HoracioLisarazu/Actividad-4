using SistemaVentas.BSS;
using SistemaVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.ProductoVistas
{
    public partial class ProductoVistas : Form
    {
        public ProductoVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoVistas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EscogerProductoVista fr = new EscogerProductoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }
    }
}
