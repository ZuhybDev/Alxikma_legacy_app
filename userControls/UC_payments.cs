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
    public partial class UC_payments : UserControl
    {
        public UC_payments()
        {
            InitializeComponent();
            UC_purchasePayemnt purchasePayment = new UC_purchasePayemnt();
            userControl(purchasePayment);
        }

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            paymentPanel.Controls.Clear();
            paymentPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            UC_purchasePayemnt purchasePayment = new UC_purchasePayemnt();
            userControl(purchasePayment);
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            UC_rentalPayment rentalPayment = new UC_rentalPayment();
            userControl(rentalPayment);
        }
    }
}
