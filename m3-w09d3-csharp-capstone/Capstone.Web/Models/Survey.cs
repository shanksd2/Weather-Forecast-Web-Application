using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Models
{
    public class Survey
    {
       

        public string FavoriteParkName;
        public string Email;
        public string ResidenceState;
        public string ActivityLevel;



        public static List<SelectListItem> States
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem { Text = "Ohio", Value = "Ohio" },
                    new SelectListItem { Text = "Florida", Value = "Florida" },
                    new SelectListItem { Text = "Arizona", Value = "Arizona" },
                    new SelectListItem { Text = "Montana", Value = "Montana" },
                    new SelectListItem { Text = "Tennessee", Value = "Tennessee" },
                    new SelectListItem { Text = "Wyoming", Value = "Wyoming" },
                    new SelectListItem { Text = "Washingto", Value = "Washingto" }, //spelled wrong in the database
                    new SelectListItem { Text = "Colorado", Value = "Colorado" },
                    new SelectListItem { Text = "California", Value = "California" },

                };
            }
        }

        public static List<SelectListItem> ActivityLevels
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem { Text = "Extremely Active", Value = "Extremely Active" },
                    new SelectListItem { Text = "Active", Value = "Active" },
                    new SelectListItem { Text = "Sedentary", Value = "Sedentary" },
                    new SelectListItem { Text = "Inactive", Value = "Inactive" },
                };
            }
        }
    }
}