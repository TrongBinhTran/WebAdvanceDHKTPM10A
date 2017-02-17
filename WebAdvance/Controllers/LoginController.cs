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
        public ViewResult Index(LoginResponse loginResponse)
        {
            if(ModelState.IsValid)
            {
                if (loginResponse.UserName == "admin" && loginResponse.Password == "admin")
                {
                    return View("Admin", loginResponse);
                }
                else
                {
                    return View("NoneAdmin", loginResponse);
                }
            }
            else
            {
                return View();
            }
            
        }

        
    }
}