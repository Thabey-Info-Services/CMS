using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult HomeIndex()
        {
           

            return View();
        }
       
        public ActionResult Login()
        {


            return View();
        }
        public ActionResult NewRegistration()
        {


            return View();
        }
    }
}
