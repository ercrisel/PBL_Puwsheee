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

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
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
                bg.Size = new Size(928, 505);
                bg.Show();
                
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
                bg.Size = new Size(928, 505);
                bg.Show();

                deactivateForm.Owner = bg;
                deactivateForm.BringToFront();
                deactivateForm.ShowDialog();
                bg.Dispose();
            }
        }

        private void Settings_Main_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

        private void savechangesButton_Click(object sender, EventArgs e)
        {

        }

        private void changepasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void changephotoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
