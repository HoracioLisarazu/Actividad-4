﻿using SistemaVentas.BSS;
using SistemaVentas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PersonaVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        PersonaBss bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CI = textBox4.Text;
            p.Correo = textBox5.Text;


            bss.InsertarPersonaBss(p);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
