using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Authentication.Class
{
    class PasswordEncryption
    {
        private string password;
        private string connectionString = ConnectToDatabase.ReturnConnectionString();
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string EncryptedPassword(string emailAddress, string firstName, string lastName)
        {
            int index = emailAddress.IndexOf('@');
            string subString = emailAddress.Substring(0, index);
            string salt = "L4n4s4ng3lPB1" + subString + firstName[0] + lastName[0];
            password += salt;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //computehash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                password = builder.ToString();
                return password;
            }
        }
    }
}
