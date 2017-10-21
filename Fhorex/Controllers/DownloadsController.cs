using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fhorex.Controllers
{
    public class DownloadsController : Controller
    {
        // GET: Client Agreement
        public ActionResult ClientAgreement()
        {
            return View();
        }
        // GET: Risk Disclosure
        public ActionResult RiskDisclosure()
        {
            return View();
        }
        // GET: Anti-Money Laundering
        public ActionResult AntiMoneyLaundering()
        {
            return View();
        }
        // GET: Legal Documents
        public ActionResult LegalDocuments()
        {
            return View();
        }
        // GET: Terms & Condition
        public ActionResult TermsAndCondition()
        {
            return View();
        }
    }
}