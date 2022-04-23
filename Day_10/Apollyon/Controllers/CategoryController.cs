using Apollyon.Database;
using Apollyon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Apollyon.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApollyonContext _db;

        public CategoryController(ApollyonContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var allCategories = _db.Categories.ToList();
            return View(allCategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj != null)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();

                TempData["Created"] = "New record created successfuly!";

                var allCategories = _db.Categories.ToList();
                return View("Index", allCategories);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Edit(int? ID)
        {
            //anladım fakat 1dk

            if (ID != null)
            {
                var findCategory = _db.Categories.Find(ID);
                if (findCategory != null)
                {
                    var theCategory = findCategory;
                    return View(theCategory);
                }
            }

            var allCategories = _db.Categories.ToList();

            TempData["RecordNotFound"] = "The Record You're Looking For is Not Found!";
            return View("Index", allCategories);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(Category obj)
        {
            if (obj != null)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();

                TempData["Edited"] = "The record edited successfuly!";
                var allCategories = _db.Categories.ToList();

                return View("Index", allCategories);

            }
            return View();
        }
    }
}
