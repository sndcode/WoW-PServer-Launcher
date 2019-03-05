using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace PTFLauncher
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmAbout_Load(object sender, EventArgs e)
        {
            label2.Text = classVars.appversion;
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            classVars.counter += 1;
            if (classVars.counter > 10)
            {
                MessageBox.Show("Devmode");
                classVars.b_debug = true;
            }
        }
    }
}
