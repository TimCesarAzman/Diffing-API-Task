using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace v1.Controllers
{
    public class PutController : Controller
    {
        // GET: Get
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Left()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Left(string[] Lb)
        {
            //At the press of the button the program import the data to the text file
            //and conforms that the import was successful with the "201 Created" message
            System.IO.File.AppendAllLines(Server.MapPath("~/App_Data/dbLeft.txt"),Lb);
            ViewBag.Ostvarjeno = "201 Created";
            return View();
        }
        [HttpGet]
        public ActionResult Right()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Right(string[] Rb)
        {
            //At the press of the button the program import the data to the text file
            //and conforms that the import was successful with the "201 Created" message
            System.IO.File.AppendAllLines(Server.MapPath("~/App_Data/dbRight.txt"), Rb);
            ViewBag.Ostvarjeno = "201 Created";
            return View();
        }

    }
}