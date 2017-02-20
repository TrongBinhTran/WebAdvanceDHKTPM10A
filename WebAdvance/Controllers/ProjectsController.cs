using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Models;

namespace WebAdvance.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Add Project";
            return View();
        }

        [HttpPost]
        public ActionResult Index(ProjectsModel project)
        {
            if (ModelState.IsValid)
                ViewBag.Message = "Project " + project.Name + " is added";
            else
                ViewBag.Message = "Fail";
            return View();
        }
    }
}