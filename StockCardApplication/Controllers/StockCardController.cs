using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StockCardApplication.Models;

namespace StockCardApplication.Controllers
{
    public class StockCardController : Controller
    {
        DbServicesContext db = new DbServicesContext();
        // GET: StockCard
        public ActionResult Index()
        {
            return View(db.Tbl_stockcard.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StockCard stock)
        {
            db.Tbl_stockcard.Add(stock);
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
            var a = db.Tbl_stockcard.Where(model => model.Id == id).FirstOrDefault();
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(StockCard EditStock)
        {
            db.Entry(EditStock).State = EntityState.Modified;
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
    }
}