using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StockCardApplication.Models;

namespace StockCardApplication.Controllers
{
    public class UserController : Controller
    {   
        DbServicesContext db = new DbServicesContext();
        // GET: User
        public ActionResult Index()
        {
            return View(db.Tbl_user.ToList());
        }

        public ActionResult Create()  
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            db.Tbl_user.Add(user);
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.SubmitMsg = ("<script>alert('Something went wrong...')</script>");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var a = db.Tbl_user.Where(model => model.Id == id).FirstOrDefault();
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(User EditUser)
        {
            db.Entry(EditUser).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.EditMsg = ("<script>alert('Something went wrong...')</script>");
            }
            
            return View();
        }

        public ActionResult Delete(int id)
        {
            var a = db.Tbl_user.Where(model => model.Id == id).FirstOrDefault();
            return View(a);
        }

        [HttpPost]
        public ActionResult Delete(User EditUser)
        {
            db.Entry(EditUser).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.Clear();
                ViewBag.EditMsg = ("<script>alert('Something went wrong...')</script>");
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var row = db.Tbl_user.Where(model => model.UserName == user.UserName && model.Password == user.Password).FirstOrDefault();
            if (row != null)
            {
                return RedirectToAction("Index", "StockCard");
            }
            else
            {
                ViewBag.LoginMsg = ("<script>alert('Something went wrong...')</script>");
                ModelState.Clear();
            }
            return View();
        }

        public ActionResult Welcome()
        {
            return View(db.Tbl_user.ToList());
        }
    }
}