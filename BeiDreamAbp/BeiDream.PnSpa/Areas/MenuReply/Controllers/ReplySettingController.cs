using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.PnSpa.Areas.MenuReply.Controllers
{
    public class ReplySettingController : AbpController
    {
        // GET: MenuReply/ReplySetting
        public ActionResult Index()
        {
            return View();
        }
    }
}