using CRUDOps.DBOperations;
using CRUDOps.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOps.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        //Add User
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User incomingUser)
        {

            return View();
        }


        [HttpPost]
        public ActionResult Choice(User incomingUser, string getAllUsers, string addNewUser, string deleteUser, string updateUser) //what if there are billions of checkbox? lasfjaksjf
        {
            var model = new List<User>();

            if (incomingUser != null)
            {
                CRUD.addUser(incomingUser);
                model = CRUD.getAllUsers();

            }  
            return View("~/Views/Gloria/Index.cshtml", model);
        }

        
    }
}