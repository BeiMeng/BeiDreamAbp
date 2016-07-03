using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;

namespace BeiDream.MetronicMpa.Areas.SysManage.Controllers
{
    public class ThemeSettingController : AdminController
    {
        // GET: SysManage/Users
        public  ActionResult Index()
        {
            LayoutParamsViewModel.Title = "主题设置";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
    }
}