using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;


namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        public ActionResult Survey()
        {
            return View("Survey");
        }

        public ActionResult FavoriteParks()
        {
            return View("FavoriteParks");
        }

        [HttpPost]
        public ActionResult FavoriteParks(Survey model)
        {

            if (!ModelState.IsValid)
            {
                return View("Survey", model);
            }

            return RedirectToAction("FavoriteParks", "Survey");
        }
    }
}