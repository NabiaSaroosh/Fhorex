using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fhorex.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Download
        public ActionResult Download()
        {
            return View();
        }
        // GET: Economic Calender
        public ActionResult EconomicCalender()
        {
            return View();
        }
        // GET: Mobile Platform
        public ActionResult MobilePlatform()
        {
            return View();
        }
    }
}