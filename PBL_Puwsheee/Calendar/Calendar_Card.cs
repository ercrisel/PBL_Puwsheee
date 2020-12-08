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
using Guna.UI2.WinForms;
using PBL_Puwsheee.Classes;

namespace PBL_Puwsheee.Calendar
{
    public partial class Calendar_Card : Form
    {
        private List<Guna2Button> moodButtonsList = new List<Guna2Button> { };
        private List<Guna2Button> activitiesButtonsList = new List<Guna2Button> { };
        private MoodEntry moodEntry;
        private bool inEditState;

        protected override CreateParams CreateParams // double buffeirng daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

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

        public Calendar_Card(DateTime date)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public Calendar_Card(UserInfo userInfo, DateTime date)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            var user = userInfo;
            moodEntry = new MoodEntry(user.Username, date);
            moodEntry.SelectMoodEntry();
        }

        private void Calendar_Card_Load(object sender, EventArgs e)
        {
            moodButtonsList = moodPanel.Controls.OfType<Guna2Button>().ToList();
            activitiesButtonsList = activitiesPanel.Controls.OfType<Guna2Button>().ToList();

            #region Assign Tag Property
            //mood buttons
            angryIcon.Tag = new Mood(1);
            flirtyIcon.Tag = new Mood(6);
            contentedIcon.Tag = new Mood(7);
            happyIcon.Tag = new Mood(8);
            mehIcon.Tag = new Mood(5);
            sadIcon.Tag = new Mood(4);
            miserableIcon.Tag = new Mood(3);
            disgustedIcon.Tag = new Mood(2);

            //activity buttons
            cookIcon.Tag = new Activity(1);
            exerciseIcon.Tag = new Activity(2);
            gameIcon.Tag = new Activity(3);
            musicIcon.Tag = new Activity(4);
            readIcon.Tag = new Activity(5);
            watchIcon.Tag = new Activity(12);
            shopIcon.Tag = new Activity(6);
            sleepIcon.Tag = new Activity(7);
            socialIcon.Tag = new Activity(8);
            sportsIcon.Tag = new Activity(9);
            studyIcon.Tag = new Activity(10);
            travelIcon.Tag = new Activity(11);
            #endregion

            DisplayRecordedMoodEntry();

            IsSettingsEditable(false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var tempMoodEntry = moodEntry;

            if (inEditState) //hides buttons if already visible
            {
                IsSettingsEditable(false);
                moodEntry = tempMoodEntry; //if user doesn't want to edit it suddenly and clicks edit button again, display original record in database
                DisplayRecordedMoodEntry();
            }
            else //shows buttons if not visible
            {
                IsSettingsEditable(true);
                DisplayRecordedMoodEntry();

                foreach (var button in activitiesButtonsList)
                {
                    var tempActivity = (Activity)button.Tag;
                    foreach (var activity in moodEntry.Activities)
                    {
                        if (button.Checked == false)
                        {
                            button.FillColor = Color.Transparent;
                        }
                    }
                } 
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            moodEntry.DeleteMoodEntry();
            IsSettingsEditable(false);
            //CreateRemoveEntryForm();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            StoreDataInMoodEntryProperties();

            if (moodEntry.IsExistingRecord())
                moodEntry.UpdateMoodEntry();
            else
                moodEntry.InsertMoodEntry();

            DisplayRecordedMoodEntry();
            IsSettingsEditable(false);
            //CreateEditEntryForm();
        }

        private void moodIcon_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            guna2CirclePictureBox1.Image = btn.BackgroundImage;
        }

        //CUSTOM METHODS

        private void CreateRemoveEntryForm()
        {
            Form bg = new Form();

            using (Remove_Entry remove = new Remove_Entry())
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

                remove.Owner = bg;
                remove.BringToFront();
                remove.ShowDialog();
                bg.Dispose();
            }
        }

