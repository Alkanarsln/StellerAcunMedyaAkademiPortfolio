using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class MessageController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblMessage.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TblMessage.Find(id);
            db.TblMessage.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMessage(TblMessage message)
        {
            db.TblMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var update = db.TblMessage.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateMessage(TblMessage tblMessage)
        {
            var value = db.TblMessage.FirstOrDefault(x => x.MessageId == tblMessage.MessageId);
            value.NameSurname = tblMessage.NameSurname;
            value.MessageContent = tblMessage.MessageContent;
            value.Email = tblMessage.Email;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}