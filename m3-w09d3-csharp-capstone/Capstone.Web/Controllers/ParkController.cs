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
            return View("Detail", detailedPark);
        }
    }
}