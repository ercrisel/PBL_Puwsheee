using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Authentication.Class
{
    public static class ConnectToDatabase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Puwshee;Integrated Security=True";
        public static string ReturnConnectionString()
        {
            return connectionString;
        }
    }
}
