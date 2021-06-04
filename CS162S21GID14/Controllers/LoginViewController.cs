using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS162S21GID14.Controllers
{
    public class LoginViewController : Controller
    {
        // GET: Login
        public ActionResult LoginView()
        {
            return View();
        }
    }
}