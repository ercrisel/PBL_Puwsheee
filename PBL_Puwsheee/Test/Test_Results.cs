using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Test
{
    public partial class Test_Results : Form
    {
        int currentscore = 0;

        public Test_Results(string test, int score)
        {
            InitializeComponent();
            this.Text = test;
            currentscore = score;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Test.Test_Questions newform = (Test_Questions)Application.OpenForms["Test_Questions"];
            newform.Close();
            this.Close();
        }

        private void Test_Results_Load(object sender, EventArgs e)
        {
            if(this.Text == "Anxiety and Depression")
            {
                if(currentscore >= 1 && currentscore <= 15)
                {
                    Description1Label.Text = "Your score falls into the low range. " +
                        "This means you're doing pretty well!" +
                        "It's important to remember that this result is not a diagnosis. " +
                        "If you feel down, sad, stressed or anxious, " +
                        "you might want to speak to your GP or redo the checklist in a few weeks.";
                }
                else if(currentscore >= 16 && currentscore <= 29)
                {
                    Description1Label.Text = "Your score falls into the moderate range, " +
                        "which means you may be experiencing mild depression and/or anxiety. " +
                        "We suggest you see your GP or health professional for a more personalised assessment." + 
                        "Depression and anxiety are common conditions, " +
                        "and the good news is that there are treatments and support options that work. " +
                        "It’s important to seek help early – the sooner you talk to someone, " +
                        "the sooner you'll be on the road to recovery.";
                }
                else if(currentscore >= 30 && currentscore <= 50)
                {
                    Description1Label.Text = "Your score falls into the high range, " +
                        "which means you could be experiencing depression and/or anxiety. " +
                        "We strongly recommend that you see your GP or health professional for a more personalised assessment." +
                        "Depression and anxiety are common conditions, " +
                        "and the good news is that there are treatments and support options that work. " +
                        "It’s important to seek help early –  the sooner you get treatment, the sooner you can recover.";
                }
            }
            else if(this.Text == "Emotional Intelligence")
            {
                if (currentscore >= 1 && currentscore <= 15)
                {
                    Description1Label.Text = "You need to work on your emotional intelligence. " +
                        "You may find that you feel overwhelmed by your emotions, " +
                        "especially in stressful situations; " +
                        "or, you may avoid conflict because you think that you'll find it distressing. " +
                        "It's likely, too, that you find it hard to calm down after you've felt upset, " +
                        "and you may struggle to build strong working relationships.";
                }
                else if (currentscore >= 16 && currentscore <= 29)
                {
                    Description1Label.Text = "Your emotional intelligence level is... OK." +
                        "You probably have good relationships with some of your colleagues, but others may be more difficult to work with." +
                        "The good news is that you have a great opportunity to improve your working relationships significantly.";
                }
                else if (currentscore >= 30 && currentscore <= 50)
                {
                    Description1Label.Text = "Great! You're an emotionally intelligent person. You have great relationships, " +
                        "and you probably find that people approach you for advice." +
                        "However, when so many people admire your people skills, it's easy to lose sight of your own needs.";
                }
            }
        }

        private void animateCurrentScore(object sender, EventArgs e)
        {
            currentscoreProgressBar.Value++;
            currentscoreLabel.Text = currentscoreProgressBar.Value.ToString();
            if (currentscoreProgressBar.Value == currentscore) timer1.Stop();
        }
    }
}
