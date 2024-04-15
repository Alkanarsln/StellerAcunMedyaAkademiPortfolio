using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }

        public ActionResult DeleteFeature(int id)
        {
            var values = db.TblFeature.Find(id);
            db.TblFeature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeature(TblFeature feature)
        {
            db.TblFeature.Add(feature);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var update = db.TblFeature.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature tblFeature)
        {
            var value = db.TblFeature.FirstOrDefault(x => x.FeatureID == tblFeature.FeatureID);
            value.NameSurname = tblFeature.NameSurname;
            value.Title = tblFeature.Title;
            value.Job = tblFeature.Job;
            value.CvDownloadUrl = tblFeature.CvDownloadUrl;
            value.ImageUrl = tblFeature.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}