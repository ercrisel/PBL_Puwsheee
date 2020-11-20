using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    public partial class Log_In : Form
    {
        
        LogIn user = new LogIn();
        public Log_In()
        {
            InitializeComponent();
        }
        public static string publicUserName;
        private void signupButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Sign_Up form = new Sign_Up();
            form.Show();
            
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
        private void loginButton_Click(object sender, EventArgs e)
        {
            user.Username = usernameTextbox.Text;
            user.Password = passwordTextbox.Text;
            if (user.Username != string.Empty && user.Password != string.Empty)
            {
                if (user.checkIfAccountInDatabase())
                {
                    publicUserName = user.Username;
                    MessageBox.Show("You will be redirected to the homepage, Login Success");
                    PositiveAffirmations pa = new PositiveAffirmations();
                    pa.Show();
                }
                else
                {
                    MessageBox.Show("NO ACCOUNT REGISTERED IN THAT USERNAME AND PASSWORD");
                }
            }
            else
            {
                user.requiredFieldShow(user.Username, requiredFirst);
                user.requiredFieldShow(user.Password, requiredPass);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTextbox.Text;
            user.requiredFieldShow(user.Username,requiredFirst);
           


        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextbox.Text;
            user.requiredFieldShow(user.Password, requiredPass);
        }
    }
}
