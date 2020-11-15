using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
    {
        public Settings_Main()
        {
            InitializeComponent();
        }

        private void clickClearData(object sender, EventArgs e)
        {
            new Clear_Data().Show();
        }

        private void clickDeactivateAccount(object sender, EventArgs e)
        {
            new Deactivate_Account().Show();
        }

        private void Settings_Main_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }
    }
}
