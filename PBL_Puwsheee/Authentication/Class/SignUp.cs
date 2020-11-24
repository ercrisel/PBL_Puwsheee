using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace PBL_Puwsheee.Authentication.Class
{
    public class SignUp
    {
        //fields
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string username;
        private string password;
        private string confirmPassword;
        private string connectionString = ConnectToDatabase.ReturnConnectionString();
        private string imageLocation;
        private string code;
        private string hashPassword;
        private char verified = 'Y';
        private string generatedCode;
        // properties
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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        // Methods
        public void ShowRequiredFields(Guna2TextBox textBox, Label condition) // responsible pag empty display mo to
        {
            if (textBox.Text == string.Empty)
            {
                condition.Visible = true;
            }
            if(textBox.Text != string.Empty)
            {
                condition.Visible = false;
            }
        }
        public void AreAllCharacters(string toCheck, Label condition) // checks if it is all characters
        {
            char[] textCharArray = toCheck.ToCharArray();
            for (int i = 0; i < textCharArray.Length; i++)
            {
                int letter = (int)textCharArray[i];
                //checks if letter lang laman 65-90 caps 97-122 small
                if (letter >= 65 && letter <= 90 || letter >= 97 && letter <= 122 || letter == 32)
                {
                    condition.Visible = false;
                }
                else
                {
                    condition.Visible = true;
                    break;
                }
            }

        }
        public void IsUniqueInDatabase(string storedProcedure, string parameterName, string parameterValue, string column, Label condition) // checks if unique in database
        {

            bool unique = true;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand(storedProcedure, connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(parameterName, parameterValue);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string checkSimilar = read[column].ToString();
                if (checkSimilar == parameterValue)
                {
                    unique = false;
                }
            }
            read.Close();
            connect.Close();
            if (unique)
            {
                condition.Visible = false;
            }
            else
            {
                condition.Visible = true;
            }


        }
        public void IsPasswordStrong(Label condition1, Label condition2, Label condition3) // method to check if the password is strong
        {
            int minLength = 8;
            bool mayUpperCase = false;
            bool mayLowerCase = false;
            bool mayNumber = false;
            char[] passChar = password.ToCharArray();
            for (int i = 0; i < passChar.Length; i++)
            {
                int passCharInt = (int)passChar[i];
                if (passCharInt >= 65 && passCharInt <= 90)
                {
                    mayUpperCase = true;
                    continue;
                }
                if (passCharInt >= 97 && passCharInt <= 122)
                {
                    mayLowerCase = true;
                    continue;

                }
                if (passCharInt >= 30 || passCharInt <= 39)
                {
                    mayNumber = true;
                    continue;
                }
            }
            if (password.Length >= minLength) // condition 1 must be 8 or more char
            {
                condition1.Visible = false;
            }
            else
            {
                condition1.Visible = true;
            }
            if (mayUpperCase && mayLowerCase) // condition 2 if may upp and low case
            {
                condition2.Visible = false;
            }
            else
            {
                condition2.Visible = true;
            }
            bool mayLetter = mayUpperCase || mayLowerCase;
            if (mayLetter && mayNumber)
            {
                condition3.Visible = false;
            }
            else
            {
                condition3.Visible = true;
            }
        }
        public void SamePassword(Label text) // checks if the pass and confirm pass is the same label will notify 
        {
            text.Visible = false;
            if (password != confirmPassword)
            {
                text.Visible = true;
            }
        }
        public string GenerateCodeToBeSent() // method to generate the confirmation code  
        {
            string code = string.Empty;
            char[] generateCodeCharacters =
            {
                'A', 'B','C', 'D' ,'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P','Q', 'R', 'S', 'T',
                'U', 'V','W', 'X','Y', 'Z' ,'0', '1','2', '3' ,'4', '5', '6', '7', '8', '9'
            };
            int counter = 0;
            Random r = new Random();
            while (counter != 6)
            {

                int rand = r.Next(0, generateCodeCharacters.Length - 1);
                code += generateCodeCharacters[rand];
                counter++;
            }
            return code;
        }
        public void SendEmailToCode()  // method to send the code to email
        {
            string codeToBeSent = GenerateCodeToBeSent();
            generatedCode = codeToBeSent;
            Console.WriteLine(codeToBeSent + " send mail function");
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("puwshee@gmail.com");
                msg.To.Add(emailAddress);
                Console.WriteLine(emailAddress);
                msg.Subject = "===PUWSHEE CONFIRMATION CODE===";

                msg.Body = "Hi, " + username + " this is your confirmation code :   " + codeToBeSent + "." + DateTime.Now.ToString();
                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "puwshee@gmail.com";
                ntcd.Password = "jneawraayrwbpfso";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                MessageBox.Show("The verification code is sent successfully please check your email.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CorrectConfirmationCode() // method to check if code inputed is same as generated
            {
                bool same = false;
                if (code == generatedCode)
                {
                    same = true;
                }
                return same;
            }
        public void UploadEntriesToDatabase() // upload entries to database
        {
            PasswordEncryption encrypt = new PasswordEncryption();
            // prepare photo to upload
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            //  set password
            encrypt.Password = password;
            // encrypt si pass save sa hash
            hashPassword = encrypt.EncryptedPassword(emailAddress, firstName, lastName);
            // parameters
            string[] parameters = { "@FirstName", "@LastName", "@EmailAddress", "@Username", "@Password" };
            string[] parameterValues = { firstName, lastName, emailAddress, username, hashPassword };
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spInsertUserInformations", connect);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.AddWithValue(parameters[i], parameterValues[i]);
            }
            command.Parameters.AddWithValue("@Image", img);
            command.Parameters.AddWithValue("@Verified", verified);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Account Created Successfully");
        }
    }
}
