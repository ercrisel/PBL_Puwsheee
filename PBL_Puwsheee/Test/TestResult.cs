using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Test
{
    class TestResult
    {
        private string username;
        private int score;
        private string date;

        // fields
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        // properties


        public string conStr = "Data Source=DESKTOP-8NV2VQJ;Initial Catalog=Puwshee;Integrated Security=True;";
        //methods
        public bool IsDateAndUserUniqueInDatabase() // checheck mo kung unique sya 
        {
            bool unique = false;
            SqlConnection connect = new SqlConnection(conStr);
            connect.Open();
            SqlCommand command = new SqlCommand("spIsUserAndDateUniqueTest", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string userStr = read["Username"].ToString();
                string dateStr = read["DateTaken"].ToString();
                DateTime dateS = DateTime.Parse(dateStr);
                string dateYYMMDD = dateS.ToString("yyyyMMdd");
                if (date == dateYYMMDD && username == userStr)
                {
                    unique = true;
                }
            }
            return unique;
        }
        public void InsertUsernameAndDateTestTaken() // pag sa araw na to wala pa sya ginagawa insert mo ulet si datas
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("spInsertUsernameAndDateTest", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Date", date);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void UploadToDatabase(string storedProcedure) // update mo values sa entries
        {
            SqlConnection connect = new SqlConnection(conStr);
            connect.Open();
            SqlCommand command = new SqlCommand(storedProcedure, connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Score", score);
            command.Parameters.AddWithValue("@Date", date);
            command.ExecuteNonQuery();
            connect.Close();
        }

        public bool CheckIfAlreadyAnswered(Guna2Button btn)
        {
            bool nasagutanNa = true;
            Console.WriteLine(date + " pinindot ");
            SqlConnection connect = new SqlConnection(conStr);
            connect.Open();
            SqlCommand command = new SqlCommand("spLoadTestResult", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Date", date);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string dateTakenStr = read["DateTaken"].ToString();
                string goodSelfCareScoreStr = read["GoodSelfCareScore"].ToString();
                string emotionalIntelligenceScoreStr = read["EmotionalIntelligenceScore"].ToString();
                string anxietyAndDepressionScoreStr = read["AnxietyAndDepressionScore"].ToString();
                DateTime dt = DateTime.Parse(dateTakenStr);
                string dateTakenYMDStr = dt.ToString("yyyyMMdd");
                if (date == dateTakenYMDStr)
                {
                    Console.WriteLine("pasok dito ?? sa date");
                    if (btn.Text == "Anxiety and Depression" && anxietyAndDepressionScoreStr != string.Empty)
                    {
                        Console.WriteLine("may laman si anx and depression " + anxietyAndDepressionScoreStr);
                        return nasagutanNa = false;

                    }
                    if (btn.Text == "Emotional Intelligence" && emotionalIntelligenceScoreStr != string.Empty)
                    {
                        Console.WriteLine("may sagot si intelligence at scre si " + emotionalIntelligenceScoreStr);
                        return nasagutanNa = false;
                    }
                    if (btn.Text == "Good Self-Care" && goodSelfCareScoreStr != string.Empty)
                    {
                        Console.WriteLine(" may score si good self care at " + goodSelfCareScoreStr);
                        return nasagutanNa = false;
                    }

                }
                if (date != dateTakenYMDStr)
                {
                    Console.WriteLine(" not equal");
                    return nasagutanNa = false;
                }
            }
            read.Close();
            connect.Close();
            return nasagutanNa;
        }
        public int ComputeAverageScore(string storedProcedure, string column)
        {
            int average = 0;
            SqlConnection connect = new SqlConnection(conStr);
            connect.Open();
            SqlCommand command = new SqlCommand(storedProcedure, connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            SqlDataReader read = command.ExecuteReader();
            int laman = 0;
            int sum = 0;
            while (read.Read())
            {
                string score = read[column].ToString();
                sum += int.Parse(score);
                laman++;
            }
            read.Close();
            connect.Close();
            average = sum / laman;
            return average;

        }
    }
}
