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

namespace SistemaVentas.VISTA
{
    public partial class TipoProdVistas : Form
    {
        public TipoProdVistas()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void TipoProdVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }
    }
}
