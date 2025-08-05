
namespace al_xikma_app
{
    partial class Splash_screen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainProgressBar = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar = new Guna.UI2.WinForms.Guna2Button();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Animated = true;
            this.mainProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.mainProgressBar.BorderColor = System.Drawing.Color.White;
            this.mainProgressBar.BorderRadius = 6;
            this.mainProgressBar.BorderThickness = 1;
            this.mainProgressBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mainProgressBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mainProgressBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mainProgressBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mainProgressBar.FillColor = System.Drawing.Color.Black;
            this.mainProgressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainProgressBar.ForeColor = System.Drawing.Color.White;
            this.mainProgressBar.Location = new System.Drawing.Point(168, 397);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(419, 13);
            this.mainProgressBar.TabIndex = 1;
            this.mainProgressBar.UseTransparentBackground = true;
            // 
            // progressBar
            // 
            this.progressBar.Animated = true;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderColor = System.Drawing.Color.White;
            this.progressBar.BorderRadius = 6;
            this.progressBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.progressBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.progressBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.progressBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(170, 398);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(10, 10);
            this.progressBar.TabIndex = 2;
            this.progressBar.UseTransparentBackground = true;
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 5;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::al_xikma_app.Properties.Resources.splashScreen1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(768, 432);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 432);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Splash_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button mainProgressBar;
        private Guna.UI2.WinForms.Guna2Button progressBar;
        private System.Windows.Forms.Timer splashTimer;
    }
}

