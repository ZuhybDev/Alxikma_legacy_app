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
    public partial class UC_vehicle : UserControl
    {
        public UC_vehicle()
        {
            InitializeComponent();
            UC_main_vehicles mainVehicles = new UC_main_vehicles();
            userControl(mainVehicles);
        }

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            vehicleMainPanel.Controls.Clear();
            vehicleMainPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnVehicle_Click(object sender, EventArgs e)
        {
            UC_main_vehicles mainVehicles = new UC_main_vehicles();
            userControl(mainVehicles);
        }

        private void btnVehiclePrice_Click(object sender, EventArgs e)
        {
            UC_vehiclePrice price = new UC_vehiclePrice();
            userControl(price);

        }

        private void UC_vehicle_Load(object sender, EventArgs e)
        {
          

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            UC_supplier supplier = new UC_supplier();
            userControl(supplier);
        }

        private void vehicleMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
