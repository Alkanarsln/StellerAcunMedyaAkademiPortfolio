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
            message.IsRead = false;
            db.TblMessage.Add(message);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        public PartialViewResult DefaultServicePartial()
        {
            var values = db.TblService.Where(x=>x.ServiceStatus==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultSkillPartial()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultTestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultContactPartial()
        {
            var values = db.TblContect.ToList();
            return PartialView(values);
        }
        public PartialViewResult UILayoutFooterPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultSocialMediaPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
    }
}