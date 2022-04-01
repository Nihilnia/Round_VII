using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using warmUp.Models.Database;
using warmUp.Models.Operations;

namespace warmUp.Controllers
{
    public class GloriaController : Controller
    {
        // GET: Gloria
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPeople(People newPeople)
        {
            //People daPeople = new People()
            //{
            //    UserName = newPeople.UserName,
            //    Password = newPeople.Password,
            //    isActive = true
            //};

            var resultat = CRUD.AddPeople(newPeople);

            if (resultat)
            {
                return View("/Views/BasicMessages/_Success.cshtml");
            }
            else
            {
                return View("/Views/BasicMessages/_Fail.cshtml");
            }

        }

        [HttpPost]
        public ActionResult GetPeople()
        {
            var model = CRUD.GetPeople();
            return View("/Views/Gloria/People.cshtml", model);
        }
    }
}