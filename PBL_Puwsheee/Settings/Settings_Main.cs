using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
    {
        public Settings_Main()
        {
            InitializeComponent();
        }

        private void clickClearData(object sender, EventArgs e)
        {
            Form bg = new Form();
            using (Form settings = new Clear_Data())
            {
                bg.StartPosition = FormStartPosition.CenterScreen;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = .50d;
                bg.BackColor = Color.Black;
                bg.WindowState = FormWindowState.Normal;
                bg.TopMost = true;
                bg.Location = this.Location;
                bg.ShowInTaskbar = false;
                bg.Size = new Size(1237, 622);
                bg.Show();
                
                settings.Owner = bg;
                settings.ShowDialog();
                bg.Dispose();
            }
        }

        private void clickDeactivateAccount(object sender, EventArgs e)
        {
            new Deactivate_Account().Show();
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
