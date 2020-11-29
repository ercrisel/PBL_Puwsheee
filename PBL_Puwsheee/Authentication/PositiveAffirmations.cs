using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    public partial class PositiveAffirmations : Form
    {
        public PositiveAffirmations()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Main main = new Main();
            main.Show();
            this.Close();
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
                "I believe in the Person I bream of Becoming.",
                "Positivity is a choice; I choose to be positive.",
                "I am now creating my Live exactly as I want it.",
                "There is no wrong Decision.",
                "I Honor my Commitments to Myself.",
                "I Love Myself."
            };

            int rand_affirmation = rand.Next(affirmation.Length);
        }
    }
}
