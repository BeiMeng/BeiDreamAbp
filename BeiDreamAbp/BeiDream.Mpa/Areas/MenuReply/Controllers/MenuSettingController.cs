using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.MenuReply.Controllers
{
    public class MenuSettingController : AdminController
    {
        // GET: MenuReply/MenuSetting
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "菜单设置";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }

    }
}