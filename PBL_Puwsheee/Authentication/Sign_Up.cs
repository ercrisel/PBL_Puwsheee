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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Log_In login = new Log_In();
            login.Show();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            PositiveAffirmations pa = new PositiveAffirmations();
            pa.Show();
            this.Close();
        }
    }
}
