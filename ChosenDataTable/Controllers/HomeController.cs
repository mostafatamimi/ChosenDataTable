using ChosenDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChosenDataTable.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<Students> myModel = new List<Students>();
            for(int i=0;i<10;i++)
            {
                myModel.Add(new Students
                {
                    ID=i,
                    Name = "Name "+i,
                    Age = i*2+3,
                    Major = "Computer"
                });
            }
            return View(myModel);
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
    }
}