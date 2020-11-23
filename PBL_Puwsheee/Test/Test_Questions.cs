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

namespace PBL_Puwsheee.Test
{
    public partial class Test_Questions : Form
    {
        public Test_Questions(string Test)
        {
            InitializeComponent();
            this.Text = Test;
        }

        public Boolean checkValidation()
        {
            Boolean rbChecked = false;
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                rbChecked = false;
                foreach(Guna2CustomRadioButton rb in panel.Controls.OfType<Guna2CustomRadioButton>())
                {
                    if (rb.Checked == true)
                    {
                        rbChecked = true;
                        break;
                    }
                }
                if (rbChecked == false)
                {
                    MessageBox.Show("CHECK MO MGA BOX TANGINA NAMAN");
                    break;
                }
            }
            return rbChecked;
        }

        public int computeScore()
        {
            int sum = 0;
            foreach(Panel panel in this.Controls.OfType<Panel>())
            {
                Guna2CustomRadioButton rd = panel.Controls.OfType<Guna2CustomRadioButton>()
                    .FirstOrDefault(r => r.Checked);
                sum += int.Parse(rd.Tag.ToString());
            }
            return sum;
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
                    bg.Size = new Size(1020, 580);
                    bg.Show();

                    TestResults.Owner = bg;
                    TestResults.ShowDialog();
                    bg.Dispose();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            var cntls =  GetAll(this, typeof(Guna2CustomRadioButton));
            foreach(Control cntrl in cntls)
            {
                Guna2CustomRadioButton _rb = (Guna2CustomRadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void Test_Questions_Load(object sender, EventArgs e)
        {
            typeoftestLabel.Text = this.Text;

            if (typeoftestLabel.Text == "Anxiety and Depression")
            {
                question1Label.Text = "I feel tired out for no good reason.";
                question2Label.Text = "I feel nervous.";
                question3Label.Text = "I feel restless or fidgety.";
                question4Label.Text = "I feel so nevous that nothing could calm you down?";
                question5Label.Text = "I feel hopeless.";
                question6Label.Text = "I feel so restless I could not sit still?";
                question7Label.Text = "I feel depressed.";
                question8Label.Text = "I feel that everything was an effort.";
                question9Label.Text = "I feel so sad that nothing could cheer you up.";
                question10Label.Text = "I feel worthless.";
            }

            else if (typeoftestLabel.Text == "Emotional Intelligence")
            {
                question1Label.Text = "I recognize my emotions as I experience them.";
                question2Label.Text = "I lose my temper when I feel frustrated.";
                question3Label.Text = "People have told me that I'm a good listener.";
                question4Label.Text = "I know how to calm myself down when I feel anxious or upset.";
                question5Label.Text = "I enjoy organizing groups.";
                question6Label.Text = "I find it hard to focus on something ove the long term.";
                question7Label.Text = "I find it difficult to move on when I feel frustrated or unhappy.";
                question8Label.Text = "I know my strengths and weaknesses.";
                question9Label.Text = "I avoid conflict and negotiations.";
                question10Label.Text = "I feel that I don't enjoy my work.";
            }

            else if (typeoftestLabel.Text == "Good Self-Care")
            {
                question1Label.Text = "I get enough sleep.";
                question2Label.Text = "I make time to be with my thoughts and self-reflect.";
                question3Label.Text = "I say no to extra responsibilities when my plate is already full.";
                question4Label.Text = "I allow myself to show emotions.";
                question5Label.Text = "I ask for help if I need it.";
                question6Label.Text = "I make quiet time for myself to complete necessary tasks";
                question7Label.Text = "I strive for balance among work, family, relationships, play and rest.";
                question8Label.Text = "I spend time with my pets or in spaces in which I feel comfortable.";
                question9Label.Text = "I love myself and give myself positive affirmations";
                question10Label.Text = "I spend time with people who make me happy.";
            }

        }

        private void clickBack(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
