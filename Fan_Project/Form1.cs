using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fan_Project
{
    public partial class Form1 : Form
    {
        [DllImport("Cimwin32.dll")]
        static extern uint SetSpeed(in UInt64 sp);
        public Form1()
        {
            InitializeComponent();
            label1.Text = trackBar1.Value.ToString();            
        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            SetSpeed(Convert.ToUInt64(trackBar1.Value));
        }
    }
}
