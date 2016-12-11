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
    public class MissionQuestionsController : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        // GET: MissionQuestions
        public ActionResult Index()
        {
            return View();
            
        }

        // GET: MissionQuestions/Details/5
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

        // GET: MissionQuestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestions newQuestions, FormCollection form )
        {
            if (newQuestions != null)
            {
                string question = form["CreateQuestion"].ToString();
                var userEmail = User.Identity.Name;//this line of code will look at current user and find it's name
                var userObj = db.User.Where(m => m.UserEmail == userEmail).FirstOrDefault();//After the user is found then will store it's object into the the userObj

                newQuestions.Question = question;// now the  object question will be the form question
                newQuestions.Answer = " ";
                newQuestions.UserID = userObj.UserID;//assigning a useriD to the newly created question
                db.MissionQuestion.Add(newQuestions);//addint the newQuestion object to the MissionQuestion table
                db.SaveChanges();// Saving new changes

                return RedirectToAction("MissionFAQ", "Home", new { id = newQuestions.MissionID });
            }

            return View(newQuestions);
        }

        // GET: MissionQuestions/Edit/5
        public ActionResult Edit(int? id, MissionQuestions MissionQuestion)
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

        // POST: MissionQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestions missionQuestions, int? id)
        {
            if (missionQuestions != null)
            {
                var update = db.MissionQuestion.Find(id);//create a variable that is storing the question that it founds in the db

                update.Answer = missionQuestions.Answer;

                missionQuestions = update;

                db.Entry(missionQuestions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MissionFAQ", "Home", new { id = missionQuestions.MissionID });
            }
            return View(missionQuestions);
        }

     
    }
}
