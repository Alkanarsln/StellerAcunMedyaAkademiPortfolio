using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
         
            var values = db.TblProject.ToList();
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProject.Find(id);
            db.TblProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(TblProject project)
        {
            db.TblProject.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var update = db.TblProject.Find(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject tblProject)
        {
            var value = db.TblProject.FirstOrDefault(x => x.ProjectId == tblProject.ProjectId);
            value.Title = tblProject.Title;
            value.ImageUrl = tblProject.ImageUrl;
            value.GithubUrl = tblProject.GithubUrl;
            value.Description = tblProject.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}