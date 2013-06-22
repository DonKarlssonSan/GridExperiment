using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridExperiment.Controllers
{
    public class JqGridController : Controller
    {
        //
        // GET: /JqGrid/

        public ActionResult Index()
        {
            return View("JqGrid");
        }

    }
}
