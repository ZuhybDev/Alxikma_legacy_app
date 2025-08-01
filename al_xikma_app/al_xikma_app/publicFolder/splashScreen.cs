using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace al_xikma_app
{
    public partial class Splash_screen : Form
    {
        public Splash_screen()
        {
            InitializeComponent();
        }

        private void Splash_screen_Load(object sender, EventArgs e)
        {
            splashTimer.Start();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;
            if(progressBar.Width >= 417)
            { 
                
                splashTimer.Stop();
                this.Hide();
           
            }

           
        }
    }
}
