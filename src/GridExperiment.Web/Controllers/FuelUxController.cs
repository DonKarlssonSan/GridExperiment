using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridExperiment.Controllers
{
    public class FuelUxController : Controller
    {
        //
        // GET: /FuelUx/

        public ActionResult Index()
        {
            return View("FuelUx");
        }

    }
}
