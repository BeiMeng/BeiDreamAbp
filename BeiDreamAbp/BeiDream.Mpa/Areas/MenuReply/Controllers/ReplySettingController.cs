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
    public class ReplySettingController : AdminController
    {
        // GET: MenuReply/ReplySetting
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "回复设置";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
    }
}