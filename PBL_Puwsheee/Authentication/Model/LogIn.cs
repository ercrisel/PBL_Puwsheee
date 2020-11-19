using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBL_Puwsheee.Authentication.Model
{
    class LogIn
    {
        PasswordEncryption pass = new PasswordEncryption();
        private string username;
        private string password;
        private string connectionString = ConnectToDatabase.ReturnConnectionString();
     
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
       
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public bool checkIfAccountInDatabase()
        {
            bool mayAccount = false;
            pass.Password = password;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spLogIn", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string firstNameStr = read["FirstName"].ToString();
                string lastNameStr = read["LastName"].ToString();
                string emailAddressStr = read["EmailAddress"].ToString();
                string passwordStr = read["Password"].ToString();
                if (passwordStr == pass.EncryptedPassword(emailAddressStr, firstNameStr, lastNameStr))
                {
                    mayAccount = true;
                }
            }
            read.Close();
            connect.Close();
            return mayAccount;
        }

    }
}
