using BookStore.Model.Entity;
using BookStore.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.UI.Areas.Admin.Controllers
{
    public class BookController : BaseController
    {
        // GET: Admin/Book
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(BookDTO model)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book();
                book.BookName = model.BookName;
                book.BookDescription = model.BookDescription;
                book.CategoryID = model.CategoryID;
                db.Books.Add(book);
                db.SaveChanges();
                return View();

            }
            else
            {
                return View();
            }
        }
    }
}