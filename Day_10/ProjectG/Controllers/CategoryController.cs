using Microsoft.AspNetCore.Mvc;
using ProjectG.Database;
using ProjectG.Models;

namespace ProjectG.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProjectGContext _db;

        public CategoryController(ProjectGContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var getCategories = _db.Categories.ToList();
            return View(getCategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult Create(Category obj)
        {
            if (obj != null)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();

                TempData["Created"] = "A new record created successfuly.";

                var allCategories = _db.Categories.ToList();
                return View("Index", allCategories);
            }

            TempData["SomethingWentWrong"] = "Somethings Went Wrong, try again";
            return View();
        }

        public IActionResult Edit(int? ID)
        {
            if (ID != null)
            {
                var findCategory = _db.Categories.Find(ID);
                return View(findCategory);
            }

            TempData["SomethingWentWrong"] = "Somethings Went Wrong, try again";
            return View();
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(Category obj)
        {
            if (obj != null)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();

                TempData["Edited"] = "The record edited successfuly.";

                var allCategories = _db.Categories.ToList();

                return View("Index", allCategories);
            }

            TempData["SomethingWentWrong"] = "Somethings Went Wrong, try again";
            return View();
        }

        public IActionResult Delete(int? ID)
        {
            if (ID != null)
            {
                var findCategory = _db.Categories.Find(ID);
                return View(findCategory);
            }

            TempData["SomethingWentWrong"] = "Somethings Went Wrong, try again";
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(Category obj)
        {
            if (obj != null)
            {
                _db.Categories.Remove(obj);
                _db.SaveChanges();

                TempData["Deleted"] = "The record deleted.";

                var allCategories = _db.Categories.ToList();

                return View("Index", allCategories);
            }

            TempData["SomethingWentWrong"] = "Somethings Went Wrong, try again";
            return View();
        }
    }
}
