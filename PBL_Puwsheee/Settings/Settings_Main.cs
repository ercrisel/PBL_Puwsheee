using Guna.UI2.WinForms;
using PBL_Puwsheee.Authentication.Class;
using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
    {
        MainLoad user = new MainLoad();
        bool changePic = false;
        SignUp su = new SignUp();
        public Settings_Main()
        {
            InitializeComponent();
        }

        private void clickClearData(object sender, EventArgs e)
        {
            new Clear_Data().Show();
        }

        private void clickDeactivateAccount(object sender, EventArgs e)
        {
            new Deactivate_Account().Show();
        }

        private void Settings_Main_Load(object sender, EventArgs e)
        {
            // load all user informations
            user.Username = Log_In.publicUserName;
            user.LoadAllUserInformation(firstnameTextbox, lastnameTextbox, emailTextbox, usernameTextbox, userPicture); // ANDITO YUNG USERINFOS GAGO
        }
        public void conditions() // func to check para disabled si button kapag taken si username at email
        {
            if (emailTaken.Visible == true || usernameTaken.Visible == true || nameCondition.Visible == true || lastCondition.Visible == true)
            {
                savechangesButton.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
        public void isEmpty(Guna2TextBox tb, string value)
        {
            if (tb.Text == string.Empty)
            {
                tb.Text = value;
            }
        }
        public bool areFieldsCompleted()
        {
            bool complete = false;
            if (firstnameTextbox.Text != string.Empty && lastnameTextbox.Text != string.Empty && emailTextbox.Text !=string.Empty && usernameTextbox.Text != string.Empty)
            {
                complete = true;
            }
            return complete;
        }
        public void isEmptyField(Label lbel, Guna2TextBox toCheck) // checks if fields are empty and shows the condition 
        {
            if (toCheck.Text == string.Empty)
            {
                lbel.Visible = true;
            }
            else
            {
                lbel.Visible = false;
            }

        }

        public void showConfirmationCode()
        {
            label1.Visible = true;
            enterCodeTextBox.Visible = true;
            checkCodeIfSame.Visible = true;
        }
        public void hideConfirmationCode()
        {
            label1.Visible = false;
            enterCodeTextBox.Visible = false;
            checkCodeIfSame.Visible = false;
        }
        public void setValues()
        {
            user.Username = usernameTextbox.Text;
            user.FirstName = firstnameTextbox.Text;
            user.LastName = lastnameTextbox.Text;
            user.EmailAddress = emailTextbox.Text;

        }
        public void loadAndDisableBtn()
        {
            savechangesButton.Enabled = false;
            user.LoadAllUserInformation(firstnameTextbox, lastnameTextbox, emailTextbox, usernameTextbox, userPicture);
        }
        private void savechangesButton_Click(object sender, EventArgs e)
        {
            // update mo sa database
            if (areFieldsCompleted())
            {
                MessageBox.Show("Completed");
                if (emailTextbox.Text != user.EmailAddress)
                {
                    su.EmailAddress = emailTextbox.Text;
                    su.SendEmailToCode();
                    showConfirmationCode();
                }
                if(emailTextbox.Text == user.EmailAddress)
                {
                    setValues();
                    // update lahat firstname lastname email username pati pass
                    Console.WriteLine("pasok dito ");
                    if (changePic)
                    {
                        user.updateEntriesWithImage();
                        loadAndDisableBtn();
                    }
                    if (!changePic)
                    {
                        user.updateEntries();
                        loadAndDisableBtn();
                    }
                    Log_In.publicUserName = user.Username;
                }
            }
            else
            {
                MessageBox.Show("Complete the fields");
            }
        }
        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
         
            user.mayBinagoSaTextBox(user.FirstName, firstnameTextbox, savechangesButton); // if may binago sa textbox tsaka lang pwede i click si save
            su.AreAllCharacters(firstnameTextbox.Text, nameCondition); // checks if textbox are only letters
            conditions(); // di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredFirstName, firstnameTextbox);
        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.mayBinagoSaTextBox(user.LastName, lastnameTextbox, savechangesButton); //if may binago sa textbox tsaka lang pwede i click si save
            su.AreAllCharacters(lastnameTextbox.Text, lastCondition); // checks if textbox are only letters
            conditions(); // di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredLastName, lastnameTextbox);
        }
        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {   
            string emailToCheckIfUnique = emailTextbox.Text;
            user.mayBinagoSaTextBoxAtUnique(user.EmailAddress, emailTextbox, savechangesButton, emailToCheckIfUnique, emailTaken, "spCheckUniqueEmail","@EmailAddress", "EmailAddress");
            conditions(); // di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredEmail, emailTextbox);
        }
        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            string usernameToCheckIfUnique = usernameTextbox.Text;
            user.mayBinagoSaTextBoxAtUnique(user.Username, usernameTextbox, savechangesButton, usernameToCheckIfUnique, usernameTaken, "spCheckUniqueUsername", "@Username", "Username");
            conditions(); // di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredUsername, usernameTextbox);
        }
        private void changephotoButton_Click(object sender, EventArgs e) // pag browse lng ng image
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chooce File";
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                user.ImageLocation = dlg.FileName.ToString();
                userPicture.Image = Image.FromFile(user.ImageLocation);
                changePic = true;
                if (changePic)
                {
                    savechangesButton.Enabled = true;
                }
            }
        }

        private void checkCodeIfSame_Click(object sender, EventArgs e)
        {
            su.Code = enterCodeTextBox.Text.ToUpper();
            if (su.CorrectConfirmationCode())
            {
                MessageBox.Show("Correct Confirmation Code");
                hideConfirmationCode();
                setValues();
                if (changePic)
                {
                    user.updateEntriesWithImage();
                    loadAndDisableBtn();
                }
                if (!changePic)
                {
                    user.updateEntries();
                    loadAndDisableBtn();
                }
                Log_In.publicUserName = user.Username;

            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void currentpasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Password = currentpasswordTextbox.Text;
            user.SamePassword(changepasswordButton);
        }

        private void newpasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            su.Password = newpasswordTextbox.Text;
            su.IsPasswordStrong(passCondition1, passCondition2, passCondition3);
            isEmptyField(newPassReq, newpasswordTextbox);
            su.SamePassword(passAndConfirm);
        }

        private void confirmTexbox_TextChanged(object sender, EventArgs e)
        {
            su.ConfirmPassword = confirmTexbox.Text;
            isEmptyField(confPassReq, confirmTexbox);
            su.SamePassword(passAndConfirm);
        }

        private void changepasswordButton_Click(object sender, EventArgs e)
        {
            if(passCondition1.Visible == false && passCondition2.Visible == false && passCondition3.Visible ==false && passAndConfirm.Visible == false)
            {
                //update the password
                user.Password = newpasswordTextbox.Text;
                user.updatePassword();
                currentpasswordTextbox.Text = newpasswordTextbox.Text = confirmTexbox.Text = string.Empty;
                MessageBox.Show("Password Changed Successfully");
                loadAndDisableBtn();
                user.HideConditions(passCondition1,passCondition2,passCondition3,passAndConfirm, newPassReq, confPassReq);
            }
        }
    }
}
