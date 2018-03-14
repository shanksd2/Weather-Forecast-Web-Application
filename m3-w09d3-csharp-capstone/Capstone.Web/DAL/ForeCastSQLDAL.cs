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
        public string SQL_GetForecast = @"SELECT * FROM weather WHERE ParkCode = @ParkCode";

        public List<ForeCast> GetForecast(string ParkCode)
        {
            List<ForeCast> fiveDayForeCast = new List<ForeCast>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GetForecast, connection);
                    cmd.Parameters.AddWithValue("@ParkCode", ParkCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ForeCast f = new ForeCast();
                        f.FiveDayForecastValue = Convert.ToInt32(reader["fiveDayForecast"]);
                        f.Low = Convert.ToInt32(reader["low"]);
                        f.High = Convert.ToInt32(reader["high"]);
                        f.Forecast = Convert.ToString(reader["forecast"]);
                        fiveDayForeCast.Add(f);
                    }
                }
                return fiveDayForeCast;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}