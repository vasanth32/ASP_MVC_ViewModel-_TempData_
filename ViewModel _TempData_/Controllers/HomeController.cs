using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewModel__TempData_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method4()
        {
            string Name;
            int Age;
            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());
            // do something with userName or userAge here 
            return View();
        }
    }
}