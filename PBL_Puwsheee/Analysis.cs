﻿using System;
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
        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        private void seeresultButton_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (guna2ShadowPanel1.Visible == false)
            {
                guna2ShadowPanel1.Visible = true;
                startdateDateTimePicker.Visible = true;
                enddateDateTimePicker.Visible = true;
                seeresultButton.Visible = true;
            }
            else
            {
                guna2ShadowPanel1.Visible = false;
                startdateDateTimePicker.Visible = false;
                enddateDateTimePicker.Visible = false;
                seeresultButton.Visible = false;
            }
        }
    }
}
