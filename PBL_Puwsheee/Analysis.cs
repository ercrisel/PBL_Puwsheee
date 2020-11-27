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
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void seeresultButton_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guna2ShadowPanel1.Visible = true;
            startdateDateTimePicker.Visible = true;
            enddateDateTimePicker.Visible = true;
            seeresultButton.Visible = true;
        }
    }
}
