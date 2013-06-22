using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridExperiment.Controllers
{
    public class AspNetGridController : Controller
    {
        public ActionResult Index(int rowsPerPage = 10)
        {
            ViewBag.RowsPerPage = rowsPerPage;
            return View("AspNetGrid", GridExperiment.Data.PocoData.GetAllPodCasts());
        }
    }
}
