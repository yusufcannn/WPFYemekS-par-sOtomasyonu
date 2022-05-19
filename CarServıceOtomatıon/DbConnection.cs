using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FoodOtomatıon
{
   public class DbConnection
    {
        public SqlConnection Connection()
        {
            // Database bağlantı kontrol methodu
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DPP0GNB;Initial Catalog=DBOtomatıon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return con;
        }
      
    }
}
