using SistemaVentas.BSS;
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
    public partial class ProductosDatosVista : Form
    {
        public ProductosDatosVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductosDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }
    }
}
