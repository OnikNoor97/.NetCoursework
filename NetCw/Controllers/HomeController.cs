using NetCw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCw.Controllers
{
   
    //[Authorize]// you cant access the index,about and contact unless your logged in
    public class HomeController : Controller
    {

        private ResearchDB db = new ResearchDB();

        public ActionResult Index()
        {
            ViewBag.events = db.Events.ToList();
            ViewBag.announcements = db.Announcements.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Announcements()
        {
            ViewBag.Message = "Your announcements page.";

            return View();
        }
    }
}