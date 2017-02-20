using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Models;

namespace WebAdvance.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(LoginModel login)
        {
            if(ModelState.IsValid)
            {
             
                if (login.UserName == "admin" && login.Password == "admin")
                    return View("Admin", login);
                else
                    return View("NonAdmin", login);
            }
            else
                return View();
        }

        
    }
}