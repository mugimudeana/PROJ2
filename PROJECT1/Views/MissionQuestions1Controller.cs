using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PROJECT1.DAL;
using PROJECT1.Models;

namespace PROJECT1.Views
{
    public class MissionQuestions1Controller : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        // GET: MissionQuestions1
        public ActionResult Index()
        {
            return View(db.MissionQuestion.ToList());
        }

        // GET: MissionQuestions1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestions missionQuestions = db.MissionQuestion.Find(id);
            if (missionQuestions == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestions);
        }

        // GET: MissionQuestions1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionQuestions1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestions missionQuestions)
        {
            if (ModelState.IsValid)
            {
                db.MissionQuestion.Add(missionQuestions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missionQuestions);
        }

        // GET: MissionQuestions1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestions missionQuestions = db.MissionQuestion.Find(id);
            if (missionQuestions == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestions);
        }

        // POST: MissionQuestions1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestions missionQuestions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missionQuestions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missionQuestions);
        }

        // GET: MissionQuestions1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestions missionQuestions = db.MissionQuestion.Find(id);
            if (missionQuestions == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestions);
        }

        // POST: MissionQuestions1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissionQuestions missionQuestions = db.MissionQuestion.Find(id);
            db.MissionQuestion.Remove(missionQuestions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
