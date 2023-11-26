using MyEgitimAkademi_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Education.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            db.Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEducation(int id)
        {
            var value = db.Education.Find(id);
            db.Education.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.Education.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            var value = db.Education.Find(education.EducationID);
            value.EducationTitle = education.EducationTitle;
            value.EducationBaslangıc = education.EducationBaslangıc;
            value.EducationBitis = education.EducationBitis;
            value.EducationDescription = education.EducationDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}