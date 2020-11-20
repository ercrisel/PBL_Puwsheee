using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Authentication.Model
{
    public static class ConnectToDatabase
    {
        private static string connectionString = "Data Source=DESKTOP-8NV2VQJ;Initial Catalog=Puwshee;Integrated Security=True";
        public static string ReturnConnectionString ()
        {
            return connectionString;
        }

    }
}
