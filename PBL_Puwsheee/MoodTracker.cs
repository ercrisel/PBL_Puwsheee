using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PBL_Puwsheee
{
    public partial class MoodTracker : Form
    {
        public MoodTracker()
        {
            InitializeComponent();
        }

        private void moodIcon_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            labelMood.Text = btn.Tag.ToString();
        }

        private void moodIcon_MouseLeave(object sender, EventArgs e)
        {
            labelMood.Text = "";
        }

        private void activitiesIcon_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            labelActivities.Text = btn.Tag.ToString();
        }

        private void activitiesIcon_MouseLeave(object sender, EventArgs e)
        {
            labelActivities.Text = "";
        }
    }
}
