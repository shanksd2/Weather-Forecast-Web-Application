using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.DAL
{
    public class ForeCastSQLDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ParkWeather"].ConnectionString;
        public string SQL_GetForeCast = @"SELECT * FROM weather WHERE ParkCode = @ParkCode";

        public List<ForeCast> GetAllParks()
        {
            List<ForeCast> fiveDayForeCast = new List<Park>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GetForeCast, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                }
                return allParks;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}