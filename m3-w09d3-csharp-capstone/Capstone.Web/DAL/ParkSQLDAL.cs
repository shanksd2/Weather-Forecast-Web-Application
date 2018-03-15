using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public class ParkSQLDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["ParkWeather"].ConnectionString;
        public string SQL_GetAllParks = @"SELECT * FROM park";
        public string SQL_DetailedParkView = @"SELECT * FROM park WHERE parkCode = @parkCode;";

        public List<Park> GetAllParks()
        {
            List<Park> allParks = new List<Park>();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GetAllParks, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Park p = new Park();
                        p.ParkCode = Convert.ToString(reader["parkCode"]);
                        p.ParkName = Convert.ToString(reader["parkName"]);
                        p.State = Convert.ToString(reader["state"]);
                        p.Acreage = Convert.ToInt32(reader["acreage"]);
                        p.ElevationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        p.MilesOfTrail = Convert.ToDouble(reader["milesOfTrail"]);
                        p.NumberOfCampsites = Convert.ToInt32(reader["numberOfCampsites"]);
                        p.Climate = Convert.ToString(reader["climate"]);
                        p.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        p.AnnualVisitorCount = Convert.ToInt32(reader["annualVisitorCount"]);
                        p.InspirationalQuote = Convert.ToString(reader["inspirationalQuote"]);
                        p.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        p.ParkDescription = Convert.ToString(reader["parkDescription"]);
                        p.EntryFee = Convert.ToInt32(reader["entryFee"]);
                        p.NumberOfAnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                        allParks.Add(p);
                    }
                }
                return allParks;
            }
            catch(SqlException)
            {
                throw;
            }
        }
        public Park DetailPark(string parkCode)
        {
            Park parkDetailed = new Park();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_DetailedParkView, connection);
                    cmd.Parameters.AddWithValue("@parkCode", parkCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Park p = new Park();
                        parkDetailed.ParkCode = Convert.ToString(reader["parkCode"]);
                        parkDetailed.ParkName = Convert.ToString(reader["parkName"]);
                        parkDetailed.State = Convert.ToString(reader["state"]);
                        parkDetailed.Acreage = Convert.ToInt32(reader["acreage"]);
                        parkDetailed.ElevationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        parkDetailed.MilesOfTrail = Convert.ToDouble(reader["milesOfTrail"]);
                        parkDetailed.NumberOfCampsites = Convert.ToInt32(reader["numberOfCampsites"]);
                        parkDetailed.Climate = Convert.ToString(reader["climate"]);
                        parkDetailed.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        parkDetailed.AnnualVisitorCount = Convert.ToInt32(reader["annualVisitorCount"]);
                        parkDetailed.InspirationalQuote = Convert.ToString(reader["inspirationalQuote"]);
                        parkDetailed.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        parkDetailed.ParkDescription = Convert.ToString(reader["parkDescription"]);
                        parkDetailed.EntryFee = Convert.ToInt32(reader["entryFee"]);
                        parkDetailed.NumberOfAnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                    }
                }
                return parkDetailed;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}