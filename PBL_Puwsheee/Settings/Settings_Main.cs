using PBL_Puwsheee.Authentication.Class;
using PBL_Puwsheee.Authentication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Settings
{
    public partial class Settings_Main : Form
    {
        MainLoad user = new MainLoad();
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
            Console.WriteLine("second lng ako");
            //  PAG LOAD DAPAT NAKALOAD NA YUNG DATA
            user.Username = Log_In.publicUserName;
            user.LoadPicture(userPicture); // load yung picture sa settings 
            user.LoadAllUserInformation(firstnameTextbox, lastnameTextbox, emailTextbox, usernameTextbox); // ANDITO YUNG USERINFOS GAGO
            
            // dito naten store si CURRENT NA USERNAME AT PASSWORD
         
           
        
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

        private void savechangesButton_Click(object sender, EventArgs e)
        {
            
          
         
        }
   
        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
           // if unique
       
        }

        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (user.FirstName == firstnameTextbox.Text)
            {
                savechangesButton.Enabled = false;
            }
            if (user.FirstName != firstnameTextbox.Text)
            {
                savechangesButton.Enabled = true;
            }
        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (user.LastName == lastnameTextbox.Text)
            {
                savechangesButton.Enabled = false;
            }
            if (user.LastName != lastnameTextbox.Text)
            {
                savechangesButton.Enabled = true;
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            // if unique

        }
    }
}
