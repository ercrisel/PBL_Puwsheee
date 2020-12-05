using Guna.UI2.WinForms;
using PBL_Puwsheee.Classes;
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
    /// <summary>
    /// 🌻💛🔆🧸💕 
    /// babe: minimize so it isn't overwhelming; just focus on ActivityIconProperties() and MoodIconProperties() 
    /// and if you can, change the startDate and endDate label. assigning of text in labels can be seen in LoadAnalysisOverview()
    /// 💕🧸🔆💛🌻
    /// </summary>
    public partial class Analysis : Form
    {
        private readonly UserInfo user = new UserInfo();
        private List<Mood> moodsList = new List<Mood>();
        private List<Activity> activitiesList = new List<Activity>();
        private List<MoodEntry> moodEntriesList = new List<MoodEntry>();
        private List<List<Activity>> activitiesByMoodList = new List<List<Activity>>();
        #region Create Icon List
        private List<Guna2CirclePictureBox> topActivityIcons;
        private List<Guna2CircleButton> topActivityCountIcons;
        private List<Guna2CirclePictureBox> activityIcons;
        private List<Guna2CircleButton> activityCountIcons;
        private List<Guna2CirclePictureBox> moodIcons;
        private List<Guna2CircleButton> moodCountIcons;
        #endregion
        public struct ActivityCount
        {
            public int activityId;
            public int count;
        }
        public struct MoodCount
        {
            public int moodId;
            public int count;
        }

        public Analysis()
        {
            InitializeComponent();
        }
        public Analysis(UserInfo userInfo)
        {
            InitializeComponent();
            user = userInfo;
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

        //EVENTS
        private void Analysis_Load(object sender, EventArgs e)
        {

            #region Populate Lists of Icons
            topActivityIcons = new List<Guna2CirclePictureBox> { topActivity1Icon, topActivity2Icon, topActivity3Icon, topActivity4Icon, topActivity5Icon };
            topActivityCountIcons = new List<Guna2CircleButton> { topActivity1CountIcon, topActivity2CountIcon, topActivity3CountIcon, topActivity4CountIcon, topActivity5CountIcon };
            moodIcons = new List<Guna2CirclePictureBox> { mood1Icon, mood2Icon, mood3Icon, mood4Icon, mood5Icon, mood6Icon, mood7Icon, mood8Icon };
            moodCountIcons = new List<Guna2CircleButton> { mood1CountIcon, mood2CountIcon, mood3CountIcon, mood4CountIcon, mood5CountIcon, mood6CountIcon, mood7CountIcon, mood8CountIcon };
            activityIcons = new List<Guna2CirclePictureBox> { activity1Icon, activity2Icon, activity3Icon, activity4Icon, activity5Icon, activity6Icon, activity7Icon, activity8Icon, activity9Icon, activity10Icon, activity11Icon, activity12Icon };
            activityCountIcons = new List<Guna2CircleButton> { activity1CountIcon, activity2CountIcon, activity3CountIcon, activity4CountIcon, activity5CountIcon, activity6CountIcon, activity7CountIcon, activity8CountIcon, activity9CountIcon, activity10CountIcon, activity11CountIcon, activity12CountIcon };
            #endregion

            InitializeDates();

            CreateLists();

            #region Populate ComboBox
            moodComboBox.Items.Add("Angry");
            moodComboBox.Items.Add("Disgusted");
            moodComboBox.Items.Add("Miserable");
            moodComboBox.Items.Add("Sad");
            moodComboBox.Items.Add("Meh");
            moodComboBox.Items.Add("Flirty");
            moodComboBox.Items.Add("Contented");
            moodComboBox.Items.Add("Happy");
            #endregion 

            LoadAnalysisOverview();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (guna2ShadowPanel1.Visible == false)
            {
                guna2ShadowPanel1.Visible = true;
                startDateTimePicker.Visible = true;
                endDateTimePicker.Visible = true;
                seeresultButton.Visible = true;
            }
            else
            {
                guna2ShadowPanel1.Visible = false;
                startDateTimePicker.Visible = false;
                endDateTimePicker.Visible = false;
                seeresultButton.Visible = false;
            }
        }

        private void seeresultButton_Click(object sender, EventArgs e)
        {
            LoadAnalysisOverview();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            moodComboBox.Enabled = false; //user shouldn't be able to pick different moods because moods and activitiesMoodList needs to be updated
            CheckValidDate();
        }

        private void moodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoodIconProperties(guna2CirclePictureBox1, (moodComboBox.SelectedIndex + 1));
            PrepareTopActivityIcons();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeDates();
            LoadAnalysisOverview();
        }

        //CUSTOM METHODS
        private void InitializeDates()
        {
            endDateTimePicker.Value = DateTime.Today;
            startDateTimePicker.Value = startDateTimePicker.Value.AddMonths(-1);
        }

        private void CheckValidDate()
        {
            if (endDateTimePicker.Value > DateTime.Today) endDateTimePicker.Value = DateTime.Today;
            if (startDateTimePicker.Value > DateTime.Today) startDateTimePicker.Value = DateTime.Today;
            if (startDateTimePicker.Value > endDateTimePicker.Value) startDateTimePicker.Value = endDateTimePicker.Value;
        }

        private void CreateLists()
        {
            for (int i = 0; i < 8; i++) //hard coded for the 8 different emotions
            {
                activitiesByMoodList.Add(new List<Activity>());
            }
        }

        private void LoadAnalysisOverview()
        {
            ClearData(); //clears any previous data
            PopulateLists();
            moodComboBox.Enabled = true; //user can comb through the different moods and activities grouped together
            moodComboBox.SelectedIndex = 7; //default value of comboBox
            startDateLabel.Text = startDateTimePicker.Value.ToString();
            endDateLabel.Text = endDateTimePicker.Value.ToString();
            PrepareTopActivityIcons();
            PrepareActivityIcons();
            PrepareMoodIcons();
        }

        private void ClearData()
        {
            moodsList.Clear();
            activitiesList.Clear();
            moodEntriesList.Clear();
            activitiesByMoodList.ForEach(x => x.Clear());
        }

        private void PopulateLists()
        {
            var startDate = startDateTimePicker.Value;
            var endDate = endDateTimePicker.Value;
            moodEntriesList = GetListOfSelectedMoodEntries(startDate, endDate);

            foreach (var moodEntry in moodEntriesList)
            {
                moodsList.Add(moodEntry.Mood);
                moodEntry.Activities.ForEach(x => activitiesList.Add(x));
                moodEntry.Activities.ForEach(x => SortActivityByMood(moodEntry.Mood, x));
            }
        }

        public IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate)
        {
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
                yield return day;
        }

        private List<MoodEntry> GetListOfSelectedMoodEntries(DateTime startDate, DateTime endDate)
        {
            var moodEntryList = new List<MoodEntry>();

            foreach (var date in EachDay(startDate, endDate))
            {
                var moodEntry = new MoodEntry(user.Username, date);
                if (moodEntry.IsExistingRecord())
                {
                    moodEntry.SelectMoodEntry();
                    moodEntryList.Add(moodEntry);
                }
            }

            return moodEntryList;
        }

        private void SortActivityByMood(Mood mood, Activity activity)
        {
            for (int i = 1; i <= activitiesByMoodList.Count; i++)
            {
                if (i == mood.Rank)
                    activitiesByMoodList.ElementAt(i - 1).Add(activity);
                else
                    continue;
            }
        }

        private void PrepareMoodIcons()
        {
            var moodCountList = GetSortedMoodCountList().OrderByDescending(x => x.count).ToList();

            for (int i = 0; i < moodCountList.Count(); i++)
            {
                FormatMoodIcons(i, moodCountList.ElementAt(i));
            }
        }

        private void PrepareActivityIcons()
        {
            var activityCountList = GetSortedActivitiesCountList().OrderByDescending(x => x.count).ToList();

            for (int i = 0; i < activityCountList.Count(); i++)
            {
                FormatActivityIcons(i, activityCountList.ElementAt(i));
            }
        }

        private void PrepareTopActivityIcons()
        {
            var currentMoodList = activitiesByMoodList.ElementAt(moodComboBox.SelectedIndex); //get the specific list of activities depending on the selectedIndex (serves as the mood)
            var topFiveActivities = GetSortedActivitiesCountList(currentMoodList).OrderByDescending(x => x.count).Take(5).ToList(); //gets the top five activities

            for (int i = 0; i < topFiveActivities.Count(); i++)
            {
                FormatTopActivityIcons(i, topFiveActivities.ElementAt(i));
            }
        }

        private List<MoodCount> GetSortedMoodCountList()
        {
            var tempList = new List<MoodCount>();

            for (int i = 1; i <= 8; i++) //again, this is sadly hard coded for the fixed 1-8 moods
            {
                int count = moodsList.Count(x => x.Rank == i);
                MoodCount moodCount;
                moodCount.moodId = i;
                moodCount.count = count;
                tempList.Add(moodCount);
            }

            return tempList;
        }

        private List<ActivityCount> GetSortedActivitiesCountList()
        {
            var tempList = new List<ActivityCount>();

            for (int i = 1; i <= 12; i++) //1-12 are the activities; hard coded, this is so sad
            {
                var count = activitiesList.Count(x => x.Id == i); //counts each activity
                ActivityCount tempActivityCount;
                tempActivityCount.activityId = i;
                tempActivityCount.count = count;
                tempList.Add(tempActivityCount);
            }

            return tempList;
        }

        private List<ActivityCount> GetSortedActivitiesCountList(List<Activity> currentMoodList)
        {
            var tempList = new List<ActivityCount>();

            for (int i = 1; i <= 12; i++) //1-12 are the activities; hard coded, this is so sad
            {
                var count = currentMoodList.Count(x => x.Id == i); //counts each activity depending on the chosen mood
                ActivityCount tempActivityCount;
                tempActivityCount.activityId = i;
                tempActivityCount.count = count;
                tempList.Add(tempActivityCount);
            }

            return tempList;
        }

        private void FormatMoodIcons(int rank, MoodCount moodCount)
        {
            var currentCountButton = moodCountIcons.ElementAt(rank); //figures what button should they format first
            currentCountButton.Text = moodCount.count.ToString(); //displays the frequency of the activity
            var currentIcon = moodIcons.ElementAt(rank); //figures what button should they format first

            MoodIconProperties(currentIcon, moodCount.moodId);
        }

        private void FormatActivityIcons(int rank, ActivityCount activityCount)
        {
            var currentCountButton = activityCountIcons.ElementAt(rank); //figures what button should they format first
            currentCountButton.Text = activityCount.count.ToString(); //displays the frequency of the activity
            var currentIcon = activityIcons.ElementAt(rank); //figures what button should they format first

            ActivityIconProperties(currentIcon, activityCount.activityId);
        }

        private void FormatTopActivityIcons(int rank, ActivityCount activityCount)
        {
            var currentCountButton = topActivityCountIcons.ElementAt(rank); //figures what button should they format first
            currentCountButton.Text = activityCount.count.ToString(); //displays the frequency of the activity
            var currentIcon = topActivityIcons.ElementAt(rank); //figures what button should they format first

            if (activityCount.count == 0) //default
            {
                currentIcon.Image = null;
                currentIcon.FillColor = Color.Black;
            }
            else
            {
                ActivityIconProperties(currentIcon, activityCount.activityId);
            }
        }

        /// <summary>
        /// 🌻💛🔆🧸💕 format the activity icon depending on the type 💕🧸🔆💛🌻
        /// </summary>
        /// <param name="currentIcon">passes the icon to be formatted</param>
        /// <param name="type">assigns what type of activity</param>
        private void ActivityIconProperties(Guna2CirclePictureBox currentIcon, int type)
        {
            switch (type) //formats the button depending on the type of activity 
            {
                case 1:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Cook;
                    break;
                case 2:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Exercise;
                    break;
                case 3:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Game;
                    break;
                case 4:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Music;
                    break;
                case 5:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Read;
                    break;
                case 6:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Shop;
                    break;
                case 7:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Sleep;
                    break;
                case 8:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Social;
                    break;
                case 9:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Sports;
                    break;
                case 10:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Study;
                    break;
                case 11:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Travel;
                    break;
                case 12:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Watch;
                    break;
                default:
                    currentIcon.FillColor = Color.Black;
                    break;
            }
        }

        /// <summary>
        /// 🌻💛🔆🧸💕 format the mood icon depending on the type 💕🧸🔆💛🌻
        /// </summary>
        /// <param name="currentIcon">passes the icon to be formatted</param>
        /// <param name="type">assigns what type of activity</param>
        private void MoodIconProperties(Guna2CirclePictureBox currentIcon, int type)
        {
            switch (type) //formats the button depending on the type of activity
            {
                case 1:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Angry;
                    break;
                case 2:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Disgusted;
                    break;
                case 3:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Miserable;
                    break;
                case 4:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Sad;
                    break;
                case 5:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Meh;
                    break;
                case 6:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Flirty;
                    break;
                case 7:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Contented;
                    break;
                case 8:
                    currentIcon.Image = PBL_Puwsheee.Properties.Resources.Happy;
                    break;
                default:
                    currentIcon.FillColor = Color.Black;
                    break;
            }
        }
    }
}
