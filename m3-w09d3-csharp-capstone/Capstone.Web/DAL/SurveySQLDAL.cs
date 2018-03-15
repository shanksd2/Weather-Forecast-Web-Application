using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Configuration;
using System.Data.SqlClient;


namespace Capstone.Web.DAL
{
    public class SurveySQLDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ParkWeather"].ConnectionString;
        private const string SQL_AddSurvey = @"INSERT INTO survey_result VALUES (@parkCode, @emailAddress, @state, @activityLevel);";
        public string SQL_GetTopFiveResults = @"Select park.parkName, COUNT(park.parkName) as parkRank, park.parkCode, Count(park.parkCode) From survey_result 
                                            Join park on survey_result.parkCode = park.parkCode
                                            GROUP BY park.parkName, park.ParkCode
                                            ORDER BY parkRank DESC";

        public void AddSurvey(Survey model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand(SQL_AddSurvey, conn);
                    sqlCommand.Parameters.AddWithValue(@"parkCode", model.FavoriteParkCode);
                    sqlCommand.Parameters.AddWithValue(@"emailAddress", model.Email);
                    sqlCommand.Parameters.AddWithValue(@"state", model.ResidenceState);
                    sqlCommand.Parameters.AddWithValue(@"activityLevel", model.ActivityLevel);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {

                throw;
            }

            return;
        }

        public List<Survey> GetTopFiveResults()
        {
            try
            {
                List<Survey> topFive = new List<Survey>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand(SQL_GetTopFiveResults, conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Survey s = new Survey();
                        s.FavoriteParkCode = Convert.ToString(reader["parkCode"]);
                        s.Rank = Convert.ToInt32(reader["parkRank"]);
                        s.ParkName = Convert.ToString(reader["parkName"]);
                        topFive.Add(s);
                    }
                    return topFive;
                }
            }
            catch (SqlException ex)
            {

                throw;
            }
        }
    }
}