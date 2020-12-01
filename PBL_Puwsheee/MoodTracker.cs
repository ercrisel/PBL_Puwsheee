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
            enableDoubleBuff(moodPanel);
            enableDoubleBuff(activitiesPanel);
        }

        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var moodButton in moodPanel.Controls.OfType<Guna2Button>())
            {
                Guna2Button mood = (Guna2Button)moodButton;
                if (mood.Checked == true)
                {
                    mood.Checked = false;
                }
            }

            foreach(var actButton in activitiesPanel.Controls.OfType<Guna2Button>())
            { 
                Guna2Button act = (Guna2Button)actButton;
                if (act.Checked == true)
                {
                    act.Checked = false;
                }
            }

            notesTextbox.Text = "";
        }

        private void angryIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
