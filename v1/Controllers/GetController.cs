using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace v1.Controllers
{
    public class GetController : Controller
    {
        public List<string> Data1(string[] a)
        {
            //This method simple converts the array into a list. It also removes all of the },{ and spaces.
            List<string> odg = new List<string>();
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].StartsWith("{") || a[i].StartsWith("}") || a[i].StartsWith(" "))
                {
                    
                }
                else
                {
                    odg.Add(a[i]);
                }
                
            }

            return odg;
        }
        // GET: Get
        public ActionResult Index()
        {
            //Load the txt files
            string[] diff = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/dbLeft.txt"));
            string[] diff2 = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/dbRight.txt"));
            //Converts to list.
            List<string> leftList = Data1(diff);
            List<string> rightList = Data1(diff2);


            //If left or right txt file doesn't contain no data it return the "404"
            if (leftList.Count == 0 || rightList.Count == 0)
            {
                ViewBag.Naslov = "404 Not Found";
            }
            //Compare the data if it is equal
            else if (leftList.SequenceEqual(rightList))
            {
                ViewBag.Naslov = "Equals";
            }
            //Checks if either the left or the right lists are longer, if they are it displays the lengths.
            //I didn't understand what offset you want me to display.
            else if(leftList.Count != rightList.Count)
            {
                ViewBag.Naslov = "Content do not match:";
                ViewBag.Left = "Left length:" + leftList.Count.ToString();
                ViewBag.Right = "Right length:" + rightList.Count.ToString();
            }
            //If none of the above if statements applies output "SizeDoNotMatch"
            else
            {
                ViewBag.Naslov = "SizeDoNotMatch";
            }
            
          

            

            return View();
        }
    }
}