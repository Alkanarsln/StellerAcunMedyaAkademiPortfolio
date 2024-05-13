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
            var values = db.TblMessage.Where(x => x.IsRead == false).ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.TblMessage.Find(id);
            db.TblMessage.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MessageDetail(int id)
        {
            var message = db.TblMessage.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return View(message);
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

        public ActionResult ReadMessages()
        {
            var values = db.TblMessage.Where(x => x.IsRead == true).ToList();
            return View(values);
        }
    }
}