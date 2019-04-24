using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo6window
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            if(progressBar1.Value<100)
            progressBar1.Value++;

            if (progressBar1.Value == 100)
                timer1.Enabled = false;

            

        }
        
    }
}
