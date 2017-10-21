using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fhorex.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult TypesofAccounts()
        {
            return View();
        }
        // GET: Deposit & Withdrawals
        public ActionResult DepositandWithdrawals()
        {
            return View();
        }
    }
}