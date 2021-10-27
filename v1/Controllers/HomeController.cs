using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace v1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string a)
        {
            //At the press of the button both of the txt files get cleared. ViewBag return confirmation that the file was successfully cleared.
            System.IO.File.WriteAllText(Server.MapPath("~/App_Data/dbLeft.txt"),String.Empty);
            System.IO.File.WriteAllText(Server.MapPath("~/App_Data/dbRight.txt"), String.Empty);
            ViewBag.Reset = "File was reseted";

            return View();
        }
    }
}