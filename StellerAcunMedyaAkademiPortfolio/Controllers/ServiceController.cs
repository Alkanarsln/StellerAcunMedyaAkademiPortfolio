using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblService.ToList();
            return View(values);
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.TblService.Find(id);
            db.TblService.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService (TblService service)
        {
            db.TblService.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var update = db.TblService.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateService(TblService tblService)
        {
            var value = db.TblService.FirstOrDefault(x => x.ServiceId == tblService.ServiceId);
            value.ServiceIconUrl = tblService.ServiceIconUrl;
            value.ServiceName = tblService.ServiceName;
            value.ServiceStatus = tblService.ServiceStatus;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}