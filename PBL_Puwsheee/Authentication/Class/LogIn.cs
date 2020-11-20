using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PBL_Puwsheee.Authentication.Model
{
    public class LogIn
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

        public void requiredFieldShow(string textBox, Label required)
        {
            if (textBox != string.Empty)
            {
                required.Visible = false;
            }
            else
            {
                required.Visible = true;
            }
        }
        public bool checkIfAccountInDatabase()
        {
            bool mayAcc = false;
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
                string emailAdStr = read["EmailAddress"].ToString();
                string passwordStr = read["Password"].ToString();
                pass.Password = password;
                if(passwordStr == pass.EncryptedPassword(emailAdStr, firstNameStr, lastNameStr))
                {
                    mayAcc = true;
                }
            }
            return mayAcc;
        }

    }
}
