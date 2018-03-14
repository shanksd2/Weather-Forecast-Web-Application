using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            ParkSQLDAL sql = new ParkSQLDAL();
            List<Park> allParks = sql.GetAllParks();
            return View("Index", allParks);
        }

        public ActionResult Detail(string id)
        {
            ParkSQLDAL dal = new ParkSQLDAL();
            Park detailedPark = dal.DetailPark(id);
            return View("Detail", detailedPark);
        }

      
    }
}