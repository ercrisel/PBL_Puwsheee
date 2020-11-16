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

namespace PBL_Puwsheee.Calendar
{
    public partial class Calendar_Card : Form
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

        public Calendar_Card()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Remove_Entry remove = new Remove_Entry();
            remove.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Edit_Entry edit = new Edit_Entry();
            edit.Show();
        }
    }
}
