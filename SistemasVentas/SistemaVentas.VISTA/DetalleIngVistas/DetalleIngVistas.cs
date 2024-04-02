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

namespace SistemaVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngVistas : Form
    {
        public DetalleIngVistas()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }
    }
}
