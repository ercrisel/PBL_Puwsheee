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
    public partial class SplashScreen : Form
    {
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

        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void countdownTick(object sender, EventArgs e)
        {
            loadingPanel.Width += 3;
            if (loadingPanel.Width >= loadingbasisPanel.Width)
            {
                countdown.Enabled = false;
                fadeOut.Enabled = true;
                return;
            }
        }

        private void fadeOutTick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                fadeOut.Enabled = false;
                Log_In logIn = new Log_In();
                logIn.Show();
                this.Hide();
                return;
            }
            this.Opacity -= 0.01;
        }

        private void fadeInTick(object sender, EventArgs e)
        {

            if (this.Opacity == 1)
            {
                fadeIn.Enabled = false;
                countdown.Enabled = true;
                return;
            }
            this.Opacity += 0.01;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
           this.BackgroundImage = PBL_Puwsheee.Properties.Resources.Splashscreen;
        }

    }
}
