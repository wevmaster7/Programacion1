using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ejemplo5windows
{
    public partial class Form1 : Form
    {
        private int tiempo;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0XF170;
        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("winmn")]
        public static extern void mciSendString(string lpstrcommand, string lpstReturnString, int uReturnLenght, long hwndcallback);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
        }
        private void ApagarMonito()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
        private void EncenderMonitor()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }
    }
}
