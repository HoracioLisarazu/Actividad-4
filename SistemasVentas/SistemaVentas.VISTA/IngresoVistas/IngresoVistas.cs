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

namespace SistemaVentas.VISTA.IngresoVistas
{
    public partial class IngresoVistas : Form
    {
        public IngresoVistas()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresoVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }
    }
}
