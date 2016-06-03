using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.PnSpa.Areas.MenuReply.Controllers
{
    public class MenuSettingController : AbpController
    {
        // GET: MenuReply/MenuSetting
        public ActionResult Index()
        {
            return View();
        }
    }
}