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

namespace PROJECT1.Controllers
{
    public class MissionsController : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        // GET: Missions
        public ActionResult Index()
        {
            var listof = db.Mission.ToList();// I'm using the listof var to hold all the missions
            ViewBag.ListMissions = listof;//storing the mission list to a viewbag since it can store "everything"
            return View();
        }




        //----------------------------------------------------

        [Authorize]
        public ActionResult Missions(int? id)
        {
            Missions currentMission = db.Mission.Find(id);//the parameter received will be the id used to search in the mission table

            if (currentMission == null)
            {
                return HttpNotFound();
            }
            else
            {
                var currentMissionQuestions = db.MissionQuestion.Where(question => question.MissionID == id);//the var currentMissionQuestions will store all the questions that belong to the missionID

                ViewBag.currentQuestions = currentMissionQuestions.ToList();//this viewbag will store the list of questions of missionID  
            }

            return View(currentMission);
        }




        // GET: Missions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Mission.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // GET: Missions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Missions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionID,MissionName,PresidentName,MissionAddress,Language,Climate,DominantReligion,Flag")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Mission.Add(missions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missions);
        }

        // GET: Missions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Mission.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionID,MissionName,PresidentName,MissionAddress,Language,Climate,DominantReligion,Flag")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missions);
        }

        // GET: Missions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Mission.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Missions missions = db.Mission.Find(id);
            db.Mission.Remove(missions);
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
