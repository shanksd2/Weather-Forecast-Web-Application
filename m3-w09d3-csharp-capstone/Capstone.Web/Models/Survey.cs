using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Capstone.Web.Models
{
    public class Survey
    {

        public string ActivityLevel { get; set; }
        public string ParkName { get; set; }
        public int Rank { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string FavoriteParkCode { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "State must be abbreviated")]
        [DataType(DataType.Text)]
        public string ResidenceState { get; set; } 


        public static List<SelectListItem> ParkNames
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem { Text = "Cuyahoga Valley National Park", Value = "CVNP" },
                    new SelectListItem { Text = "Everglades National Park", Value = "ENP" },
                    new SelectListItem { Text = "Grand Canyon National Park", Value = "GCNP" },
                    new SelectListItem { Text = "Glacier National Park", Value = "GNP" },
                    new SelectListItem { Text = "Great Smoky Mountains National Park", Value = "GSMNP" },
                    new SelectListItem { Text = "Grand Teton National Park", Value = "GTNP" },
                    new SelectListItem { Text = "Mount Rainier National Park", Value = "MRNP" },
                    new SelectListItem { Text = "Rocky Mountain National Park", Value = "RMNP" },
                    new SelectListItem { Text = "Yellowstone National Park", Value = "YNP" },
                     new SelectListItem { Text = "Yosemite National Park", Value = "YNP2" },

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