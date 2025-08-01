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
    public partial class Dashboard : Form
    {

        private string _userRole;
        //string role
        public Dashboard()
        {
            InitializeComponent();
            UC_home home = new UC_home();
            userControl(home);
            //_userRole = role;

        }

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }


       private void dashbaordClosing(object sender ,FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to exit the app?","Exit Confirmation" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            } else
            {
                e.Cancel = true;
            }


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if( _userRole == "MANAGER")
            {
                // show all controls
            } else
            {
              
                

            }
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_home home = new UC_home();
            userControl(home);

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            UC_vehicle vehicle = new UC_vehicle();
            userControl(vehicle);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_customer customer = new UC_customer();
            userControl(customer);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_orders orders = new UC_orders();
            userControl(orders);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_payments payments = new UC_payments();
            userControl(payments);
        }
    }
}

