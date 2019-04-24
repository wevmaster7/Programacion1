using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double suma,dato1, dato2;
            dato1 = double.Parse(textBox3.Text);
            dato2 = double.Parse(textBox4.Text);
            suma = dato1 + dato2;
            textBox5.Text = suma.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            double retiro, dato1, dato2;
            dato1 = double.Parse(textBox3.Text);
            dato2 = double.Parse(textBox7.Text);
            retiro=dato1-dato2;
            textBox5.Text = retiro.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double envio, dato1, dato2;
            dato1 = double.Parse(textBox3.Text);
            dato2 = double.Parse(textBox6.Text);
            envio = dato1 - dato2;
            textBox5.Text = envio.ToString();
        }
    }
}
