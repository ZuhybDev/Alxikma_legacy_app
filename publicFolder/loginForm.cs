using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace al_xikma_app
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        // connection
        SqlConnection db = connection.GetConnection();
        SqlCommand cmd;

        private bool isPasswordVisible = false;

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string UserRole { get; private set; }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //UserRole = AdminCheck.Checked ? "MANAGER" : "EMPLOYEE";
            try
            {
                db.Open();
                string query = "SELECT role from Employee where username = @username AND password = @password";

                cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                object result = cmd.ExecuteScalar();
                db.Close();
                if (result != null)
                {

                    UserRole = result.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials ", "Login failed ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong" + ex.Message);
            }

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eyes_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            if(isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyes.Image = Properties.Resources.eye1;
            }  else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyes.Image = Properties.Resources.hidden;
            }
        }

        private void AdminCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
