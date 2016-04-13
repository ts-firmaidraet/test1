using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Logic;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyFirstClass cls = new MyFirstClass();
            ViewBag.Stringresult = cls.getString() + "test";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}