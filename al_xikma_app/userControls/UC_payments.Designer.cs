
namespace al_xikma_app
{
    partial class UC_payments
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
            this.paymentPanel = new Guna.UI2.WinForms.Guna2Panel();
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
            this.btnPurchase.Location = new System.Drawing.Point(327, 3);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(198, 37);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase Payment";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.paymentPanel.Location = new System.Drawing.Point(0, 44);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(1016, 605);
            this.paymentPanel.TabIndex = 7;
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
            this.btnRental.Location = new System.Drawing.Point(531, 3);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(178, 37);
            this.btnRental.TabIndex = 5;
            this.btnRental.Text = "Rental Payment";
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // UC_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.btnRental);
            this.Name = "UC_payments";
            this.Size = new System.Drawing.Size(1017, 654);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2Panel paymentPanel;
        private Guna.UI2.WinForms.Guna2Button btnRental;
    }
}
