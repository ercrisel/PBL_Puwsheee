using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PBL_Puwsheee.Playables
{
    public partial class Calming_Music : Form
    {
        WindowsMediaPlayer rain = new WindowsMediaPlayer();

        public Calming_Music()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            rain.URL = "Rain Ambience.mp3";
            rain.controls.play();
            //rainGif.BringToFront();
            rainGif.Visible = true;
            pauseButton.BringToFront();
            pauseButton.Visible = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            rain.controls.stop();
            rain.close();
            rainGif.Visible = false;
            pauseButton.Visible = false;
            pauseButton.SendToBack();
        }
    }
}
