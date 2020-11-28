using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee.Playables
{
    public partial class NewPlayables : Form
    {
        public NewPlayables()
        {
            InitializeComponent();
        }

        private void breathingButton_Click(object sender, EventArgs e)
        {
            NewBreathing breathingForm = new NewBreathing();
            breathingForm.Show();
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            NewMusic musicForm = new NewMusic();
            musicForm.Show();
        }

        private void natureButton_Click(object sender, EventArgs e)
        {
            NewRain rainForm = new NewRain();
            rainForm.Show();
        }

        private void anxietyLabel_Click(object sender, EventArgs e)
        {
            AnxietyMeditation anxietyForm = new AnxietyMeditation();
            anxietyForm.Show();
        }

        private void energizerLabel_Click(object sender, EventArgs e)
        {
            EnergizerMeditation energizerForm = new EnergizerMeditation();
            energizerForm.Show();
        }

        private void gratitudeLabel_Click(object sender, EventArgs e)
        {
            GratitudeMeditation gratitudeForm = new GratitudeMeditation();
            gratitudeForm.Show();
        }

        private void relaxationLabel_Click(object sender, EventArgs e)
        {
            RelaxationMeditation relaxationForm = new RelaxationMeditation();
            relaxationForm.Show();
        }
    }
}
