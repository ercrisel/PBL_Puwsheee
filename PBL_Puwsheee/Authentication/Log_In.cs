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

namespace PBL_Puwsheee
{
    public partial class Log_In : Form
    {
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            PositiveAffirmations pa = new PositiveAffirmations();
            pa.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
            this.Close();
        }
    }
}
