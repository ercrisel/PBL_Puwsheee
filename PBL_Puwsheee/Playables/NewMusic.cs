﻿using System;
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
    public partial class NewMusic : Form
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

        SoundPlayer music = new SoundPlayer(PBL_Puwsheee.Properties.Resources.And_So_It_Begins___Artificial_Music);

        public NewMusic()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            #region Load images
            musicBg.Image = PBL_Puwsheee.Properties.Resources.musicBackground;
            playButton.Image = PBL_Puwsheee.Properties.Resources.musicPlay;
            pauseButton.Image = PBL_Puwsheee.Properties.Resources.musicPause;
            backButton.Image = PBL_Puwsheee.Properties.Resources.musicClose;
            #endregion
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            Fade.fadeInEffect(this, fadeIn);
            music.Stop();
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            Fade.closeFade(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            music.Stop();
            fadeOut.Start();
        }

        private void play_Click(object sender, EventArgs e)
        {
            music.Play();
            music.PlayLooping();
            playButton.Visible = false;
            pauseButton.BringToFront();
            pauseButton.Visible = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            music.Stop();
            playButton.Visible = true;
            pauseButton.Visible = false;
            pauseButton.SendToBack();
        }
    }
}
