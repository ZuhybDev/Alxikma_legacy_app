
namespace al_xikma_app
{
    partial class UC_employee_template
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.employeeTemplatePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsalaries = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Animated = true;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.Checked = true;
            this.btnEmployee.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmployee.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Location = new System.Drawing.Point(327, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(198, 37);
            this.btnEmployee.TabIndex = 14;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // employeeTemplatePanel
            // 
            this.employeeTemplatePanel.BackColor = System.Drawing.SystemColors.Control;
            this.employeeTemplatePanel.Location = new System.Drawing.Point(0, 45);
            this.employeeTemplatePanel.Name = "employeeTemplatePanel";
            this.employeeTemplatePanel.Size = new System.Drawing.Size(1016, 605);
            this.employeeTemplatePanel.TabIndex = 13;
            // 
            // btnsalaries
            // 
            this.btnsalaries.Animated = true;
            this.btnsalaries.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnsalaries.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsalaries.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnsalaries.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnsalaries.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnsalaries.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsalaries.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsalaries.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsalaries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsalaries.FillColor = System.Drawing.SystemColors.Control;
            this.btnsalaries.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsalaries.ForeColor = System.Drawing.Color.Black;
            this.btnsalaries.Location = new System.Drawing.Point(531, 4);
            this.btnsalaries.Name = "btnsalaries";
            this.btnsalaries.Size = new System.Drawing.Size(178, 37);
            this.btnsalaries.TabIndex = 12;
            this.btnsalaries.Text = "Salaries";
            this.btnsalaries.Click += new System.EventHandler(this.btnsalaries_Click);
            // 
            // UC_employee_template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.employeeTemplatePanel);
            this.Controls.Add(this.btnsalaries);
            this.Name = "UC_employee_template";
            this.Size = new System.Drawing.Size(1017, 654);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Panel employeeTemplatePanel;
        private Guna.UI2.WinForms.Guna2Button btnsalaries;
    }
}
