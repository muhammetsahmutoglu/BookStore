using BookStore.Model.Entity;
using BookStore.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.UI.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        // GET: Admin/Categoryssss
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.CategoryName;
                category.CategoryDescription = model.CategoryDescription;
                db.Categories.Add(category);
                db.SaveChanges();
                ViewBag.ProcessCondition = 1;
                return View();
            }
            else
            {
                ViewBag.ProcessCondition = 2;
                return View();
            }
        }
    }
}