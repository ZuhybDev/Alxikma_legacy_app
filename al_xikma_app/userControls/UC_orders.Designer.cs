
namespace al_xikma_app
{
    partial class UC_orders
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
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.orderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRental = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnPurchase
            // 
            this.btnPurchase.Animated = true;
            this.btnPurchase.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPurchase.Checked = true;
            this.btnPurchase.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPurchase.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnPurchase.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnPurchase.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchase.FillColor = System.Drawing.SystemColors.Control;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnPurchase.Location = new System.Drawing.Point(327, 4);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(198, 37);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Purchase Order";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.SystemColors.Control;
            this.orderPanel.Location = new System.Drawing.Point(0, 45);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(1016, 605);
            this.orderPanel.TabIndex = 10;
            // 
            // btnRental
            // 
            this.btnRental.Animated = true;
            this.btnRental.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRental.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRental.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnRental.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnRental.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRental.FillColor = System.Drawing.SystemColors.Control;
            this.btnRental.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Location = new System.Drawing.Point(531, 4);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(178, 37);
            this.btnRental.TabIndex = 9;
            this.btnRental.Text = "Rental Order";
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // UC_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.btnRental);
            this.Name = "UC_orders";
            this.Size = new System.Drawing.Size(1017, 654);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2Panel orderPanel;
        private Guna.UI2.WinForms.Guna2Button btnRental;
    }
}
