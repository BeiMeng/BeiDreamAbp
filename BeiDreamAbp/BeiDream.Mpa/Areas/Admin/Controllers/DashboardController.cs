using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.Admin.Controllers
{
    public class DashboardController : AbpController
    {
        // GET: Admin/Index
        public ActionResult Index(string activePageMenu)
        {
            return View(new CommonParamsViewModel()
            {
                Title = "主页",
                ActivePageMenuName=activePageMenu
            });
        }
    }
}