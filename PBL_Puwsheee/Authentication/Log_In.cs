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

        private void signupButton_Click(object sender, EventArgs e)
        {
            new Sign_Up().Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            user.Username = usernameTextbox.Text;
            user.Password = passwordTextbox.Text;
            user.checkIfAccountInDatabase();
            if (user.checkIfAccountInDatabase())
            {
                MessageBox.Show("You will be redirected to the homepage, Login Success");
                PositiveAffirmations pa = new PositiveAffirmations();
                pa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Account");
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
           
           

        }
    }
}
