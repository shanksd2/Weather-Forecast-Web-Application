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


        public void AddSurvey(string parkCode, string emailAddress, string state, string activityLevel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand(SQL_AddSurvey, conn);
                    sqlCommand.Parameters.AddWithValue(@"parkCode", parkCode);
                    sqlCommand.Parameters.AddWithValue(@"emailAddress", emailAddress);
                    sqlCommand.Parameters.AddWithValue(@"state", state);
                    sqlCommand.Parameters.AddWithValue(@"activityLevel", activityLevel);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {

                throw;
            }

            return;
        }
    }
}