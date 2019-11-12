using System.Windows.Forms;

namespace Fan_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();            
        }
    }
}
