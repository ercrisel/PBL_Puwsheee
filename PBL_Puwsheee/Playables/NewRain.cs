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
using System.Media;

namespace PBL_Puwsheee.Playables
{
    public partial class NewRain : Form
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

        public NewRain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SoundPlayer rain = new SoundPlayer(PBL_Puwsheee.Properties.Resources.Rain_sounds);

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
            rain.Stop();
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            Fade.closeFade(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        private void play_Click(object sender, EventArgs e)
        {
            rain.Play();
            rain.PlayLooping();
            playButton.Visible = false;
            pauseButton.BringToFront();
            pauseButton.Visible = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            rain.Stop();
            playButton.Visible = true;
            pauseButton.Visible = false;
            pauseButton.SendToBack();
        }
    }
}
