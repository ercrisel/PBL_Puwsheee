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
        public Test_Results(string test, int score)
        {
            InitializeComponent();
            testresultLabel.Text = test;
            currentscoreLabel.Text = score.ToString();
            currentscoreProgressBar.Value = score;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Test.Test_Questions newform = (Test_Questions)Application.OpenForms["Test_Questions"];
            newform.Close();
            this.Close();
        }

        private void Test_Results_Load(object sender, EventArgs e)
        {

        }
    }
}
