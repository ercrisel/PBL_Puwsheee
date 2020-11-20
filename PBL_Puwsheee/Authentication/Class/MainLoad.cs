using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace PBL_Puwsheee.Authentication.Class
{
    public class MainLoad
    {
        // fields
        private string username;
        private string connectionString = ConnectToDatabase.ReturnConnectionString();
        private string password;
        private string firstName;
        private string lastName;
        private string emailAddress;

        //PROPERTIES
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get {return lastName; }
            set { lastName = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        // METHODS
        public void LoadPicture(Guna2CirclePictureBox pic)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spLoadImage", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                byte[] img = (byte[])read["Image"];
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);
            } 
        }
        public void LoadAllUserInformation(Guna2TextBox firstNameTB, Guna2TextBox lastNameTB, Guna2TextBox emailTB, Guna2TextBox userTB)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spLoadUserInformation", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                firstName = read["FirstName"].ToString();
                lastName = read["LastName"].ToString();
                emailAddress = read["EmailAddress"].ToString();
                username = read["Username"].ToString();
                password = read["Password"].ToString();
                firstNameTB.Text = firstName;
                lastNameTB.Text = lastName;
                emailTB.Text = EmailAddress;
                userTB.Text = username;
            }
            read.Close();
            connect.Close();
        }

        public void mayBinagoSaTextBox()
        {

        }
    }
}
