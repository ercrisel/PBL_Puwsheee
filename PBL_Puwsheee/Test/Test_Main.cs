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
    public partial class Test_Main : Form
    {
        public Test_Main()
        {
            InitializeComponent();
        }

        private void anxietytestButton_Click(object sender, EventArgs e)
        {
            new Test.Test_Question(anxietytestButton.Text).Show();
            this.Close();
        }

        private void stresstestbutton_Click(object sender, EventArgs e)
        {
            new Test.Test_Question(stresstestbutton.Text).Show();
            this.Close();
        }

        private void depressiontestButton_Click(object sender, EventArgs e)
        {
            new Test.Test_Question(depressiontestButton.Text).Show();
            this.Close();
        }
    }
}
