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

namespace PBL_Puwsheee.Visualization
{
    public partial class VisualizationSteps : Form
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

        List<Panel> stepPages = new List<Panel>();
        int page;

        public VisualizationSteps()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notesTextbox_Enter(object sender, EventArgs e)
        {
            if(notesTextbox.Text == "i'm grateful for...")
            {
                notesTextbox.Text = "";
                notesTextbox.ForeColor = Color.FromArgb(33, 21, 41);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(page < stepPages.Count-1)
            {
                stepPages[++page].BringToFront();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if(page > 0)
            {
                stepPages[--page].BringToFront();
            }
        }

        private void VisualizationSteps_Load(object sender, EventArgs e)
        {
            stepPages.Add(stepOnePanel);
            stepPages.Add(stepTwoPanel);
            stepPages.Add(stepThreePanel);
            stepPages.Add(writePanel);
            stepPages[page].BringToFront();
        }
    }
}
