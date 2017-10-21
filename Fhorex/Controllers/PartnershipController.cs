using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fhorex.Controllers
{
    public class PartnershipController : Controller
    {
        // GET: Affiliate Partnership
        public ActionResult AffiliatePartnership()
        {
            return View();
        }
        // GET: Company Partnership
        public ActionResult CompanyPartnership()
        {
            return View();
        }
    }
}