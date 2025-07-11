using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Qyteti.Controllers
{
    public class QytetetController : Controller
    {
        // GET: Qytetet
        public ActionResult Index(int id)
        {
            if (id == 1)
                return Content("Ulqin", "text");
            else if (id == 2)
                return Content("Tivar", "text");
            else
                return HttpNotFound("Nuk ka");
        }

        public ActionResult History(int id)
        {
            if (id == 1)
            {
                return View("UlqinHistory");
            }
            else if (id == 2)
            {
                return View("TivarHistory");
            }
            else
                return HttpNotFound("Nuk ka");
        }
    }
}