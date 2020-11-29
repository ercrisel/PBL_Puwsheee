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
using System.IO;
using System.Data.SqlClient;
using PBL_Puwsheee.Authentication.Class;
using Guna.UI2.WinForms;
namespace PBL_Puwsheee
{
    public partial class Sign_Up : Form
    {
        SignUp user = new SignUp();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        public bool conditions()
        {
            bool conditionsMet = false;
            if (firstNameTextbox.Text != string.Empty && lastNameTextbox.Text != string.Empty && emailTextbox.Text != string.Empty && usernameTexbox.Text != string.Empty
                && passwordTextbox.Text != string.Empty && confirmPasswordTextbox.Text != string.Empty && firstNameCondition.Visible == false && lastNameCondition.Visible == false
                && emailCondition.Visible == false && usernameCondition.Visible == false && passwordCondition1.Visible == false && passwordCondition2.Visible == false && passwordCondition3.Visible ==false
                && requiredFirstName.Visible == false && requiredLastName.Visible == false && requiredEmail.Visible==false && requiredUsername.Visible == false &&  requiredPassword.Visible ==false
                && requiredConfirmPassword.Visible ==false)
            {
                conditionsMet = true;
            }
            return conditionsMet;
        }

        public Sign_Up()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            fadeOut.Start();
            Log_In login = new Log_In();
            login.Show();
        }

        public void showCode()
        {
            label11.Visible = enterCodeTextBox.Visible = submitCodeButton.Visible = true;
            signupButton.Left = 509;
 
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            user.FirstName = firstNameTextbox.Text;
            user.LastName = lastNameTextbox.Text;
            user.EmailAddress = emailTextbox.Text;
            user.Username = usernameTexbox.Text;
            user.Password = passwordTextbox.Text;
            user.ConfirmPassword = confirmPasswordTextbox.Text;
            if (conditions())
            {
                MessageBox.Show("Account is being created.. Please wait for the confirmation email sent to the email provided", "Success", MessageBoxButtons.OK);
                user.SendEmailToCode();
                showCode();
            }
            else
            {
                Console.WriteLine("dito ko sa else");
                Guna2TextBox[] textboxes = { firstNameTextbox, lastNameTextbox, emailTextbox, usernameTexbox, passwordTextbox, confirmPasswordTextbox };
                Label[] labels = { requiredFirstName, requiredLastName, requiredEmail, requiredUsername, requiredPassword, requiredConfirmPassword };
                for (int i = 0; i < textboxes.Length; i++)
                {
                    user.ShowRequiredFields(textboxes[i], labels[i]);
;               }
                MessageBox.Show("Please fill up all fields","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fadeOut.Start();
            Log_In li = new Log_In();
            li.Show();
        }

        // pag nag load si form
        private void Sign_Up_Load(object sender, EventArgs e)
        {
            fadeIn.Start();
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources");
            string location = filePath + "\\SamplePhoto.png";
            userPicture.Image = Image.FromFile(location);
            user.ImageLocation = location;
        }

        // responsible para mag show and hide password
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.PasswordChar == '*')
            {
                passwordTextbox.PasswordChar = confirmPasswordTextbox.PasswordChar = '\0';
                showPasswordIcon.Text = "Hide Password ";
            }
            else
            {
                passwordTextbox.PasswordChar = confirmPasswordTextbox.PasswordChar = '*';
                showPasswordIcon.Text = "Show Password EYE ICON";
            }
        }
        // pag nag input check mo kung lahat chars sa firstname
        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.FirstName = firstNameTextbox.Text;
            user.AreAllCharacters(user.FirstName, firstNameCondition);
            user.ShowRequiredFields(firstNameTextbox, requiredFirstName);
        }

        // pag nag input check mo kung si last name chars lng ang laman bawal nums
        private void lastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.LastName = lastNameTextbox.Text;
            user.AreAllCharacters(user.LastName, lastNameCondition);
            user.ShowRequiredFields(lastNameTextbox, requiredLastName);
        }
        // checheck mo kung unique sya sa database kapag hindi show mo si condion na label
        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            user.EmailAddress = emailTextbox.Text;
            user.IsUniqueInDatabase("spCheckUniqueEmail", "@EmailAddress", user.EmailAddress, "EmailAddress", emailCondition);
            user.ShowRequiredFields(emailTextbox, requiredEmail);

        }
        // check mo kung unique si username sa database pag no show mo si username condition
        private void usernameTexbox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTexbox.Text;
            user.IsUniqueInDatabase("spCheckUniqueUsername", "@Username", user.Username, "Username", usernameCondition);
            user.ShowRequiredFields(usernameTexbox, requiredUsername);
        }
        // check mo kung strong na yung passwordd at na meet conditions
        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextbox.Text;
            user.IsPasswordStrong(passwordCondition1, passwordCondition2, passwordCondition3);
            if (confirmPasswordTextbox.Text != string.Empty)
            {
                user.SamePassword(passAndConfirm);
            }
            user.ShowRequiredFields(passwordTextbox, requiredPassword);
        }
        // check mo kung similar sila ni passwrd
        private void confirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.ConfirmPassword = confirmPasswordTextbox.Text;
            
            if(confirmPasswordTextbox.Text != string.Empty)
            {
                user.SamePassword(passAndConfirm);
            }
            user.ShowRequiredFields(confirmPasswordTextbox, requiredConfirmPassword);
        }

        private void uploadimageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose Image";
            dlg.Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog()== DialogResult.OK)
            {
                user.ImageLocation = dlg.FileName.ToString();
                userPicture.Image = Image.FromFile(user.ImageLocation);
            }
        }

        private void submitCodeButton_Click(object sender, EventArgs e)
        {
            user.Code = enterCodeTextBox.Text.ToUpper();
            if (user.CorrectConfirmationCode())
            {
                MessageBox.Show("Success", "Account Created");
                user.UploadEntriesToDatabase();
                fadeOut.Start();
                Log_In li = new Log_In();
                li.Show();
            }
            else
            {
                MessageBox.Show("Wrong Confirmation Code");
            }
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            Fade.fadeOutEffect(this);
        }

        private void enterCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
