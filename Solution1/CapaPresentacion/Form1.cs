﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        ManttVendor neg = new ManttVendor();
        
        ManttVendor enlc = new ManttVendor();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neg.CodVendor = textBox1.Text;
            neg.NombreVendor = textBox2.Text;
            neg.insertVendor();
            limpiar();
            cargar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            neg.CodVendor = textBox1.Text;
            neg.NombreVendor = textBox2.Text;
            neg.updateVendor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            neg.CodVendor = textBox1.Text;
            neg.deletVendor();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiar() {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
        public void cargar() {
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }
    }
}
