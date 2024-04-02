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

namespace SistemaVentas.VISTA.ProveeVistas
{
    public partial class ProveeVistas : Form
    {
        public ProveeVistas()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }
    }
}
