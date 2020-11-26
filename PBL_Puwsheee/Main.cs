using PBL_Puwsheee.Authentication.Class;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    public partial class Main : Form
    {
        ChangeSettings user = new ChangeSettings();
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
            string username = Log_In.publicUserName;
            usernameLabel.Text = username;
            user.Username = username;
            user.LoadPicture(usericonPicture);
            indicatorButton.Location = new Point(57, 160);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pan.Controls.Add(childForm);
            this.pan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void clickMoodTracker(object sender, EventArgs e)
        {
            openChildForm(new MoodTracker());
            indicatorButton.Location = new Point(57, 178);
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main());
            indicatorButton.Location = new Point(57, 233);
        }
        
        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis());
            indicatorButton.Location = new Point(57, 291);
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
            indicatorButton.Location = new Point(57, 356);
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            openChildForm(new Playables.Playables_Main());
            indicatorButton.Location = new Point(57, 416);
        }

        private void clickVisualization(object sender, EventArgs e)
        {
            openChildForm(new MainVisualization());
            indicatorButton.Location = new Point(57, 475);
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void clickOptions(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Settings.Settings_Main();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void minimizePuwshee(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void maximizePuwshee(object sender, EventArgs e)
        {
            Control.DoFullscreen(this);
        }
    }
}
