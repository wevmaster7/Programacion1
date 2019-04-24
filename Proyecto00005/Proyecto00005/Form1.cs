using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto00005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=24; i++){
            progressBar1.PerformStep();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            timer1.Interval = 3000;
            timer1.Enabled = true;
          

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            timer1.Interval = 3000;
            timer1.Enabled = true;
          

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            timer1.Interval = 2000;
            timer1.Enabled = true;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();

        }
    }
}
