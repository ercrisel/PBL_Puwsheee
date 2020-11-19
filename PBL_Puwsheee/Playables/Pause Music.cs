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
    public partial class Pause_Music : Form
    {
        WindowsMediaPlayer rain = new WindowsMediaPlayer();

        public Pause_Music()
        {
            InitializeComponent();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            rain.controls.stop();
            rain.close();
        }
    }
}
