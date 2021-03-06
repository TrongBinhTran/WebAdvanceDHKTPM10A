﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Models;

namespace WebAdvance.Controllers
{
    public class TesterController : Controller
    {
        // GET: Tester
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.Message = "Add Tester";
            return View();
        }

        [HttpPost]
        public ViewResult Index(TesterModel tester)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Tester " + tester.Username + " is added";
            }
            else
                ViewBag.Message = "Error";
            return View();
        }
    }
}