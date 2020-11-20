using PBL_Puwsheee.Authentication.Class;
using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    public partial class Main : Form
    {
        MainLoad user = new MainLoad();
        
        private Form activeForm;
        
        public Main()
        {
            InitializeComponent();
            openChildForm(new MoodTracker());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            user.Username = Log_In.publicUserName;
            usernameLabel.Text = user.Username;
            user.LoadPicture(usericonPicture);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.displayPanel.Controls.Add(childForm);
            this.displayPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pageLabel.Text = childForm.Text;
        }

        private void clickMoodTracker(object sender, EventArgs e)
        {
            openChildForm(new MoodTracker());
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main());
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
        }

        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis());
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            openChildForm(new Playables.Playables_Main());
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickOptions(object sender, EventArgs e)
        {
            new Settings.Settings_Main().Show();
            this.Close();
        }
    }
}
