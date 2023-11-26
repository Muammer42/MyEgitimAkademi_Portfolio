using MyEgitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAward()
        {
            var values = db.Project.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var value = db.Testimonial.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialProject()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return PartialView();
        }
      
        public PartialViewResult PartialStatistic()
        {
            var value = db.Statistic.ToList();
            return PartialView(value);


        }
    }
}