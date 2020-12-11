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
    public partial class Test_Main : Form
    {
        TestResult result = new TestResult();
        public Test_Main()
        {
            InitializeComponent();
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

        private void depressiontestButton_Click(object sender, EventArgs e)
        {
            // date 

            string dateClicked = DateTime.Now.ToString("yyyyMMdd");
            result.Date = dateClicked;
            result.Username = Log_In.publicUserName;

            Guna2Button btn = sender as Guna2Button;
            if (result.CheckIfAlreadyAnswered(btn))
            {
                Form bg = new Form();
                using (Form Test = new Test.Test_Questions(btn.Text))
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

                    Test.Owner = bg;
                    Test.ShowDialog();
                    bg.Dispose();
                }
            }
            else
            {
                MessageBox.Show(" bawal na sagutan gago next day na lang");
            }
        }

        private void Test_Main_Load(object sender, EventArgs e)
        {
            guna2GradientPanel1.BackgroundImage = PBL_Puwsheee.Properties.Resources.selfcareImage;
            guna2GradientPanel2.BackgroundImage = PBL_Puwsheee.Properties.Resources._2ndpicture;
            guna2GradientPanel3.BackgroundImage = PBL_Puwsheee.Properties.Resources.depressionImage;
        }
    }
}

