using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers
{
    public class ParkController : Controller
    {
        // GET: Park
        public ActionResult Detail(string id)
        {
            ParkSQLDAL dal = new ParkSQLDAL();
            Park detailedPark = dal.DetailPark(id);
            Park isCelsius = Session["isCelsius"] as Park;

            if(isCelsius == null)
            {
                Park celsiusCheck = new Park();
                Session["isCelsius"] = celsiusCheck;
                return View("Detail", detailedPark);
            }

            if (isCelsius.IsCelsius)
            {
                return View("DetailCelsius", detailedPark);
            }
            return View("Detail", detailedPark);
        }

        [HttpPost]
        public ActionResult Detail(Park parkToDetail)
        {
            Park isCelsius = Session["isCelsius"] as Park;
            isCelsius.IsCelsius = false;
            Session["isCelsius"] = isCelsius;
            return View(parkToDetail);
        }

        [HttpPost]
        public ActionResult DetailCelsius(Park parkToDetail)
        {
            Park isCelsius = Session["isCelsius"] as Park;
            isCelsius.IsCelsius = true;
            Session["isCelsius"] = isCelsius;
            return View(parkToDetail);
        }
    }
}