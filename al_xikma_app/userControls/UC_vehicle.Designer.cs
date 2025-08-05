
namespace al_xikma_app
{
    partial class UC_vehicle
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
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.vehicleMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnSupplier
            // 
            this.btnSupplier.Animated = true;
            this.btnSupplier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSupplier.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSupplier.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSupplier.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnSupplier.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.SystemColors.Control;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnSupplier.Location = new System.Drawing.Point(557, 3);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(140, 37);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // vehicleMainPanel
            // 
            this.vehicleMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.vehicleMainPanel.Location = new System.Drawing.Point(0, 44);
            this.vehicleMainPanel.Name = "vehicleMainPanel";
            this.vehicleMainPanel.Size = new System.Drawing.Size(1016, 605);
            this.vehicleMainPanel.TabIndex = 3;
            this.vehicleMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.vehicleMainPanel_Paint);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Animated = true;
            this.btnVehicle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicle.Checked = true;
            this.btnVehicle.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVehicle.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnVehicle.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnVehicle.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicle.FillColor = System.Drawing.SystemColors.Control;
            this.btnVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnVehicle.Location = new System.Drawing.Point(327, 3);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(148, 37);
            this.btnVehicle.TabIndex = 4;
            this.btnVehicle.Text = "Vehicles";
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // UC_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.vehicleMainPanel);
            this.Controls.Add(this.btnSupplier);
            this.Name = "UC_vehicle";
            this.Size = new System.Drawing.Size(1017, 654);
            this.Load += new System.EventHandler(this.UC_vehicle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2Panel vehicleMainPanel;
        private Guna.UI2.WinForms.Guna2Button btnVehicle;
    }
}
