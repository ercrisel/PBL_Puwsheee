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

namespace PBL_Puwsheee
{
    public partial class Log_In : Form
    {
        LogIn user = new LogIn();
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

        public static string publicUserName;
        public static string publicPasswordInput;
        public Log_In()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            new Sign_Up().Show();
            this.Close();
        }

        public bool conditions()
        {
            bool conditionsMet = false;
            if (requiredUsername.Visible == false && requiredPassword.Visible == false && usernameTextbox.Text!= string.Empty && passwordTextbox.Text != string.Empty)
            {
                conditionsMet = true;
            }
            return conditionsMet;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            user.Username = usernameTextbox.Text;
            user.Password = passwordTextbox.Text;
            if (conditions())
            {
                if (user.checkIfAccountInDatabase())
                {
                    publicUserName = user.Username;
                    publicPasswordInput = user.Password;
                    MessageBox.Show("You will be redirected to the homepage, Login Success");
                    
                    fadeOut.Start();
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
                user.requiredFieldShow(usernameTextbox.Text, requiredUsername);
                user.requiredFieldShow(passwordTextbox.Text, requiredPassword);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fadeOut.Start();
        }
        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTextbox.Text;
            user.requiredFieldShow(usernameTextbox.Text, requiredUsername);
            
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextbox.Text;
            user.requiredFieldShow(passwordTextbox.Text, requiredPassword);
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                fadeOut.Enabled = false;
                Sign_Up su = new Sign_Up();
                su.Show();
                this.Hide();
            }
            this.Opacity -= .2;
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //omg
        }

    }
}
