using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Models;

namespace WebAdvance.Controllers
{
    public class BugsController : Controller
    {
        // GET: Bugs
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Add Bug";
            return View();
        }

        [HttpPost]
        public ActionResult Index(BugsModel bug)
        {
            if (ModelState.IsValid)
                ViewBag.Message = "Bug is added";
            else
                ViewBag.Message = "Fail";
            return View();
        }
    }
}