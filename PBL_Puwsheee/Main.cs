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

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        bool hided = true;

        public Main()
        {
            InitializeComponent();
            openChildForm(new MoodTracker());
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.DoubleBuffered = true;
            enableDoubleBuff(displayPanel);
        }

        private void Main_Load(object sender, EventArgs e)
        {
           // string username = Log_In.publicUserName;
           // usernameLabel.Text = username;
          //  user.Username = username;
            //user.LoadPicture(usericonPicture);
            indicatorButton.Location = new Point(47, 131);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            this.displayPanel.Controls.Add(childForm);
            this.displayPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void clickMoodTracker(object sender, EventArgs e)
        {
            openChildForm(new MoodTracker());
            indicatorButton.Location = new Point(47, 131);
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main());
            indicatorButton.Location = new Point(47, 186);
        }
        
        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis());
            indicatorButton.Location = new Point(44, 244);
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
            indicatorButton.Location = new Point(47, 309);
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            openChildForm(new Playables.Playables_Main());
            indicatorButton.Location = new Point(47, 369);
        }

        private void clickVisualization(object sender, EventArgs e)
        {
            openChildForm(new MainVisualization());
            indicatorButton.Location = new Point(47, 428);
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            fadeOut.Start();
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

        private void navBarPanelHover(object sender, EventArgs e)
        {
            animateTimer.Start();
        }

        private void animateTimer_Tick(object sender, EventArgs e)
        {
            if(hided)
            {
                navBarPanel.Width += 25;

                if(navBarPanel.Width >= 165)
                {
                    animateTimer.Stop();
                    hided = false; 
                }

                if (settingsLabel.Left <= 63) settingsLabel.Left += 10;
                if (bgPanel.Width >= 806) bgPanel.Width -= 22;
                if (bgPanel.Left <= 201) bgPanel.Left += 22;
            }
            else
            {
                navBarPanel.Width -= 25;

                if (navBarPanel.Width <= 86)
                {
                    animateTimer.Stop();
                    hided = true;
                }

                if (settingsLabel.Left >= 17) settingsLabel.Left -= 10;
                if (bgPanel.Width <= 917) bgPanel.Width += 22;
                if (bgPanel.Left >= 89) bgPanel.Left -= 22; 
            }
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            Fade.exitFade(this);
        }
    }
}
