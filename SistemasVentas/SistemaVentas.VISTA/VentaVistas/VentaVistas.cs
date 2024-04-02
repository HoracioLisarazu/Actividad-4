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

namespace SistemaVentas.VISTA.VentaVistas
{
    public partial class VentaVistas : Form
    {
        public VentaVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }
    }
}
