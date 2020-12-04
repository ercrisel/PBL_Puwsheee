using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PBL_Puwsheee.Classes
{
    public class ConnectionAccess
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Puwshee;Integrated Security=True";
            }
        }
    }
}
