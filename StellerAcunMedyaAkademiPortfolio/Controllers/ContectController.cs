using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class ContectController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblContect.ToList();
            return View(values);
        }
        public ActionResult DeleteContect(int id)
        {
            var values = db.TblContect.Find(id);
            db.TblContect.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateContect()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContect(TblContect contect)
        {
            db.TblContect.Add(contect);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContect(int id)
        {
            var update = db.TblContect.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateContect(TblContect tblContect)
        {
            var values = db.TblContect.FirstOrDefault(x => x.ContectId == tblContect.ContectId);
            values.Address = tblContect.Address;
            values.Email = tblContect.Email;
            values.Phone = tblContect.Phone;
            values.MapUrl = tblContect.MapUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}