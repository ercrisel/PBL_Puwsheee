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
            typeoftestLabel.Text = Test;
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

        }

        private void clickBack(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
