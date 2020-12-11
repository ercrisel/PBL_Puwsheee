using PBL_Puwsheee.Authentication.Class;
using PBL_Puwsheee.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    public partial class Main : Form
    {
        //🌻💛🔆🧸💕 babe: check out constructor Main() for the username 💕🧸🔆💛🌻

        ChangeSettings user = new ChangeSettings();
        UserInfo userInfo;

        private Form activeForm;

        #region For Rounded Corners
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
        #endregion
        #region Double Buffers
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

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        #endregion  

        public Main()
        {
            InitializeComponent();
            userInfo = new UserInfo() { Username =  Log_In.publicUserName }; //sets up userInfo !!!!!! wee woo wee woo !!!!!! enter username first before you run; or idk, pwede niyo rin run ng wala, iz just that walang ipapakita
            openChildForm(new MoodTracker(userInfo));
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            #region Double Buffer Functionality
            this.DoubleBuffered = true;
            enableDoubleBuff(displayPanel);
            enableDoubleBuff(bgPanel);
            enableDoubleBuff(navBarPanel);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            #endregion
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string username = Log_In.publicUserName;
            usernameLabel.Text = username;
            user.Username = username;
            user.LoadPicture(usericonPicture);
            user.Username = Log_In.publicUserName;
            userInfo.Username = Log_In.publicUserName;
            TestScore ts = new TestScore();
            ts.Username = Log_In.publicUserName;

            #region Load images
            moodtrackerButton.Image = PBL_Puwsheee.Properties.Resources.Mood_Tracker;
            calendarButton.Image = PBL_Puwsheee.Properties.Resources.Calendar;
            analysisButton.Image = PBL_Puwsheee.Properties.Resources.Analysis;
            testButton.Image = PBL_Puwsheee.Properties.Resources.Test;
            playablesButton.Image = PBL_Puwsheee.Properties.Resources.calmm;
            settingsButton.Image = PBL_Puwsheee.Properties.Resources.sett;
            chartsButton.BackgroundImage = PBL_Puwsheee.Properties.Resources.chartsIcon;
            #endregion
        }

        private void openChildForm(Form childForm)
        {
            displayPanel.Visible = true;
            bgPanel.Visible = true;
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            //childForm.TopMost = true;
            this.displayPanel.Controls.Add(childForm);
            this.displayPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void clickMoodTracker(object sender, EventArgs e)
        {
            openChildForm(new MoodTracker(userInfo));
            moodtrackerButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 61;
            #region Back to original color
            calendarButton.BackColor = Color.FromArgb(33, 21, 41);
            analysisButton.BackColor = Color.FromArgb(33, 21, 41);
            testButton.BackColor = Color.FromArgb(33, 21, 41);
            playablesButton.BackColor = Color.FromArgb(33, 21, 41);
            chartsButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main(userInfo));
            calendarButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 125;
            #region Back to original color
            moodtrackerButton.BackColor = Color.FromArgb(33, 21, 41);
            analysisButton.BackColor = Color.FromArgb(33, 21, 41);
            testButton.BackColor = Color.FromArgb(33, 21, 41);
            playablesButton.BackColor = Color.FromArgb(33, 21, 41);
            chartsButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }

        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis(userInfo));
            analysisButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 191;
            #region Back to original color
            calendarButton.BackColor = Color.FromArgb(33, 21, 41);
            moodtrackerButton.BackColor = Color.FromArgb(33, 21, 41);
            testButton.BackColor = Color.FromArgb(33, 21, 41);
            playablesButton.BackColor = Color.FromArgb(33, 21, 41);
            chartsButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
            testButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 325;
            #region Back to original color
            moodtrackerButton.BackColor = Color.FromArgb(33, 21, 41);
            calendarButton.BackColor = Color.FromArgb(33, 21, 41);
            analysisButton.BackColor = Color.FromArgb(33, 21, 41);
            playablesButton.BackColor = Color.FromArgb(33, 21, 41);
            chartsButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            Playables.NewPlayables playables= new Playables.NewPlayables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2ShadowPanel1.Controls.Add(playables);
            playables.Show();
            displayPanel.Visible = false;
            bgPanel.Visible = false;

            playablesButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 385;
            #region Back to original color
            chartsButton.BackColor = Color.FromArgb(33, 21, 41);
            moodtrackerButton.BackColor = Color.FromArgb(33, 21, 41);
            calendarButton.BackColor = Color.FromArgb(33, 21, 41);
            analysisButton.BackColor = Color.FromArgb(33, 21, 41);
            testButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }

        private void clickVisualization(object sender, EventArgs e)
        {
            openChildForm(new MainVisualization());
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void clickOptions(object sender, EventArgs e)
        {
            #region Form Background
            Form bg = new Form();
            Form settings = new Settings.Settings_Main();
            bg.StartPosition = FormStartPosition.CenterScreen;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.Opacity = .50d;
            bg.BackColor = Color.Black;
            bg.WindowState = FormWindowState.Normal;
            bg.TopMost = true;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Size = new Size(1020, 610);
            bg.Show();
            #endregion

            settings.Owner = bg;
            settings.ShowDialog();
            bg.Dispose();

            /*this.Hide();
            var form = new Settings.Settings_Main();
            form.Closed += (s, args) => this.Close();
            form.Show(); */
        }

        private void minimizePuwshee(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizePuwshee(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Sliding Panel (might not use this anymore)
        private void navBarPanelHover(object sender, EventArgs e)
        {
          //  animateTimer.Start();
          //  tm.Start();
        }

        bool hided = true;
        bool small = false;

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

            }
            else
            {

                navBarPanel.Width -= 25;

                if (navBarPanel.Width <= 86)
                {
                    animateTimer.Stop();
                    hided = true;
                }
            }
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (!small)
            {
                bgPanel.Width -= 20;
                if (bgPanel.Width <= 832)
                {
                    tm.Stop();
                    small = true;
                }

                /*
                bgPanel.Width += 45;

                if (bgPanel.Width >= 917)
                {
                    tm.Stop();
                } */
            }
            else
            {
                bgPanel.Width += 20;
                if (bgPanel.Width >= 910)
                {
                    tm.Stop();
                    small = false;
                }

                /*
                bgPanel.Width -= 35;
                if (bgPanel.Width <= 806)
                {
                    tm.Stop();
                } */
            }

        }
        #endregion  

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            Fade.exitFade(this);
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartsButton_Click(object sender, EventArgs e)
        {
            Charts charts = new Charts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2ShadowPanel1.Controls.Add(charts);
            charts.Show();

            displayPanel.Visible = false;
            bgPanel.Visible = false;

            chartsButton.BackColor = Color.FromArgb(86, 75, 97);
            indicator.Top = 256;

            #region Back to original color
            playablesButton.BackColor = Color.FromArgb(33, 21, 41);
            moodtrackerButton.BackColor = Color.FromArgb(33, 21, 41);
            calendarButton.BackColor = Color.FromArgb(33, 21, 41);
            analysisButton.BackColor = Color.FromArgb(33, 21, 41);
            testButton.BackColor = Color.FromArgb(33, 21, 41);
            #endregion
        }
    }
}
