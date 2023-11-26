using MyEgitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Adress.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.Phone).FirstOrDefault();
            ViewBag.addressDetail = db.Adress.Select(x => x.AdressDetails).FirstOrDefault();
            ViewBag.mail = db.Adress.Select(x => x.Mail).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public ActionResult MessageList()
        {
            var values = db.Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}