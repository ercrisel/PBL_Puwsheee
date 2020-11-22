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
    public partial class Main : Form
    {
        private Form activeForm;
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

        public Main()
        {
            InitializeComponent();
            openChildForm(new MoodTracker());
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            indicatorButton.Location = new Point(57, 160);
            pageLabel.Location = new Point(108, 35);
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
            indicatorButton.Location = new Point(57, 160);
            pageLabel.Location = new Point(108, 35);
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main());
            indicatorButton.Location = new Point(57, 220);
            pageLabel.Location = new Point(127, 35);
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
            indicatorButton.Location = new Point(57, 360);
            pageLabel.Location = new Point(141, 35);
        }

        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis());
            indicatorButton.Location = new Point(57, 290);
            pageLabel.Location = new Point(130, 35);
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            openChildForm(new Playables.Playables_Main());
            indicatorButton.Location = new Point(57, 430);
            pageLabel.Location = new Point(124, 35);
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickOptions(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Settings.Settings_Main();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
