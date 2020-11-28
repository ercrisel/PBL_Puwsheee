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
    public partial class NewPlayables : Form
    {
        public NewPlayables()
        {
            InitializeComponent();
        }

        private void breathingButton_Click(object sender, EventArgs e)
        {
            NewBreathing breathingForm = new NewBreathing();
            breathingForm.Show();
        }
    }
}
