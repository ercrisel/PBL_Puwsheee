using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Classes
{
    public class MoodEntry
    {
        public MoodEntry()
        {
            //default constructor
        }
        public MoodEntry(string username)
        {
            Username = username;
        }
        public MoodEntry(string username, DateTime date)
        {
            Username = username;
            Date = date;
        }

        private string connectionString = ConnectionAccess.ConnectionString;
        private int entryID;
        private string username;
        private DateTime date;
        private Mood mood = new Mood();
        private List<Activity> activities = new List<Activity>();
        private string notes;

        public int EntryID
        {
            get { return entryID; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Mood Mood
        {
            get { return mood; }
            set { mood = value; }
        }
        public List<Activity> Activities
        {
            get { return activities; }
            set { activities = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        /// <summary>
        /// checks whether there is already an existing record in database depending on the date
        /// </summary>
        /// <returns>TRUE if it exists, FALSE if there is no record</returns>
        public bool IsExistingRecord()
        {
            var isExisting = false;

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand isExistingCommand = new SqlCommand("spCheckExistingMoodEntries", connection);
                isExistingCommand.CommandType = CommandType.StoredProcedure;
                isExistingCommand.Parameters.AddWithValue("@Date", date);
                SqlDataReader reader = isExistingCommand.ExecuteReader();

                while (reader.Read())
                {
                    var dbIsExisting = reader["IsExisting"].ToString();
                    isExisting = Convert.ToBoolean(dbIsExisting);
                }
                reader.Close();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

            return isExisting;
        }

        /// <summary>
        /// stores the entryId depending on the date
        /// </summary>
        private void GetEntryId()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand checkEntryIdCommand = new SqlCommand("spCheckEntryID", connection);
                checkEntryIdCommand.CommandType = CommandType.StoredProcedure;
                checkEntryIdCommand.Parameters.AddWithValue("@Date", date);
                SqlDataReader reader = checkEntryIdCommand.ExecuteReader();

                while (reader.Read())
                {
                    var checkEntryId = reader["EntryID"].ToString();
                    entryID = int.Parse(checkEntryId); //stores the entry id needed
                }
                reader.Close();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// stores the mood and notes depending on the entryId
        /// </summary>
        private void SelectMoodNotes()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify which mood and notes should be read
                GetEntryId();

                SqlCommand selectMoodEntryCommand = new SqlCommand("spSelectMoodEntry", connection);
                selectMoodEntryCommand.CommandType = CommandType.StoredProcedure;
                selectMoodEntryCommand.Parameters.AddWithValue("@EntryID", entryID);
                SqlDataReader reader = selectMoodEntryCommand.ExecuteReader();

                while (reader.Read())
                {
                    var dbMood = reader["Mood"].ToString();
                    var dbNotes = reader["Notes"].ToString();
                    mood.Rank = int.Parse(dbMood); //stores mood
                    notes = dbNotes; //stores notes
                }
                reader.Close();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// stores activities depending on entryId
        /// </summary>
        private void SelectActivities()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify group of activities with the same entry id
                GetEntryId();

                SqlCommand selectMoodTrackerActivityCommand = new SqlCommand("spSelectMoodTrackerActivity", connection);
                selectMoodTrackerActivityCommand.CommandType = CommandType.StoredProcedure;
                selectMoodTrackerActivityCommand.Parameters.AddWithValue("@EntryID", entryID);
                SqlDataReader reader = selectMoodTrackerActivityCommand.ExecuteReader();

                while (reader.Read())
                {
                    var dbActivityId = reader["ActivitiesID"].ToString();
                    activities.Add(new Activity(int.Parse(dbActivityId)));
                }
                reader.Close();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// compilation of methods that gets the overall moodEntry (gets mood, activities, and notes)
        /// </summary>
        public void SelectMoodEntry()
        {
            //(idk if i need to call this since it's always called in the next following methods but just to be sure)
            GetEntryId(); //checks the entry id - to identify which entry should be selected according to a specific date
            SelectMoodNotes();
            SelectActivities();
        }

        /// <summary>
        /// inserts new record of mood and notes
        /// </summary>
        private void InsertMoodNotes()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand insertMoodEntryCommand = new SqlCommand("spInsertMoodEntry", connection);
                insertMoodEntryCommand.CommandType = CommandType.StoredProcedure;
                insertMoodEntryCommand.Parameters.AddWithValue("@Username", username);
                insertMoodEntryCommand.Parameters.AddWithValue("@Date", date);
                insertMoodEntryCommand.Parameters.AddWithValue("@Mood", mood.Rank);
                insertMoodEntryCommand.Parameters.AddWithValue("@Notes", notes);
                insertMoodEntryCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// inserts new records of activities in the database depending on the newly inserted entryId
        /// </summary>
        private void InsertActivities()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify which newly added entry should be inserted along with activities
                GetEntryId();

                foreach (var activity in activities)
                {
                    SqlCommand insertMoodTrackerActivityCommand = new SqlCommand("spInsertMoodTrackerActivity", connection);
                    insertMoodTrackerActivityCommand.CommandType = CommandType.StoredProcedure;
                    insertMoodTrackerActivityCommand.Parameters.AddWithValue("@EntryID", entryID);
                    insertMoodTrackerActivityCommand.Parameters.AddWithValue("@ActivitiesID", activity.Id);
                    insertMoodTrackerActivityCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// compilation of methods that inserts the overall moodEntry (inserts new mood, activities, and notes)
        /// </summary>
        public void InsertMoodEntry()
        {
            InsertMoodNotes();
            GetEntryId(); //checks the entry id - to identify which newly added entry should be inserted along with activities
            InsertActivities();
        }

        /// <summary>
        /// deletes mood and notes depending on entryId
        /// </summary>
        private void DeleteMoodNotes()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify which entry should be deleted according to a specific date
                GetEntryId();

                SqlCommand deleteMoodEntryCommand = new SqlCommand("spDeleteMoodEntry", connection);
                deleteMoodEntryCommand.CommandType = CommandType.StoredProcedure;
                deleteMoodEntryCommand.Parameters.AddWithValue("@EntryID", entryID);
                deleteMoodEntryCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// deletes activities depending on entryId
        /// </summary>
        private void DeleteActivities()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify which entry should be deleted according to a specific date
                GetEntryId();

                SqlCommand deleteMoodTrackerActivityCommand = new SqlCommand("spDeleteMoodTrackerActivity", connection);
                deleteMoodTrackerActivityCommand.CommandType = CommandType.StoredProcedure;
                deleteMoodTrackerActivityCommand.Parameters.AddWithValue("@EntryID", entryID);
                deleteMoodTrackerActivityCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// compilation of methods that deletes the overall moodEntry (deletes mood, activities, and notes)
        /// </summary>
        public void DeleteMoodEntry()
        {
            GetEntryId(); //checks the entry id - to identify which entry should be deleted according to a specific date
            DeleteActivities(); //deletes activities (call this FIRST because activities table has a foreign key that depends on mood entry table that contains primary key)
            DeleteMoodNotes();
        }

        /// <summary>
        /// updates mood and notes in the database according to the entryId
        /// </summary>
        private void UpdateMoodNotes()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //checks the entry id - to identify which entry should be updated
                GetEntryId();

                SqlCommand updateMoodEntryCommand = new SqlCommand("spUpdateMoodEntry", connection);
                updateMoodEntryCommand.CommandType = CommandType.StoredProcedure;
                updateMoodEntryCommand.Parameters.AddWithValue("@EntryID", entryID);
                updateMoodEntryCommand.Parameters.AddWithValue("@Mood", mood.Rank);
                updateMoodEntryCommand.Parameters.AddWithValue("@Notes", notes);
                updateMoodEntryCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// compilation of methods that updates the overall moodEntry (updates mood, activities, and notes)
        /// </summary>
        public void UpdateMoodEntry()
        {
            GetEntryId();
            UpdateMoodNotes();
            DeleteActivities(); //deletes activities with the same entryId; and (obob na solution pero ang mahalaga, gumagana siya)
            InsertActivities(); //inserts new activities
        }
    }
}
