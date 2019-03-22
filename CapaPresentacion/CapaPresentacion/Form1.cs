using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            Datos = "Resultado:  " + r.ToString();
            label3.Text = Datos;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            Datos = "Resultado:  " + r.ToString();
            label3.Text = Datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal a, b, r;
            string Datos;
            a = decimal.Parse(textBox1.Text);
            b = decimal.Parse(textBox2.Text);
            r = a / b;
            Datos = "Resultado: " + r.ToString();
            label3.Text = Datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            Datos = "Resultado:  " + r.ToString();
            label3.Text = Datos;
        }
    }
}
