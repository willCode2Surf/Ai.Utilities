using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AI.JavascriptTools.Web.Controllers
{
    public class SamplesController : Controller
    {

        public ActionResult Graphs()
        {
            return View();
        }

        public ActionResult Binder()
        {
            return View();
        }
    }
}
