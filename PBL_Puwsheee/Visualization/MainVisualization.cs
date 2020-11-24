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
    public partial class MainVisualization : Form
    {
        public MainVisualization()
        {
            InitializeComponent();
        }

        private void MainVisualization_Load(object sender, EventArgs e)
        {
            
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            Form bg = new Form();

            using (Visualization.VisualizationSteps steps = new Visualization.VisualizationSteps())
            {
                bg.StartPosition = FormStartPosition.CenterScreen;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = .50d;
                bg.BackColor = Color.Black;
                bg.WindowState = FormWindowState.Normal;
                bg.TopMost = true;
                bg.Location = this.Location;
                bg.ShowInTaskbar = false;
                bg.Size = new Size(1020, 610);
                bg.Show();

                steps.Owner = bg;
                steps.BringToFront();
                steps.ShowDialog();
                bg.Dispose();
            }
        }
    }
}
