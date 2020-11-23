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
            //TIKWAAA gawa ka nalang siguro ng method na cocomputin ung overall na mga sagot niya..
            //Stotore rin pala si current score sa database

            int low_min = 1, low_max = 15, mid_min = 16, mid_max = 29, high_min = 30, high_max = 50;

            testresultLabel.Text = this.Text + "'s Results";

            if(this.Text == "Anxiety and Depression")
            {
                if(currentscore >= low_min && currentscore <= low_max)
                {
                    DescriptionLabel.Text = "Your score falls into the low range." +
                        "This means you're doing pretty well!" +
                        "It's important to remember that this result is not a diagnosis." +
                        "If you feel down, sad, stressed or anxious," +
                        "you might want to speak to your GP or redo the checklist in a few weeks.";
                }
                else if(currentscore >= mid_min && currentscore <= mid_max)
                {
                    DescriptionLabel.Text = "Your score falls into the moderate range," +
                        "which means you may be experiencing mild depression and/or anxiety." +
                        "We suggest you see your GP or health professional for a more personalised assessment." + 
                        "Depression and anxiety are common conditions," +
                        "and the good news is that there are treatments and support options that work." +
                        "It’s important to seek help early – the sooner you talk to someone," +
                        "the sooner you'll be on the road to recovery.";
                }
                else if(currentscore >= high_min && currentscore <= high_max)
                {
                    DescriptionLabel.Text = "Your score falls into the high range," +
                        "which means you could be experiencing depression and/or anxiety. " +
                        "We strongly recommend that you see your GP or health professional for a more personalised assessment.\n" +
                        "Depression and anxiety are common conditions," +
                        "and the good news is that there are treatments and support options that work." +
                        "It’s important to seek help early –  the sooner you get treatment, the sooner you can recover.";
                }
            }
            else if(this.Text == "Emotional Intelligence")
            {
                if (currentscore >= low_min && currentscore <= low_max)
                {
                    DescriptionLabel.Text = "You need to work on your emotional intelligence." +
                        "You may find that you feel overwhelmed by your emotions," +
                        "especially in stressful situations;" +
                        "or, you may avoid conflict because you think that you'll find it distressing." +
                        "It's likely, too, that you find it hard to calm down after you've felt upset," +
                        "and you may struggle to build strong working relationships.";
                }
                else if (currentscore >= mid_min && currentscore <= mid_max)
                {
                    DescriptionLabel.Text = "Your emotional intelligence level is... OK." +
                        "You probably have good relationships with some of your colleagues, but others may be more difficult to work with." +
                        "The good news is that you have a great opportunity to improve your working relationships significantly.";
                }
                else if (currentscore >= high_min && currentscore <= high_max)
                {
                    DescriptionLabel.Text = "Great! You're an emotionally intelligent person. You have great relationships," +
                        "and you probably find that people approach you for advice." +
                        "However, when so many people admire your people skills, it's easy to lose sight of your own needs.";
                }
            }
            else if(this.Text == "Good Self-Care")
            {
                if (currentscore >= low_min && currentscore <= low_max)
                {
                    DescriptionLabel.Text = "It sounds like you may be practicing a little self-care, but could use some more guidance or ideas on how to" +
                        "best take care of myself.Remember: self - care is about taking the time to care for myself in whichever ways" +
                        "work best for you! Just start thinking about what you can do that makes you happy, and do it.";
                }
                else if (currentscore >= mid_min && currentscore <= mid_max)
                {
                    DescriptionLabel.Text = "It sounds like you are doing a good job taking care of myself! Self-care is important for your emotional, mental," +
                        "and physical well - being, so keep it up!If you’re used to doing the same techniques or methods, maybe try" +
                        "something totally new.If you usually journal your feelings, try your hand at art. If you always go for a run or do a" +
                        "physical activity, try some meditation and deep breathing exercises too.New experiences can be fun!";
                }
                else if (currentscore >= high_min && currentscore <= high_max)
                {
                    DescriptionLabel.Text = "It sounds like you know all about self-care, and are excellent at taking those few moments to focus on you!" +
                        "Keep it up! Self - care can be a really positive thing for anyone, " +
                        "especially for people who have experienced some form of trauma.";
                }
            }
        }

        private void animateCurrentScore(object sender, EventArgs e)
        {
            currentscoreProgressBar.Value++;
            currentscoreLabel.Text = currentscoreProgressBar.Value.ToString();
            if (currentscoreProgressBar.Value == currentscore) currentScoreTimer.Stop();
        }
    }
}
