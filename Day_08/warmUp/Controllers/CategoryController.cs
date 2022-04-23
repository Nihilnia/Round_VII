using Microsoft.AspNetCore.Mvc;
using warmUp.Database;
using warmUp.Models;

namespace warmUp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ForgetAboutFreemanContext _db;

        public CategoryController(ForgetAboutFreemanContext db)
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
            if (obj.DisplayOrder.ToString() == obj.Name)
            {
                ModelState.AddModelError("CustomErrMessage", "Name and Display Order Cannot be the same.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Item created succesfuly.";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var getCategory = _db.Categories.Find(id);
            if (getCategory == null)
            {
                return NotFound();
            }

            return View(getCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (obj.DisplayOrder.ToString() == obj.Name)
            {
                ModelState.AddModelError("CustomErrMessage", "Name and Display Order Cannot be the same.");
                return View(obj);
            }

            _db.Categories.Update(obj);
            //findCategory.Name = obj.Name;
            //findCategory.DisplayOrder = obj.DisplayOrder;
            
            _db.SaveChanges();
            TempData["edited"] = "Item Edited succesfuly.";
            var getCategories = _db.Categories.ToList();
            return View("Index", getCategories);
        }


        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var getCategory = _db.Categories.Find(id);
                return View(getCategory);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            if (id != null)
            {
                var findCategory = _db.Categories.Find(id);

                if (findCategory != null)
                {
                    _db.Categories.Remove(findCategory);
                    _db.SaveChanges();
                    TempData["deleted"] = "Item Deleted succesfuly.";
                    var getCategories = _db.Categories.ToList();
                    return View("Index", getCategories);
                }
            }
            return View("Index");
        }




    }
}
