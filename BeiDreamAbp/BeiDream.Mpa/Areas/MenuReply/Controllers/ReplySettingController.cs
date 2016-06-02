using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.Mpa.Areas.MenuReply.Controllers
{
    public class ReplySettingController : AbpController
    {
        // GET: MenuReply/ReplySetting
        public ActionResult Index()
        {
            ViewBag.ActivePageMenu = "MenuReply";
            ViewBag.ActiveMenu = "ReplySetting";
            return View();
        }
    }
}