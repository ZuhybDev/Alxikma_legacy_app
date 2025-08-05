using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace al_xikma_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
           
            using (var splash = new Splash_screen())
            {
                splash.Show();
                Application.DoEvents();
                System.Threading.Thread.Sleep(2000);
                splash.Close();
            }


            using (var login = new loginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    string role = login.UserRole;
                    Application.Run(new Dashboard(role));

                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
