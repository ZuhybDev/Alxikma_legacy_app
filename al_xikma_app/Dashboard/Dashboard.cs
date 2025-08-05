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
        public Dashboard(string role)
        {
            InitializeComponent();
            UC_home home = new UC_home();
            userControl(home);
            _userRole = role;

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
                btnEmployee.Visible = false;
                

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
           UC_purchaseOrder orders = new UC_purchaseOrder();
            userControl(orders);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_purchasePayemnt payments = new UC_purchasePayemnt();
            userControl(payments);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            UC_report report = new UC_report();
            userControl(report);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UC_employee_template employeeTemplate = new UC_employee_template();
            userControl(employeeTemplate);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
                DialogResult result = MessageBox.Show("Do you want to exit the app?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
             
            } else
            {
                
            }
          
               
        }
    }
}

