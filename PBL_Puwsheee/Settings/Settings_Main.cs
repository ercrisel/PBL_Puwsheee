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
        string imageLocation;
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
        private void savechangesButton_Click(object sender, EventArgs e)
        {
            // update mo sa database
            if (areFieldsCompleted())
            {
                MessageBox.Show("Completed");
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
                imageLocation = dlg.FileName.ToString();
                userPicture.Image = Image.FromFile(imageLocation);
                changePic = true;
            }
        }
    }
}
