using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PBL_Puwsheee.Authentication.Class;
using Guna.UI2.WinForms;

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
    {
        ChangeSettings user = new ChangeSettings();
        SignUp su = new SignUp();
        bool changePic = false;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );

        public void conditions() // func to check para disabled si button kapag taken si username at email
        {
            if (emailTaken.Visible == true || usernameTaken.Visible == true || nameCondition.Visible == true || lastCondition.Visible == true)
            {
                savechangesButton.Enabled = false;
            }
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
        public bool areFieldsCompleted()
        {
            bool complete = false;
            if (firstnameTextbox.Text != string.Empty && lastnameTextbox.Text != string.Empty && emailTextbox.Text != string.Empty && usernameTextbox.Text != string.Empty)
            {
                complete = true;
            }
            return complete;
        }
        public Settings_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void clickClearData(object sender, EventArgs e)
        {
            Form bg = new Form();
            using (Form clearForm = new Clear_Data())
            {
                bg.StartPosition = FormStartPosition.CenterScreen;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = .50d;
                bg.BackColor = Color.Black;
                bg.WindowState = FormWindowState.Normal;
                bg.TopMost = true;
                bg.Location = this.Location;
                bg.ShowInTaskbar = false;
                bg.Size = new Size(1020, 610);
                bg.Show();

                Settings_Main sett = new Settings_Main();
                sett.Owner = clearForm;
                clearForm.Owner = bg;
                clearForm.BringToFront();
                clearForm.ShowDialog();
                bg.Dispose();
            }
        }

        private void clickDeactivateAccount(object sender, EventArgs e)
        {
            Form bg = new Form();
            using (Form deactivateForm = new Deactivate_Account())
            {
                bg.StartPosition = FormStartPosition.CenterScreen;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = .50d;
                bg.BackColor = Color.Black;
                bg.WindowState = FormWindowState.Normal;
                bg.TopMost = true;
                bg.Location = this.Location;
                bg.ShowInTaskbar = false;
                bg.Size = new Size(1020, 610);
                bg.Show();

                deactivateForm.Owner = bg;
                deactivateForm.BringToFront();
                deactivateForm.ShowDialog();
                bg.Dispose();
            }
        }
        public void showConfirmationCode() // para mag show submit code
        {
            codelabel.Visible = enterCodeTextBox.Visible = submitCode.Visible = true;
        }
        public void hideConfirmationCode() // para i hide si sub,it code
        {
            codelabel.Visible = enterCodeTextBox.Visible = submitCode.Visible = false;
        }
        private void Settings_Main_Load(object sender, EventArgs e)
        {
            user.Username = Log_In.publicUserName;
            user.LoadAllUserInformation(firstnameTextbox, lastnameTextbox,emailTextbox,usernameTextbox,userImage);
            guna2CircleButton1.Image = PBL_Puwsheee.Properties.Resources.visualization;
            guna2CircleButton2.Image = PBL_Puwsheee.Properties.Resources.visualization;
            guna2CircleButton3.Image = PBL_Puwsheee.Properties.Resources.visualization;
            pictureBox1.BackgroundImage= PBL_Puwsheee.Properties.Resources.Back;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
        public void setValues() // set mo value nila username sa textbox
        {
            user.Username = usernameTextbox.Text;
            user.FirstName = firstnameTextbox.Text;
            user.LastName = lastnameTextbox.Text;
            user.EmailAddress = emailTextbox.Text;

        }
        public void loadAndDisableBtn() // para mag load ulet si data
        {
            savechangesButton.Enabled = false;
            user.LoadAllUserInformation(firstnameTextbox, lastnameTextbox, emailTextbox, usernameTextbox, userImage);
        }
        public void clearPass() // ma clear lahat laman ni password
        {
            currentpasswordTextbox.Text = newpasswordTextbox.Text = confirmTexbox.Text = string.Empty;
        }
        private void savechangesButton_Click(object sender, EventArgs e)
        {
            //upload mo sa database
            if (areFieldsCompleted())
            {
                if(emailTextbox.Text != user.EmailAddress)
                {
                    su.EmailAddress = emailTextbox.Text;
                    su.SendEmailToCode();
                    showConfirmationCode();
                }
                if(emailTextbox.Text == user.EmailAddress)
                {
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
                    clearPass();
                    user.HideConditions(passCondition1, passCondition2, passCondition3, passAndConfirm, newPassReq, confPassReq);
                }
            }
            else
            {
                //MessageBox.Show("Complete the fields");
            }
        }


       

        private void changephotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chooce File";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                user.ImageLocation = dlg.FileName.ToString();
                userImage.Image = Image.FromFile(user.ImageLocation);
                changePic = true;
                if (changePic)
                {
                    savechangesButton.Enabled = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.mayBinagoSaTextBox(user.FirstName, firstnameTextbox, savechangesButton); // if may binago sa textbox tsaka lang pwede i click si save
            su.AreAllCharacters(firstnameTextbox.Text, nameCondition); // checks if textbox are only letters
            conditions();// di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredFirstName, firstnameTextbox);
        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.mayBinagoSaTextBox(user.LastName, lastnameTextbox, savechangesButton);     // if may binago sa textbox tsaka lang pwede i click si save
            su.AreAllCharacters(lastnameTextbox.Text, lastCondition); // checks if textbox are only letters
            conditions();// di mo ma sasave pag di satisfied ang conditions
            isEmptyField(requiredLastName, lastnameTextbox);
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            string emailToCheckIfUnique = emailTextbox.Text;
            user.mayBinagoSaTextBoxAtUnique(user.EmailAddress, emailTextbox, savechangesButton, emailToCheckIfUnique, emailTaken, "spCheckUniqueEmail", "@EmailAddress", "EmailAddress");
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

        private void submitCode_Click(object sender, EventArgs e)
        {
            su.Code = enterCodeTextBox.Text;
            if (su.CorrectConfirmationCode())
            {
                // MessageBox.Show("Correct Confirmation Code");
                wrongCode.Visible = false;
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
                clearPass();
                user.HideConditions(passCondition1, passCondition2, passCondition3, passAndConfirm, newPassReq, confPassReq);
              
            }
            else
            {
                //MessageBox.Show("Wrong Code");
                wrongCode.Visible = true;
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
            if (passCondition1.Visible == false && passCondition2.Visible == false && passCondition3.Visible == false && passAndConfirm.Visible == false)
            {
                //update the password
                user.Password = newpasswordTextbox.Text;
                user.updatePassword();
                currentpasswordTextbox.Text = newpasswordTextbox.Text = confirmTexbox.Text = string.Empty;
                loadAndDisableBtn();
                user.HideConditions(passCondition1, passCondition2, passCondition3, passAndConfirm, newPassReq, confPassReq);
                // MessageBox.Show("Password Changed Successfully");
                passwordSuccess.Visible = true;
            }

        }
        public void showHidePassword(Guna2TextBox tb)
        {
            if (tb.PasswordChar == '*')
            {
                tb.PasswordChar = '\0';
            }
            else
            {
                tb.PasswordChar = '*';
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            showHidePassword(currentpasswordTextbox);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            showHidePassword(newpasswordTextbox);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            showHidePassword(confirmTexbox);
        }

        private void userImage_Click(object sender, EventArgs e)
        {

        }
    }
}
