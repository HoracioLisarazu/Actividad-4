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

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolVistas : Form
    {
        public UsuarioRolVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void UsuarioRolVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }
    }
}
