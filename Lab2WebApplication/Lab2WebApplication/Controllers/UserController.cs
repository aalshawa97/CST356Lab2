using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Lab2WebApplication.Data.Entities;
using Lab2WebApplication.Data;

namespace Lab2WebApplication.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            user.Id = InMemoryDatabase.NextId();
            InMemoryDatabase.Users.Add(user);

            return RedirectToAction("UserList");
        }

        public ActionResult UserList()
        {
            var users = InMemoryDatabase.Users;

            return View(users);
        }
        public ActionResult Details(int id)
        {
            var user = InMemoryDatabase.Users.Find(u => u.Id == id);

            return View(user);
        }

        public ActionResult Delete(int id)
        {
            InMemoryDatabase.DeleteUser(id);

            return RedirectToAction("UserList");
        }
       
    }
}