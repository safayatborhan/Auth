using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppEmpty.Models;

namespace MvcAppEmpty.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [AllowAnonymous]  //This can be access by using this keyword, while there is a Authorize attribute in startup class
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            return Redirect("/");
        }
    }
}