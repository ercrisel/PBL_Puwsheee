using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
using System.Threading;

namespace PBL_Puwsheee
{
    public partial class Sign_Up : Form
    {
        SignUp user = new SignUp();
        public void displayPasswordCondition (int num, string password)
        {
            int strengthOfPassword = user.IsPasswordStrong(password);
            if (strengthOfPassword == 0)
            {
                passwordCondition1.Visible = true;
                passwordCondtion2.Visible = true;
                passwordCondition3.Visible = true;
                
            }
            if (strengthOfPassword == 1)
            {
                passwordCondtion2.Visible = true;
                passwordCondition3.Visible = true;
                passwordCondition1.Visible = false;
            }
            if (strengthOfPassword == 2)
            {
                passwordCondition1.Visible = true;
                passwordCondition3.Visible = true;
                passwordCondtion2.Visible = false;

            }
            if (strengthOfPassword == 3)
            {
                passwordCondition1.Visible = true;
                passwordCondtion2.Visible = true;
                passwordCondition3.Visible = false;

            }
            if (strengthOfPassword == 4)
            {
                passwordCondition3.Visible = true;
                passwordCondtion2.Visible = false;
                passwordCondition1.Visible = false;

            }
            if (strengthOfPassword == 5)
            {
                passwordCondtion2.Visible = true;
                passwordCondition1.Visible = false;
                passwordCondition3.Visible = false;
              

            }
            if (strengthOfPassword == 6)
            {
                passwordCondition1.Visible = true;
                passwordCondition3.Visible = false;
                passwordCondtion2.Visible = false;

            }
            if (strengthOfPassword == 7)
            {
                passwordCondition1.Visible = false;
                passwordCondtion2.Visible = false;
                passwordCondition3.Visible = false;
            }
        }
        // checks if conditions are met
        public bool conditions()
        {
            bool conditionsMet = false;
            if (
                charactersOnly1.Visible == false && charactersOnly2.Visible == false && emailCondition.Visible == false && usernameCondition.Visible == false 
                && passwordCondition1.Visible == false && passwordCondtion2.Visible == false && passwordCondition3.Visible == false && passAndConfirm.Visible == false && 
                firstNameTextBox.Text !=string.Empty && lastNameTextBox.Text !=string.Empty && emailTextBox.Text != string.Empty && usernameTexBox.Text!=string.Empty && passwordTextBox.Text!=string.Empty 
                && confirmPasswordTextBox.Text !=string.Empty
                )
            {
                conditionsMet = true;
            }
            return conditionsMet;
        }
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Log_In login = new Log_In();
            login.Show();
            this.Close();
        }

        public void showConfirmCode()
        {
            code.Visible = true;
            submitCode.Visible = true;
            inputCode.Visible = true;
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.EmailAddress = emailTextBox.Text;
            user.Username = usernameTexBox.Text;
            user.Password = passwordTextBox.Text;
            user.ConfirmPassword = confirmPasswordTextBox.Text;
            if (conditions())
            {
                MessageBox.Show("Account is being created.. Please wait for the confirmation email sent to the email provided", "Success", MessageBoxButtons.OK);
                user.SendEmailToCode();
                Thread.Sleep(3000);
                showConfirmCode();
               
            }
            else
            {
                MessageBox.Show("Please complete all fields and the conditions required");
            }
            //PositiveAffirmations pa = new PositiveAffirmations();
            //pa.Show();
            //this.Close();
        }

        private void uploadimageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chooce File";
            if (dlg.ShowDialog()== DialogResult.OK)
            {
                user.ImageLocation = dlg.FileName.ToString();
                userPicture.Image = Image.FromFile(user.ImageLocation);
                Console.WriteLine(user.ImageLocation);
            }
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources");
            string location = filePath + "\\SamplePhoto.png";
            user.ImageLocation = location;
            userPicture.Image = Image.FromFile(user.ImageLocation);
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
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
        
            user.FirstName = firstNameTextBox.Text;
            bool allLeters = user.AreAllCharacters(user.FirstName);
            requiredFieldShow(user.FirstName, requiredFirst);
            if (user.FirstName != string.Empty)
            {


                if (allLeters) charactersOnly1.Visible = false;
                if (!allLeters) charactersOnly1.Visible = true;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            user.LastName = lastNameTextBox.Text;
            bool allLeters = user.AreAllCharacters(user.LastName);
            requiredFieldShow(user.LastName, requiredLast);
            if (user.LastName != string.Empty)
            {
                if (allLeters) charactersOnly2.Visible = false;
                if (!allLeters) charactersOnly2.Visible = true;
            }
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            user.EmailAddress = emailTextBox.Text;
            bool isEmailUnique = user.IsUniqueInDatabase("spCheckUniqueEmail", "@EmailAddress", user.EmailAddress, "EmailAddress" );
            requiredFieldShow(user.EmailAddress, requiredEmail);
            if (isEmailUnique) emailCondition.Visible = false;
            if (!isEmailUnique) emailCondition.Visible = true;
         
        }
        private void usernameTexBox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTexBox.Text;
            bool isUsernameUnique = user.IsUniqueInDatabase("spCheckUniqueUsername", "@Username", user.Username, "Username");
            requiredFieldShow(user.Username, requiredUsername);
            if (isUsernameUnique) usernameCondition.Visible = false;
            if (!isUsernameUnique) usernameCondition.Visible = true;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextBox.Text;
            int strenthOfPassword = user.IsPasswordStrong(user.Password);
            requiredFieldShow(user.Password, requiredPassword);
            displayPasswordCondition(strenthOfPassword, user.Password);
            if (user.SamePassword())
            {
                passAndConfirm.Visible = false;
            }
            else
            {
                passAndConfirm.Visible = true;
            }
        }
        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            user.ConfirmPassword = confirmPasswordTextBox.Text;
            requiredFieldShow(user.ConfirmPassword, requiredConfirm);
            if (user.SamePassword())
            {
                passAndConfirm.Visible = false;
            }
            else
            {
                passAndConfirm.Visible = true;
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar =  confirmPasswordTextBox.PasswordChar = '\0';
                showPassword.Text = "Hide Password ";
            }
            else
            {
                passwordTextBox.PasswordChar = confirmPasswordTextBox.PasswordChar = '*';
                showPassword.Text = "Show Password EYE ICON";
            }
        }

        private void submitCode_Click(object sender, EventArgs e)
        {
            user.Code = inputCode.Text.ToUpper();
            if (user.CorrectConfirmationCode())
            {
                MessageBox.Show("Success", "Account Created");
                user.UploadEntriesToDatabase();
                Log_In li = new Log_In();
                li.Show();
            }
            else
            {
                MessageBox.Show("Wrong Confirmation Code");
            }
        }
    }
}
