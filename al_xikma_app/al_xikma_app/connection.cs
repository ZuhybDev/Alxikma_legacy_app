using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace al_xikma_app
{
   public class connection
    {
        private static SqlConnection db;
        public static SqlConnection GetConnection()
        {
           
                string connStr = ConfigurationManager.ConnectionStrings["alXikmaDb"].ConnectionString;
                db = new SqlConnection(connStr);
            return db;
        }
    }
}
