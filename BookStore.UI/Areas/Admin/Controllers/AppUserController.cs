using BookStore.Model.Entity;
using BookStore.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        // GET: Admin/AppUser
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Password = model.Password;
                user.Role = model.Role;
                user.Gender = model.Gender;
                db.AppUsers.Add(user);
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