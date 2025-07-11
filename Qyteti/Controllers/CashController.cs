using Qyteti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Qyteti.Controllers
{
    public class CashController : Controller
    {
        // GET: Cash
        [HttpGet]
        public ActionResult Index()
        {
            return View(new CashModel());
        }
        [HttpPost]
        public ActionResult Index(CashModel model)
        {
            if (ModelState.IsValid)
            {
                int[] bills = { 500, 200, 100, 50, 20, 10, 5 };
                int remaining = model.Amount;

                foreach (var bill in bills)
                {
                    int count = remaining / bill;
                    model.Breakdown[bill] = count;
                    remaining %= bill;
                }
            }

            return View(model);
        }
    }
}