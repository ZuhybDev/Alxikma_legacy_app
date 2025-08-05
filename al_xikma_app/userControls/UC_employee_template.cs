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
    public partial class UC_employee_template : UserControl
    {
        public UC_employee_template()
        {
            InitializeComponent();
            UC_employee employee = new UC_employee();
            userControl(employee);
        }

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            employeeTemplatePanel.Controls.Clear();
            employeeTemplatePanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UC_employee employee = new UC_employee();
            userControl(employee);
        }

        private void btnsalaries_Click(object sender, EventArgs e)
        {
            UC_salary salaries = new UC_salary();
            userControl(salaries);
        }
    }
}