        private void CreateEditEntryForm()
        {
            Form bg = new Form();

            using (Edit_Entry edit = new Edit_Entry())
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

                edit.Owner = bg;
                edit.BringToFront();
                edit.ShowDialog();
                bg.Dispose();
            }
        }

        /// <summary>
        /// stores checked mood & activities and notes in moodEntry properties
        /// </summary>
        public void StoreDataInMoodEntryProperties()
        {
            foreach (var button in moodButtonsList)
            {
                if (button.Checked)
                {
                    var mood = (Mood)button.Tag; //or directly command {moodEntry.Mood = (Mood)button.Tag} which casts tag as Mood
                    moodEntry.Mood = mood;
                }
            }

            var activities = new List<Activity>() { };

            foreach (var button in activitiesButtonsList)
            {
                if (button.Checked)
                {
                    var activity = (Activity)button.Tag; //or directly command {activities.Add((Activity)button.Tag)} which casts tag as Activity
                    activities.Add(activity);
                }
            }

            moodEntry.Activities = activities;

            moodEntry.Notes = notesTextbox.Text;
        }

        /// <summary>
        /// displays the recorded mood entry according to the mood entry information
        /// </summary>
        public void DisplayRecordedMoodEntry()
        {
            foreach (var button in moodButtonsList)
            {
                var tempMood = (Mood)button.Tag;
                if (moodEntry.Mood.Rank == tempMood.Rank)
                {
                    button.Checked = true;
                    guna2CirclePictureBox1.Image = button.BackgroundImage;
                }
                else
                {
                    button.Checked = false;
                }
                button.Checked = (moodEntry.Mood.Rank == tempMood.Rank) ? button.Checked = true : button.Checked = false;
            }

            foreach (var button in activitiesButtonsList)
            {
                var tempActivity = (Activity)button.Tag;
                foreach (var activity in moodEntry.Activities)
                {
                    if (activity.Id == tempActivity.Id) button.Checked = true;

                    if (button.Checked == false) button.FillColor = Color.Silver;
                    else button.FillColor = Color.Transparent;
                }
            }

            notesTextbox.Text = moodEntry.Notes;
        }

        /// <summary>
        /// compilation of methods that sets whether the controls of the mood tracker will be editable or not
        /// </summary>
        /// <param name="isEditable">sets all of the controls and isEditable state</param>
        public void IsSettingsEditable(bool isEditable)
        {
            if (isEditable)
            {
                ChangeSettingsPanelButtonTextBoxControls(true, true);
                moodPanel.Visible = true;
                ChangeSingleButtonProperty(removeButton, true);
                ChangeSingleButtonProperty(updateButton, true);
                inEditState = true;
            }
            else
            {
                ChangeSettingsPanelButtonTextBoxControls(false, true);
                moodPanel.Visible = false;
                ChangeSingleButtonProperty(removeButton, false);
                ChangeSingleButtonProperty(updateButton, false);
                inEditState = false;
            }
        }

        /// <summary>
        /// changes the button.Checked, button.Enabled, and button.Visible of buttons inside panels; changes textBox.Enabled and clears text of all textboxes in a form
        /// </summary>
        /// <param name="isEnabled">sets button.Enabled and textBox.Enabled</param>
        /// <param name="isVisible">sets button.Visible</param>
        public void ChangeSettingsPanelButtonTextBoxControls(bool isEnabled, bool isVisible)
        {
            foreach (var panel in this.Controls.OfType<Guna2Panel>()) //iterates through all the panels
            {
                foreach (var button in panel.Controls.OfType<Guna2Button>()) //iterates through all buttons in a panel
                {
                    button.Enabled = isEnabled;
                    button.Visible = isVisible;
                }
            }

            foreach (var textBox in this.Controls.OfType<Guna2TextBox>()) //shows texts but is either 
            {
                textBox.Enabled = isEnabled;
            }
        }

        /// <summary>
        /// changes a set of properties in a single button
        /// </summary>
        /// <param name="button">passes the button to be modified</param>
        /// <param name="preference">sets button.Enabled and button.Visible</param>
        public void ChangeSingleButtonProperty(Guna2Button button, bool preference)
        {
            button.Visible = button.Enabled = preference; // function that sets Visible and Enabled of a button; if there are changes, refer to this function
        }
    }
}
