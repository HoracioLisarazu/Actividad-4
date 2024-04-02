﻿using SistemaVentas.BSS;
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

namespace SistemaVentas.VISTA.PedidoVistas
{
    public partial class PedidoListarVista : Form
    {
        public PedidoListarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        ClienteBss bss1 = new ClienteBss();
        private void button2_Click(object sender, EventArgs e)
        {
            PedidoInsertarVista fr = new PedidoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoEditarVista fr = new PedidoEditarVista(IdPedidoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas seguro de Eliminar este pedido", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSeleccionado);
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void PedidoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             bss1.ListarClienteBss();
        }
    }
}
