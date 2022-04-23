using _1_warmUp.Database;
using _1_warmUp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_warmUp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MeinContext _db;

        public CategoryController(MeinContext db)
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Name and Display Order Cannot be the same.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            

            //hem view içine, inpputlara required atacak hem de controller iicinde null kontrolü yapacak, eğer null ise hata sayfası donecek
            //cok iyi amk
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            return View();
        }
    }
}
