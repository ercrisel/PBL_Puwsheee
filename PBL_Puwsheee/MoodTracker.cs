﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PBL_Puwsheee.Classes;

namespace PBL_Puwsheee
{
    public partial class MoodTracker : Form
    {
        private List<Guna2Button> moodButtonsList = new List<Guna2Button>();
        private List<Guna2Button> activitiesButtonsList = new List<Guna2Button>();
        private MoodEntry moodEntry = new MoodEntry();

        public MoodTracker()
        {
            InitializeComponent();
        }

        public MoodTracker(UserInfo userInfo)
        {
            InitializeComponent();

            var user = userInfo;
            moodEntry.Username = user.Username; 
            moodEntry.Date = DateTime.Today; //automatically sets date as today
        }

        protected override CreateParams CreateParams // double buffering daw sabi ni google 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void moodIcon_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            var mood = (Mood)btn.Tag;
            labelMood.Text = mood.Category;
        }

        private void moodIcon_MouseLeave(object sender, EventArgs e)
        {
            labelMood.Text = String.Empty;
        }


        private void activitiesIcon_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            var activity = (Activity)btn.Tag;
            labelActivities.Text = activity.Category;
        }

        private void activitiesIcon_MouseLeave(object sender, EventArgs e)
        {
            labelActivities.Text = String.Empty;
        }

        private void MoodTracker_Load(object sender, EventArgs e)
        {
            dateLabel.Text = "Today is: " + DateTime.Now.ToString("dd / MM / yyyy");

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

            if (moodEntry.IsExistingRecord())
                IsSettingsEditable(false);
            else
                IsSettingsEditable(true);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            StoreDataInMoodEntryProperties();

            moodEntry.InsertMoodEntry();

            IsSettingsEditable(false);
            labelMood.Text = labelActivities.Text = string.Empty;

            //insert Calendar_Main //redirects to calendar view
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ChangeSettingsAllButtonTextBoxControls(false, true, true);
        }

        //CUSTOM METHODS
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
        /// compilation of methods that sets whether the controls of the mood tracker will be editable or not
        /// </summary>
        /// <param name="preference">sets all of the controls</param>
        public void IsSettingsEditable(bool preference)
        {
            ChangeSettingsAllButtonTextBoxControls(false, preference, true);
            ChangeSingleButtonProperty(submitButton, preference);
            ChangeSingleButtonProperty(clearButton, preference);
        }

        /// <summary>
        /// changes the button.Checked, button.Enabled, and button.Visible of all buttons; changes textBox.Enabled and clears text of all textboxes in a form
        /// </summary>
        /// <param name="isChecked">sets button.Checked</param>
        /// <param name="isEnabled">sets button.Enabled and textBox.Enabled</param>
        /// <param name="isVisible">sets button.Visible</param>
        public void ChangeSettingsAllButtonTextBoxControls(bool isChecked, bool isEnabled, bool isVisible)
        {
            foreach (var button in this.Controls.OfType<Guna2Button>()) //iterates through all buttons without a panel
            {
                button.Checked = isChecked;
                button.Enabled = isEnabled;
                button.Visible = isVisible;
            }

            foreach (var panel in this.Controls.OfType<Guna2Panel>()) //iterates through all the panels
            {
                foreach (var button in panel.Controls.OfType<Guna2Button>()) //iterates through all buttons in a panel
                {
                    button.Checked = isChecked;
                    button.Enabled = isEnabled;
                    button.Visible = isVisible;
                }
            }

            foreach (var textBox in this.Controls.OfType<Guna2TextBox>()) //empties all textboxes
            {
                textBox.Text = string.Empty;
                textBox.Enabled = isEnabled;
            }
        }

        /// <summary>
        /// changes a set of properties in a single button
        /// </summary>
        /// <param name="button">passes the button to be modified</param>
        /// <param name="preference">sets button.Enabled</param>
        public void ChangeSingleButtonProperty(Guna2Button button, bool preference)
        {
            button.Enabled = preference; // function that sets Visible and Enabled of a button; if there are changes, refer to this function
        }
    }
}
