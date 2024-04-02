using SistemaVentas.BSS;
using SistemaVentas.VISTA.UsuarioVistas;
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
    public partial class EscogerProductoVista : Form
    {
        public EscogerProductoVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void EscogerProductoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
