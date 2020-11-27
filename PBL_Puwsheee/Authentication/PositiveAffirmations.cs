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

namespace PBL_Puwsheee
{
    public partial class PositiveAffirmations : Form
    {
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


        public PositiveAffirmations()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        int count = 70;

        private void CloseForm(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Enabled = false;
                fadeOut.Enabled = true;
                return;
            }

            count -= 1;
        } 

        private void fadeOutTick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                fadeOut.Enabled = false;
                Main main = new Main();
                main.Show();
                this.Hide();
                return;
            }
            this.Opacity -= 0.01;
        }

        private void fadeInTick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                fadeIn.Enabled = false;
                timer1.Enabled = true;
                return;
            }
            this.Opacity += 0.01;
        }
    }
}
