using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.CRUD;
using ToDoApp.Database;

namespace ToDoApp.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginControl(User incomingUser)
        {
            var resultat = Operations.LoginControl(incomingUser);

            if (resultat != null)
            {
                return View("~/Views/Home/Index.cshtml", resultat);
            }
            else
            {
                return View("~/Views/Welcome/Index.cshtml", resultat);
            }

            
        }

        public ActionResult Register()
        {
            return View();
        }
        
        public ActionResult RegisterControl(User incomingUser)
        {
            var resultat = Operations.Register(incomingUser);

            if (resultat != null)
            {
                return View("~/Views/Welcome/Index.cshtml", resultat);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml", resultat);
            }
        }
    }
}