using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PBL_Puwsheee.Authentication.Class;

namespace PBL_Puwsheee.Settings
{
    
    public partial class Deactivate_Account : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Deactivate_Account()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ChangeSettings cs = new ChangeSettings();
            // storeprocedure na mag dedelete ng account kekbye
            string usernameToDelete = Log_In.publicUserName;
            cs.Username = usernameToDelete;
            cs.DeactivateAccount();
            // paki dala si user sa login na form ty     

            Log_In mainForm = new Log_In();
            mainForm.Show();
            this.Close();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "Settings_Main" || Application.OpenForms[i].Name == "Main")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
