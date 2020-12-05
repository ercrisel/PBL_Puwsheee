using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Classes
{
    public class TestScore
    {
        public TestScore()
        {
            //default constructor
        }
        public TestScore(string username, DateTime dateTaken)
        {
            Username = username;
            DateTaken = dateTaken;
        }

        private string connectionString = ConnectionAccess.ConnectionString;
        private string username;
        private DateTime dateTaken;
        private int? goodSelfCareScore;
        private int? emotionalIntelligenceScore;
        private int? anxietyAndDepressionScore;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public DateTime DateTaken
        {
            get { return dateTaken; }
            set { dateTaken = value; }
        }

        public int? GoodSelfCareScore
        {
            get { return goodSelfCareScore; }
            set { goodSelfCareScore = value; }
        }

        public int? EmotionalIntelligenceScore
        {
            get { return emotionalIntelligenceScore; }
            set { emotionalIntelligenceScore = value; }
        }

        public int? AnxietyAndDepressionScore
        {
            get { return anxietyAndDepressionScore; }
            set { anxietyAndDepressionScore = value; }
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

                SqlCommand isExistingCommand = new SqlCommand("spCheckExistingTestScores", connection);
                isExistingCommand.CommandType = CommandType.StoredProcedure;
                isExistingCommand.Parameters.AddWithValue("@Username", username);
                isExistingCommand.Parameters.AddWithValue("@DateTaken", dateTaken);
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
        /// stores test score depending on the date
        /// </summary>
        public void SelectTestScore()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand selectTestScoreCommand = new SqlCommand("spSelectTestScore", connection);
                selectTestScoreCommand.CommandType = CommandType.StoredProcedure;
                selectTestScoreCommand.Parameters.AddWithValue("@Username", username);
                selectTestScoreCommand.Parameters.AddWithValue("@DateTaken", dateTaken);
                SqlDataReader reader = selectTestScoreCommand.ExecuteReader();

                while (reader.Read())
                {
                    string dbDateTaken = reader["DateTaken"].ToString();
                    string dbGoodSelfCareScore = reader["GoodSelfCareScore"].ToString();
                    string dbEmotionalIntelligenceScore = reader["EmotionalIntelligenceScore"].ToString();
                    string dbAnxietyAndDepressionScore = reader["AnxietyAndDepressionScore"].ToString();
                    goodSelfCareScore = string.IsNullOrEmpty(dbGoodSelfCareScore) ? goodSelfCareScore = null : int.Parse(dbGoodSelfCareScore);
                    emotionalIntelligenceScore = string.IsNullOrEmpty(dbEmotionalIntelligenceScore) ? emotionalIntelligenceScore = null : int.Parse(dbEmotionalIntelligenceScore);
                    anxietyAndDepressionScore = string.IsNullOrEmpty(dbAnxietyAndDepressionScore) ? anxietyAndDepressionScore = null : int.Parse(dbAnxietyAndDepressionScore);
                }
                reader.Close();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
