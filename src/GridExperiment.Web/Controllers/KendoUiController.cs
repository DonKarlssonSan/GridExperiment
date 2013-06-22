using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridExperiment.Controllers
{
    public class KendoUiController : Controller
    {
        //
        // GET: /KendoUi/

        public ActionResult Index()
        {
            return View("KendoUi");
        }

    }
}
