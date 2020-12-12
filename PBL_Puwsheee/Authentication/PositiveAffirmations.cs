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
            
            label1.Focus();

            string greetings = label1.Text;
            label1.Text = greetings.Replace("USERNAME", Log_In.publicUserName);

            string[] affirmation =
            {
                "You Got This.",
                "One Breath at a Time",
                "There are Endless Possibilities for you to try",
                "You are Perfect just the way you are, so love yourself and your body.",
                "You should be proud of yourself.",
                "One breath at a time.",
                "You should step into the daylight and let it go.",
                "You are Loved, Endlessly loved.",
                "You will grow in due season.",
                "You are worthy of the same love you give.",
                "You will grow how you were meant to be.",
                "You are learning and growing everyday even when it does not seem that way.",
                "Pause. Breathe. Reflect. You have bloomed in beautiful ways. Don't let yourself forget.",
                "You are not a burden for having burdens.",
                "You are not always required to impress anyone with your life choices.",
                "You're allowed to pace yourself.",
                "Every single breath you breathe is proof that you are finding your way in this.",
                "You do not have to sort through everything tonight.",
                "You have not missed out on what was meant for you.",
                "You can still be who you are meant to be without meeting everyone's expectations of you.",
                "All along, you were strong.",
                "The way you speak to yourself matters.",
                "When your thought have torn at the lining of your strength, take heart, be still, there is grace for this.",
                "When you can't find the sunshine, be the sunshine.",
                "All this pain will teach you everything worth knowing."
            };

            Random random = new Random();
            //int i = random.Next(affirmation.Length);
            String affirmationDisplay = affirmation[random.Next(affirmation.Length)];
            quotation.Text = affirmationDisplay;

            PositiveAffirmationGIF.Image = PBL_Puwsheee.Properties.Resources.positiveAffirmationsGIF;
        }
    }
}
