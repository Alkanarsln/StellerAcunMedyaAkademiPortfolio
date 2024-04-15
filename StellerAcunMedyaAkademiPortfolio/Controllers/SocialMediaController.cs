using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var values = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia socialMedia)
        {
            db.TblSocialMedia.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var update = db.TblSocialMedia.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia tblSocialMedia)
        {
            var value = db.TblSocialMedia.FirstOrDefault(x => x.SocialMediaId == tblSocialMedia.SocialMediaId);
            value.Icon = tblSocialMedia.Icon;
            value.SocialMediaName = tblSocialMedia.SocialMediaName;
            value.Url = tblSocialMedia.Url;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}