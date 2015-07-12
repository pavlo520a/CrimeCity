using CrimeCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrimeCity.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            switch (model.Login)
            {
                case "admin":
                    return RedirectToAction("Admin", "Home");
            }
            return View();
        }
    }
}