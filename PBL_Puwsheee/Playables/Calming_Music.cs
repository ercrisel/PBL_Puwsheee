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
using System.Media;

namespace PBL_Puwsheee.Playables
{
    public partial class Calming_Music : Form
    {
        //WindowsMediaPlayer rain = new WindowsMediaPlayer();
        SoundPlayer rain = new SoundPlayer(PBL_Puwsheee.Properties.Resources.Rain_sounds);

        public Calming_Music()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            
            //rain.URL = "Rain Ambience.mp3";
            rain.Play();
            rain.PlayLooping();
            //rainGif.BringToFront();
            rainGif.Visible = true;
            pauseButton.BringToFront();
            pauseButton.Visible = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            rain.Stop();
            rainGif.Visible = false;
            pauseButton.Visible = false;
            pauseButton.SendToBack();
        }

        private void rainGif_Click(object sender, EventArgs e)
        {

        }
    }
}
