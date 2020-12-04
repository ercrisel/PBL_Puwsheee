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

        //protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        //{
        //    get
        //    {
        //        CreateParams handleparam = base.CreateParams;
        //        handleparam.ExStyle |= 0x02000000;
        //        return handleparam;
        //    }
        //}

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        //internal static class NativeWinAPI
        //{
        //    internal static readonly int GWL_EXSTYLE = -20;
        //    internal static readonly int WS_EX_COMPOSITED = 0x02000000;

        //    [DllImport("user32")]
        //    internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        //    [DllImport("user32")]
        //    internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        //}

        public Main()
        {
            InitializeComponent();
            openChildForm(new MoodTracker());
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.DoubleBuffered = true;
            enableDoubleBuff(displayPanel);
            enableDoubleBuff(bgPanel);
            enableDoubleBuff(navBarPanel);
            enableDoubleBuff(navBarIconsPanel);
            enableDoubleBuff(settingsPanel);

            //int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            //style |= NativeWinAPI.WS_EX_COMPOSITED;
            //NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //string username = Log_In.publicUserName;
            //usernameLabel.Text = username;
            //user.Username = username;
            //user.LoadPicture(usericonPicture);
            indicatorButton.Location = new Point(46, 54);
        }

        private void openChildForm(Form childForm)
        {
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
            openChildForm(new MoodTracker());
            indicatorButton.Location = new Point(46, 54);
        }

        private void clickCalendar(object sender, EventArgs e)
        {
            openChildForm(new Calendar_Main());
            indicatorButton.Location = new Point(46, 110);
        }
        
        private void clickAnalysis(object sender, EventArgs e)
        {
            openChildForm(new Analysis());
            indicatorButton.Location = new Point(46, 168);
        }

        private void clickTest(object sender, EventArgs e)
        {
            openChildForm(new Test.Test_Main());
            indicatorButton.Location = new Point(46, 232);
        }

        private void clickPlayables(object sender, EventArgs e)
        {
            openChildForm(new Playables.NewPlayables());
            indicatorButton.Location = new Point(46, 292);
        }

        private void clickVisualization(object sender, EventArgs e)
        {
            openChildForm(new MainVisualization());
            indicatorButton.Location = new Point(46, 346);
        }

        private void exitPuwshee(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void clickOptions(object sender, EventArgs e)
        {
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

        private void navBarPanelHover(object sender, EventArgs e)
        {
            animateTimer.Start();
            tm.Start();
      
        }

        bool hided = true;
        bool small = false;

        private void animateTimer_Tick(object sender, EventArgs e)
        {
            if(hided)
            {
                if (settingsLabel.Left <= 63) settingsLabel.Left += 10;
             //   if (bgPanel.Width >= 806) bgPanel.Width -= 22;
                if (bgPanel.Location.X <= 201) bgPanel.Location = new Point(bgPanel.Location.X + 22, 40); //bgPanel.Left += 22;

                navBarPanel.Width += 25;

                if(navBarPanel.Width >= 165)
                {
                    animateTimer.Stop();
                    hided = false; 
                }

            }
            else
            {
                if (settingsLabel.Left >= 17) settingsLabel.Left -= 10;
            //    if (bgPanel.Width <= 917) bgPanel.Width += 22;
                if (bgPanel.Location.X >= 89) bgPanel.Location = new Point(bgPanel.Location.X - 22, 40);//bgPanel.Left -= 22;


                navBarPanel.Width -= 25;

                if (navBarPanel.Width <= 86)
                {
                    animateTimer.Stop();
                    hided = true;
                }
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

        // eto code
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

    }
}
