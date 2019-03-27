using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class1;
using Class1;

namespace Class26032018
{
    public partial class formOperaciones : Form
    {
        public formOperaciones()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Operacion ingreso = new Operacion();
            ingreso.V1 = double.Parse(textvalA.Text);
            ingreso.V2 = double.Parse(textvalB.Text);
            lblResul.Text = ingreso.Calcular().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           Resta  ingreso = new Resta();
            ingreso.V1 = double.Parse(textvalA.Text);
            ingreso.V2 = double.Parse(textvalB.Text);
            lblResul.Text = ingreso.CalcularResta().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicacion ingreso3 = new Multiplicacion();
            ingreso3.V1 = double.Parse(textvalA.Text);
            ingreso3.V2 = double.Parse(textvalB.Text);
            lblResul.Text = ingreso3.CalcularProducto().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Division ingreso4 = new Division();
            ingreso4.V1 = double.Parse(textvalA.Text);
            ingreso4.V2 = double.Parse(textvalB.Text);
            lblResul.Text = ingreso4.CalcularDivision().ToString();

        }
    }
}
