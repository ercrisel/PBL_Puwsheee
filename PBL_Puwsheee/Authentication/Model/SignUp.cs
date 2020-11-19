using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace PBL_Puwsheee.Authentication.Model
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
        // methods

        // method to check if all the text are only characters
        public bool AreAllCharacters(string toCheck)
        {
            bool allLetters = false;
            char[] textCharArray = toCheck.ToCharArray();
            for (int i = 0; i < textCharArray.Length; i++)
            {
                int letter = (int)textCharArray[i];
                //checks if letter lang laman 65-90 caps 97-122 small
                if (letter >= 65 && letter <= 90 || letter >= 97 && letter <= 122 || letter == 32)
                {
                    allLetters = true;
                }
                else
                {
                    allLetters = false;
                    break;
                }
            }
            return allLetters;
        }
        // method to check if it is unique in the database
        public bool IsUniqueInDatabase(string storedProcedure, string parameterName, string parameterValue, string column)
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

            return unique;

        }
        // method to check if the password is strong
        public int IsPasswordStrong(string password)
        {
            int total = 0;
            int minLength = 8;
            bool correctLength = false ;
            //first condition  must be 8 + char
            if (password.Length >= minLength)
            {
                correctLength = true ;

            }
            if (password.Length < minLength)
            {
                correctLength = false;
            }
            // must contain at least upper or lower
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
            bool mayUpperCaseAtLower = mayUpperCase && mayLowerCase;
            bool mayLetter = mayUpperCase || mayLowerCase;
            bool mayNumberAtLetter = mayNumber && mayLetter;          
            if (!correctLength && mayUpperCaseAtLower && mayNumberAtLetter) // if wala ginawa
            {
                total = 0;
            }
            if (correctLength) // nagawa si first condition
            {
                total = 1;
            }
            if (mayUpperCaseAtLower) // second conditin nagawa
            {
                total = 2;
            }
            if (mayNumberAtLetter)   // third condition nagawa = 3
            {
                total = 3;
            }
            if (correctLength && mayUpperCaseAtLower) // if nagawa si 1st at second condition
            {
                total = 4;
            }
            if (correctLength && mayNumberAtLetter)  // if nagawa nya si 1 at 3
            {
                total = 5;
            }
            if (mayNumberAtLetter && mayUpperCaseAtLower)     // if nagawa si 2 at 3
            {
                total = 6;
            }
            if (mayUpperCaseAtLower && correctLength && mayNumberAtLetter) // if nagawa nya lahat
            {
                total = 7;
            }
            return total;
        }
        
        // checks if the pass and confirm pass is the same returns a true or false
        public bool SamePassword()
        {
           
            bool samePass = true;
            if (password  != confirmPassword)
            {
                samePass = false;

            }
            return samePass;
        }

     
        // method to generate the confirmation code
        private string GenerateCodeToBeSent()
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
            generatedCode = code;
            return code;
        }
        // method to send the code to email
        public void SendEmailToCode()
        {
            string codeToBeSent = GenerateCodeToBeSent();
            Console.WriteLine(codeToBeSent + " send mail function");
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("puwshee@gmail.com");
                msg.To.Add(emailAddress);
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
        // method to check if code inputed is same as generated
        public bool CorrectConfirmationCode()
        {
            bool same = false;
            if (code == generatedCode)
            {
                same = true;
            }
            return same;
        }
        PasswordEncryption encrypt = new PasswordEncryption();
 
        public void UploadEntriesToDatabase()
        {
            // prepare photo to upload
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            //  set password
            encrypt.Password = password;
            // encrypt si pass save sa hash
            hashPassword =encrypt.EncryptedPassword(emailAddress,firstName, lastName);
            Console.WriteLine(hashPassword + "eto encrypted");
            // parameters
            string[] parameters = { "@FirstName", "@LastName", "@EmailAddress", "@Username", "@Password" };
            string[] parameterValues = { firstName, lastName, emailAddress, username, hashPassword};
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
            MessageBox.Show("Account Created Successfully");
        }
    }
}
