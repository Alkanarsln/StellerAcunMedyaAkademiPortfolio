using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultFeaturePartial()
        {
            ViewBag.Project = db.TblProject.Count();
            ViewBag.Testimonial = db.TblTestimonial.Count();
            ViewBag.Skill = db.TblSkill.Count();
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultAboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SendMessage(TblMessage message)
        {
            db.TblMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}