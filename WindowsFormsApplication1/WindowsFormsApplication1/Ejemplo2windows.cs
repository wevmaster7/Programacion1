using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, pasword;
            usuario = txtlogin.Text.TrimEnd();
            pasword = txtpassword.Text.TrimEnd();
            if ((usuario == "UTEC") && (pasword == "programacion1"))
            {
                MessageBox.Show("BIENVENIDO AL SISTEMA");
            }
            else
            {
                MessageBox.Show("Verifique usuario o contraseña por favor!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
