using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PBL_Puwsheee.Test
{
    public partial class Test_Questions : Form
    {
        private Form activeForm;
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

        int currentQ = 1, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, loading = 50;

        private void incrementTimer_Tick(object sender, EventArgs e)
        {
            loadingPanel.Width += 3;
            if (loadingPanel.Width >= loading) incrementTimer.Stop();
        }

        private void decrementTimer_Tick(object sender, EventArgs e)
        {
            loadingPanel.Width -= 3;
            if (loadingPanel.Width <= loading) decrementTimer.Stop();
        }

        private void changeQuestion(object sender, EventArgs e)
        {

            if ((sender as Guna2Button).Name == "incrementButton")
            {
                if (currentQ < 10)
                {
                    currentQ++;
                    loading += 50;
                    incrementTimer.Start();
                }
            }
            else if ((sender as Guna2Button).Name == "decrementButton")
            {
                if (currentQ > 1)
                {
                    currentQ--;
                    loading -= 50;
                    decrementTimer.Start();
                }
            }
            displayQuestion(currentQ);
            currentquestionTextbox.Text = "Question " + currentQ.ToString();
            this.Controls.OfType<Guna2CustomRadioButton>().ToList().ForEach(p => p.Checked = false);
            displayChoice();
        }

        private void slot5RadioButton_Click(object sender, EventArgs e)
        {
            Guna2CustomRadioButton checkedButton = sender as Guna2CustomRadioButton;
            if (currentQ == 1) Q1 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 2) Q2 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 3) Q3 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 4) Q4 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 5) Q5 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 6) Q6 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 7) Q7 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 8) Q8 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 9) Q9 = int.Parse(checkedButton.Tag.ToString());
            else if (currentQ == 10) Q10 = int.Parse(checkedButton.Tag.ToString());
        }

        private void displayChoice() 
        {
            if(currentQ == 1 && Q1 != 0) checkRb(Q1);
            else if (currentQ == 2 && Q2 != 0) checkRb(Q2);
            else if (currentQ == 3 && Q3 != 0) checkRb(Q3);
            else if (currentQ == 4 && Q4 != 0) checkRb(Q4);
            else if (currentQ == 5 && Q5 != 0) checkRb(Q5);
            else if (currentQ == 6 && Q6 != 0) checkRb(Q6);
            else if (currentQ == 7 && Q7 != 0) checkRb(Q7);
            else if (currentQ == 8 && Q8 != 0) checkRb(Q8);
            else if (currentQ == 9 && Q9 != 0) checkRb(Q9);
            else if (currentQ == 10 && Q10 != 0) checkRb(Q10);

            void checkRb(int q)
            {
                if (q == 1) slot1RadioButton.Checked = true;
                else if (q == 2) slot2RadioButton.Checked = true;
                else if (q == 3) slot3RadioButton.Checked = true;
                else if (q == 4) slot4RadioButton.Checked = true;
                else if (q == 5) slot5RadioButton.Checked = true;
            }
        }

        public Test_Questions(string Test)
        {
            InitializeComponent();
            this.Text = Test;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public Boolean checkValidation()
        {
            if(Q1 == 0 || Q2 == 0 || Q3 == 0 || Q4 == 0 || Q5 == 0 || Q6 == 0 || Q7 == 0 || Q8 == 0 || Q9 == 0 || Q10 == 0)
            {
                MessageBox.Show("Please answer all of the questions.");
                return false;
            }
            return true;
        }

        public int computeScore()
        {
            return (Q1 + Q2 + Q3 + Q4 + Q5 + Q6 + Q7 + Q8 + Q9 + Q10);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                Form bg = new Form();
                using (Form TestResults = new Test.Test_Results(typeoftestLabel.Text, computeScore()))
                {
                    bg.StartPosition = FormStartPosition.CenterScreen;
                    bg.FormBorderStyle = FormBorderStyle.None;
                    bg.Opacity = .50d;
                    bg.BackColor = Color.Black;
                    bg.WindowState = FormWindowState.Normal;
                    bg.TopMost = true;
                    bg.Location = this.Location;
                    bg.ShowInTaskbar = false;
                    bg.Size = new Size(1020, 610);
                    bg.Show();

                    TestResults.Owner = bg;
                    TestResults.ShowDialog();
                    bg.Dispose();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Q1 = 0;  
            Q2 = 0; 
            Q3 = 0;
            Q4 = 0;
            Q5 = 0;
            Q6 = 0;
            Q7 = 0;
            Q8 = 0;
            Q9 = 0;
            Q10 = 0;
        }

        private void Test_Questions_Load(object sender, EventArgs e)
        {
            typeoftestLabel.Text = this.Text;
            displayQuestion(1);
        }

        private void clickBack(object sender, EventArgs e)
        {
            this.Close();
        }

        public void displayQuestion(int num)
        {
            if (typeoftestLabel.Text == "Anxiety and Depression")
            {
                switch (num)
                {
                    case 1:
                        questionLabel.Text = "I feel tired out for no good reason.";
                        break;
                    case 2:
                        questionLabel.Text = "I feel nervous.";
                        break;
                    case 3:
                        questionLabel.Text = "I feel restless or fidgety.";
                        break;
                    case 4:
                        questionLabel.Text = "I feel so nevous that nothing could calm you down?";
                        break;
                    case 5:
                        questionLabel.Text = "I feel hopeless.";
                        break;
                    case 6:
                        questionLabel.Text = "I feel so restless I could not sit still?";
                        break;
                    case 7:
                        questionLabel.Text = "I feel depressed.";
                        break;
                    case 8:
                        questionLabel.Text = "I feel that everything was an effort.";
                        break;
                    case 9:
                        questionLabel.Text = "I feel so sad that nothing could cheer you up.";
                        break;
                    case 10:
                        questionLabel.Text = "I feel worthless.";
                        break;
                }
            }

            else if (typeoftestLabel.Text == "Emotional Intelligence")
            {
                switch (num)
                {
                    case 1:
                        questionLabel.Text = "I recognize my emotions as I experience them.";
                        break;
                    case 2:
                        questionLabel.Text = "I lose my temper when I feel frustrated.";
                        break;
                    case 3:
                        questionLabel.Text = "People have told me that I'm a good listener.";
                        break;
                    case 4:
                        questionLabel.Text = "I know how to calm myself down when I feel anxious or upset.";
                        break;
                    case 5:
                        questionLabel.Text = "I enjoy organizing groups.";
                        break;
                    case 6:
                        questionLabel.Text = "I find it hard to focus on something ove the long term.";
                        break;
                    case 7:
                        questionLabel.Text = "I find it difficult to move on when I feel frustrated or unhappy.";
                        break;
                    case 8:
                        questionLabel.Text = "I know my strengths and weaknesses.";
                        break;
                    case 9:
                        questionLabel.Text = "I avoid conflict and negotiations.";
                        break;
                    case 10:
                        questionLabel.Text = "I feel that I don't enjoy my work.";
                        break;
                }
            }

            else if (typeoftestLabel.Text == "Good Self-Care")
            {
                switch (num)
                {
                    case 1:
                        questionLabel.Text = "I get enough sleep.";
                        break;
                    case 2:
                        questionLabel.Text = "I make time to be with my thoughts and self-reflect.";
                        break;
                    case 3:
                        questionLabel.Text = "I say no to extra responsibilities when my plate is already full.";
                        break;
                    case 4:
                        questionLabel.Text = "I allow myself to show emotions.";
                        break;
                    case 5:
                        questionLabel.Text = "I ask for help if I need it.";
                        break;
                    case 6:
                        questionLabel.Text = "I make quiet time for myself to complete necessary tasks";
                        break;
                    case 7:
                        questionLabel.Text = "I strive for balance among work, family, relationships, play and rest.";
                        break;
                    case 8:
                        questionLabel.Text = "I spend time with my pets or in spaces in which I feel comfortable.";
                        break;
                    case 9:
                        questionLabel.Text = "I love myself and give myself positive affirmations";
                        break;
                    case 10:
                        questionLabel.Text = "I spend time with people who make me happy.";
                        break;
                }
            }
        }

    }
}
