using PROJECT1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PROJECT1.Models;

namespace PROJECT1.Controllers
{
    public class HomeController : Controller
    {

        MissionSiteContext db = new MissionSiteContext(); 
      
        
        public ActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users account, bool rememberMe = false) //account is the name of the Users object (Users is the model that we're dealing with) 
        {
            if (ModelState.IsValid)//this checks if all the fields that are required are filled 
            {
                    db.User.Add(account);
                    db.SaveChanges();
                
                ModelState.Clear();
                Session["UserID"] = account.UserID;
                Session["username"] = account.UserEmail;
                FormsAuthentication.SetAuthCookie(account.UserEmail.ToString(), rememberMe);

                return RedirectToAction("Loggedin", new { account.FirstName, account.LastName });

            }
            return View();

        }

        public ActionResult Loggedin (string FirstName, String LastName)
        {
            ViewBag.Message = FirstName + " " + LastName + " successfully registered. ";
            return View();
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


        //CREATE METHOD FOR LOGIN------------------------------------------------------------------------------

        public ActionResult Login()
        {
            return View();
        }

        //CREATE METHOD FOR LOGIN THAT WILL RECEIVE PARAMETERS --------------------------------------------------------


        /*[HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "Missouri") && (string.Equals(password, "ShowMe")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("login", "Home");

            }
            else
            {
                return View();
            }
        }*/

// created a mission method 
        public ActionResult Missions()
        {
     

            return View();
        }

// created a method to be used to display data for the different missions when specific mission is displayed 
       [Authorize]
        public ActionResult MissionFAQ(int name = 0)
        {

            if (name == 1)
            {
                ViewBag.Name = "Italy Rome";
                ViewBag.President = "Michael D. Pickerd";
                ViewBag.Address = "Italy Rome Mission Piazza Carnaro, 2000141 Rome, Italy";
                ViewBag.Phone = "Phone Number: 39-06-87193443"; 
                ViewBag.Language = "Italian";
                ViewBag.Climate = " The climate in Rome is warm and temperate. In winter, there is much more rainfall in Rome than in summer. According to Köppen and Geiger, this climate is classified as Csa. The average temperature in Rome is 15.7 °C. The rainfall here averages 798 mm.";
                ViewBag.DominateReg = "Roman Catholicism";
                ViewBag.Flag = "/Content/Images/flag-of-italy.png";
            }

            if (name == 2)
            {
                ViewBag.Name = "Brazil São Paulo West Mission";
                ViewBag.President = "Thomas W. Thomas";
                ViewBag.Address = " Brazil Sao Paulo West Mission, Rua Doutor Rui Batista Pereira 165 , CEP05517-080 Sao Paulo – SP, Brazil";
                ViewBag.Phone = "Phone Number: 55-11-3725-6231";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "São Paulo has a humid subtropical climate that is mild with no dry season, constantly moist (year-round rainfall). Summers are hot and muggy with thunderstorms. Winters are mild with precipitation from mid-latitude cyclones. Seasonality is moderate.";
                ViewBag.DominateReg = "Roman Catholicism";
                ViewBag.Flag = "/Content/Images/SanPaulo.gif";
            }

            if (name == 3)
            {
                ViewBag.Name = "Florida Tampa Mission";
                ViewBag.President = "Kendall J. Cooper";
                ViewBag.Address = "Forida Tampa Mission, 13510 N 42 St, Tampa FL 33613, USA";
                ViewBag.Phone = " Phone Number: 1-813-961-7400 ";
                ViewBag.Language = "English";
                ViewBag.Climate = "The Tampa Bay area has a humid subtropical climate (Köppen Cfa), with warm and humid summers with frequent thunderstorms and drier winters with freezing temperatures occurring every 2–3 years. The area experiences a significant summer wet season, as nearly two-thirds of the annual precipitation falls in the months of June through September.";
                ViewBag.DominateReg = "Catholic";
                ViewBag.Flag = "/Content/Images/floridaFlag.png";
            }

            return View();
        }
    }
}