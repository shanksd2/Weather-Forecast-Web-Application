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

        public string ActivityLevel;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string FavoriteParkName { get; set; }


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
                    new SelectListItem { Text = "Cuyahoga Valley National Park", Value = "Cuyahoga Valley National Park" },
                    new SelectListItem { Text = "Everglades National Park", Value = "Everglades National Park" },
                    new SelectListItem { Text = "Grand Canyon National Park", Value = "Grand Canyon National Park" },
                    new SelectListItem { Text = "Glacier National Park", Value = "Glacier National Park" },
                    new SelectListItem { Text = "Great Smoky Mountains National Park", Value = "Tennessee" },
                    new SelectListItem { Text = "Grand Teton National Park", Value = "Wyoming" },
                    new SelectListItem { Text = "Mount Rainier National Park", Value = "Washingto" },
                    new SelectListItem { Text = "Rocky Mountain National Park", Value = "Rocky Mountain National Park" },
                    new SelectListItem { Text = "Yellowstone National Park", Value = "Yellowstone National Park" },
                     new SelectListItem { Text = "Yosemite National Park", Value = "Yosemite National Park" },

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