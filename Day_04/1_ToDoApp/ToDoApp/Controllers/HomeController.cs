using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.CRUD;
using ToDoApp.Database;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMission(AddingMissionModel incomingModel)
        {
            var resultat = Operations.AddMission(incomingModel);
            return View("~/Views/Home/Index.cshtml", resultat);
        }
    }
}