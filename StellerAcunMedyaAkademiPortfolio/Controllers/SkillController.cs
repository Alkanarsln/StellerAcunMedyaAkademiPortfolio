using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class SkillController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values = db.TblSkill.ToList();
            return View(values);
        }

        public ActionResult DeleteSkill(int id)
        {
            var values = db.TblSkill.Find(id);
            db.TblSkill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkill skill)
        {
            db.TblSkill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var update = db.TblSkill.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkill tblSkill)
        {
            var value = db.TblSkill.FirstOrDefault(x => x.SkillId == tblSkill.SkillId);
            value.SkillName = tblSkill.SkillName;
            value.Title = tblSkill.Title;
            value.Value = tblSkill.Value;
            value.Description = tblSkill.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}