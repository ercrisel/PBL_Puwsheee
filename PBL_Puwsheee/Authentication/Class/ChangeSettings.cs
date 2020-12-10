using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Authentication.Class
{
    public class ChangeSettings
    {
        // fields
        private string username;
        private string connectionString = ConnectToDatabase.ReturnConnectionString();
        private string passwordEnc;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string previousUsername;
        private string imageLocation;
        private string password;

        //PROPERTIES
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
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
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
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
                passwordEnc = read["Password"].ToString();
                byte[] img = (byte[])read["Image"];
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);
                firstNameTB.Text = firstName;
                lastNameTB.Text = lastName;
                emailTB.Text = EmailAddress;
                userTB.Text = username;
                previousUsername = username;
            }
            read.Close();
            connect.Close();
        }

        public void mayBinagoSaTextBox(string toCheck, Guna2TextBox tb, Guna2Button btn) // checks if may binago sa text box pag meron pwede mo i save
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
            // hash naten si password
            PasswordEncryption pass = new PasswordEncryption();
            pass.Password = Log_In.publicPasswordInput;
            string hashedPass = pass.EncryptedPassword(emailAddress, firstName, lastName);
            string[] parameters = { "FirstName", "LastName", "EmailAddress", "Username", "Password", "PreviousUsername" };
            string[] parameterValue = { firstName, lastName, emailAddress, username, hashedPass, previousUsername };
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spUpdateInformation", connect);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.AddWithValue(parameters[i], parameterValue[i]);
            }
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void updateEntriesWithImage()
        {
            // hash naten si password
            PasswordEncryption pass = new PasswordEncryption();
            pass.Password = Log_In.publicPasswordInput;
            // prepare image to upload
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            // end ng phoyo upload
            string hashedPass = pass.EncryptedPassword(emailAddress, firstName, lastName);
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string[] parameters = { "FirstName", "LastName", "EmailAddress", "Username", "Password", "PreviousUsername" };
            string[] parameterValue = { firstName, lastName, emailAddress, username, hashedPass, previousUsername };
            SqlCommand command = new SqlCommand("spUpdateInfoPic", connect);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.AddWithValue(parameters[i], parameterValue[i]);
            }
            command.Parameters.AddWithValue("Image", img);
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void SamePassword(Guna2Button btn) // checks if current pass is correct
        {
            PasswordEncryption pass = new PasswordEncryption();
            pass.Password = password;
            if (pass.EncryptedPassword(emailAddress, firstName, lastName) == passwordEnc)
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }
        public void updatePassword()  // uupdates the password
        {
            PasswordEncryption pass = new PasswordEncryption();
            pass.Password = password;
            Console.WriteLine(pass.Password + " eto orig");

            string enc = pass.EncryptedPassword(emailAddress, firstName, lastName);
            Console.WriteLine(enc + " eto encrypted nya");
            Console.WriteLine("encrypted dapat to " + enc);
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spUpdatePassword", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", enc);
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void HideConditions(Label cond1, Label cond2, Label cond3, Label cond4, Label cond5, Label cond6) // hide lahat ng condition sa change pass
        {
            cond1.Visible = cond2.Visible = cond3.Visible = cond4.Visible = cond5.Visible = cond6.Visible = false;
        }

        public void DeactivateAccount()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spDeactivateAccount", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void ClearData()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spClearData", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.ExecuteNonQuery();
            connect.Close();

        }
    }
}
