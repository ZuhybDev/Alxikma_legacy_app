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
    public partial class UC_orders : UserControl
    {
        public UC_orders()
        {
            InitializeComponent();
            UC_purchaseOrder purchaseOrder = new UC_purchaseOrder();
            userControl(purchaseOrder);
        }
        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            orderPanel.Controls.Clear();
            orderPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            UC_purchaseOrder purchaseOrder = new UC_purchaseOrder();
            userControl(purchaseOrder);
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            UC_rentalOrder rentalOder = new UC_rentalOrder();
            userControl(rentalOder);
        }
    }
}
