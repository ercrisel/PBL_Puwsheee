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
using System.Windows.Forms;

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
        private string previousImage;
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
        public string PreviousImage
        {
            get { return previousImage; }
            set { previousImage = value; }
        }
        // METHODS
        public void LoadPicture(Guna2CirclePictureBox pic) // load mo yung picture nya pag load ng form
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
        public void LoadAllUserInformation(Guna2TextBox firstNameTB, Guna2TextBox lastNameTB, Guna2TextBox emailTB, Guna2TextBox userTB, Guna2CirclePictureBox pic) // function to load all user information
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
                byte[] img = (byte[])read["Image"];
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);
                firstNameTB.Text = firstName;
                lastNameTB.Text = lastName;
                emailTB.Text = EmailAddress;
                userTB.Text = username;
                Console.WriteLine("first name " + firstName);
                Console.WriteLine("Last name " + lastName);
                Console.WriteLine("Email add " + emailAddress);
                Console.WriteLine("Username " + username);
                Console.WriteLine("Password " + password);
               
            }
            read.Close();
            connect.Close();
        }

        public void mayBinagoSaTextBox(string toCheck,Guna2TextBox tb, Guna2Button btn) // checks if may binago sa text box pag meron pwede mo i save
        {
            
            if (toCheck != tb.Text)
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }

        }
        public void mayBinagoSaTextBoxAtUnique(string toCheck, Guna2TextBox tb, Guna2Button btn, string isStringUnique, Label cond, string storeProcs, string parameterName, string column)
        {

            if (toCheck != tb.Text)
            {
                SignUp su = new SignUp();
                su.IsUniqueInDatabase(storeProcs, parameterName, isStringUnique, column, cond); // checheck sa database kung may kamukhang file
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }

        }
        public void updateEntries()
        {
           
        }
        

        
    }
}
