using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Guia2Ejer2 : Form
    {
        public Guia2Ejer2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { // Carga la imagen dentro del cuadro picture box. 
                pictureBox1.Image= Image.FromFile(openFileDialog1.FileName);
                // Muestra el nombre del archivo en el titulo de forma
                this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName
                + ")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true; System.Diagnostics.Process.Start("Calc");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true; System.Diagnostics.Process.Start("IExplore", "http://www.utec.edu.sv");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true; System.Diagnostics.Process.Start("C:\\");
        }
    }
}
