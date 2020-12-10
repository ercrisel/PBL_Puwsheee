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
        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

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

        private void NewPlayables_Load(object sender, EventArgs e)
        {
            breathingPict.BackgroundImage = PBL_Puwsheee.Properties.Resources.BreathPlayable;
            musicPic.BackgroundImage = PBL_Puwsheee.Properties.Resources.musicPlayables;
            rainPic.BackgroundImage = PBL_Puwsheee.Properties.Resources.rainPlayables;
            energizerPic.BackgroundImage = PBL_Puwsheee.Properties.Resources.EnergizerPlayable;
            gratitudePic.BackgroundImage = PBL_Puwsheee.Properties.Resources.GratitudePlayable;
            anxietyPic.BackgroundImage = PBL_Puwsheee.Properties.Resources.AnxietyPlayable1;
            relaxPic.BackgroundImage = PBL_Puwsheee.Properties.Resources.RelaxationPlayable;
        }

        private void musicPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
