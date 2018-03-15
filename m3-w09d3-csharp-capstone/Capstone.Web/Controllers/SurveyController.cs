using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;


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
            SurveySQLDAL DAL = new SurveySQLDAL();
            List<Survey> favoriteParks = DAL.GetTopFiveResults();
            return View("FavoriteParks", favoriteParks);
        }

        [HttpPost]
        public ActionResult FavoriteParks(Survey model)
        {

            if (!ModelState.IsValid)
            {

                return View("Survey", model);
            }
            SurveySQLDAL DAL = new SurveySQLDAL();
            DAL.AddSurvey(model);

            return RedirectToAction("FavoriteParks", "Survey");
        }
    }
}