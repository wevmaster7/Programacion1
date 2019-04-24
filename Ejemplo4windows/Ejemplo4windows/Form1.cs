using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, n, suma=0;
            listBox1.Items.Clear();
            n=int.Parse(textBox1.Text);
            for(x=1; x<=n; x++){
                suma = suma + x;
                if (checkBox1.Checked==true)
                {
                    listBox1.Items.Add("sumando:" + x + "suma parcial:" + suma);
                }
            }
            listBox1.Items.Add("la suma total es:" + suma);
        }
    }
}
