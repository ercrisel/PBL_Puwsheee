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
                string[] checkField = {user.FirstName, user.LastName,user.EmailAddress, user.Username, user.Password, user.ConfirmPassword };
                Label[] labels = { requiredFirst, requiredLast, requiredEmail, requiredUsername, requiredPassword, requiredConfirm };
                for (int i = 0; i < labels.Length; i++)
                {
                    requiredFieldShow(checkField[i], labels[i]);
                }
                
            }
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
            if (textBox !=string.Empty)
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
            user.AreAllCharacters(user.FirstName, charactersOnly1);
            requiredFieldShow(user.FirstName, requiredFirst);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            user.LastName = lastNameTextBox.Text;
            user.AreAllCharacters(user.LastName, charactersOnly2);
            requiredFieldShow(user.LastName, requiredLast);
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            user.EmailAddress = emailTextBox.Text;
            user.IsUniqueInDatabase("spCheckUniqueEmail", "@EmailAddress", user.EmailAddress, "EmailAddress", emailCondition);
            requiredFieldShow(user.EmailAddress, requiredEmail);
         
        }
        private void usernameTexBox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTexBox.Text;
            user.IsUniqueInDatabase("spCheckUniqueUsername", "@Username", user.Username, "Username", usernameCondition);
            requiredFieldShow(user.Username, requiredUsername);
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextBox.Text;
            user.IsPasswordStrong(passwordCondition1, passwordCondtion2, passwordCondition3);
            requiredFieldShow(user.Password, requiredPassword);
            user.SamePassword(passAndConfirm);
        }
        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            user.ConfirmPassword = confirmPasswordTextBox.Text;
            requiredFieldShow(user.ConfirmPassword, requiredConfirm);
            user.SamePassword(passAndConfirm);
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
