using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Park
    {
        public string ParkCode { set; get; }
        public string ParkName { set; get; }
        public string State { set; get; }
        public int Acreage { set; get; }
        public int ElevationInFeet { set; get; }
        public double MilesOfTrail { set; get; }
        public int NumberOfCampsites { set; get; }
        public string Climate { set; get; }
        public int YearFounded { set; get; }
        public int AnnualVisitorCount { set; get; }
        public string InspirationalQuote { set; get; }
        public string QuoteSource { get; set; }
        public string ParkDescription { get; set; }
        public int EntryFee { get; set; }
        public int NumberOfAnimalSpecies { get; set; }

    }
}