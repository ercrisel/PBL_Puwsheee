using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Playables
{
    public partial class Playables_Main : Form
    {

        public Playables_Main()
        {
            InitializeComponent();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Breathing_Exercise be = new Breathing_Exercise() { TopLevel = false, TopMost = true };
            this.playPanel.Controls.Add(be);
            be.BringToFront();
            be.Show();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            Calming_Music cm = new Calming_Music { TopLevel = false, TopMost = true };
            this.playPanel.Controls.Add(cm);
            cm.BringToFront();
            cm.Show();
        }
    }
}
