using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.Mpa.Areas.Admin.Controllers
{
    public class DashboardController : AbpController
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            ViewBag.Title = "主页";
            ViewBag.ActivePageMenu = "Business";
            return View();
        }
    }
}