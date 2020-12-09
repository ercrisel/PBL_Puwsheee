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
    public partial class PositiveAffirmations : Form
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


        public PositiveAffirmations()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        int count = 70;

        private void CloseForm(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Enabled = false;
                fadeOut.Enabled = true;
                return;
            }

            count -= 1;
        } 

        private void fadeOutTick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                fadeOut.Enabled = false;
                Main main = new Main();
                main.Show();
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
                timer1.Enabled = true;
                return;
            }
            this.Opacity += 0.01;
        }

        private void PositiveAffirmations_Load(object sender, EventArgs e)
        {
          
            Random rand = new Random();
           
            string[] affirmation =
            {
                "I am doing my Best.",
                "I choose to be Happy and to Love Myself Today",
                "My Possibilities are Endless",
                "I am in Love with Myself and my Body.",
                "I am Proud of Myself.",
                "I am becoming more Confident everyday.",
                "I believe in Myself.",
                "I am Brave, Bold, and Beautiful.",
                "I am Worthy.",
                "Today is going to be a Great Day.",
                "I am Grateful for All that I have.",
                "My Thoughts become my Reality.",
                "I am Free of Worry and Regret.",
                "I am Talented and Intelligent.",
                "I believe in Me.",
                "I acknowledge my own Self-worth; my Confidence is Soaring.",
                "I am not my Mistakes.",
                "I accept Myself Unconditionally.",
                "I am Enough.",
                "I believe in the Person I dream of Becoming.",
                "Positivity is a choice; I choose to be positive.",
                "I am now creating my Live exactly as I want it.",
                "There is no wrong Decision.",
                "I Honor my Commitments to Myself.",
                "I Love Myself."
            };

            int rand_affirmation = rand.Next(affirmation.Length);
        }

        private void PositiveAffirmations_Load_1(object sender, EventArgs e)
        {
            string greetings = label1.Text;
            label1.Text = greetings.Replace("USERNAME", Log_In.publicUserName);
        }
    }
}
