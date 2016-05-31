using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeiDream.Mpa.App_Data;

namespace BeiDream.Mpa.Controllers
{

    public class HomeController : Controller
    {
        private readonly ITest _test;

        public HomeController(ITest test)
        {
            _test = test;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = _test.SayHello("啊 哈哈哈");
            return View();
        }
    }
}