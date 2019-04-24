using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3ok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = textBox1.Text.TrimEnd();
            contraseña = textBox2.Text.TrimEnd();
            if ((textBox1.Text=="Wevmaster") && (textBox2.Text=="123456"))
            {
                MessageBox.Show("Bienvenido Al sistema");
            }

            else
            {
                MessageBox.Show("verifique el usuario o contraseña");
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
