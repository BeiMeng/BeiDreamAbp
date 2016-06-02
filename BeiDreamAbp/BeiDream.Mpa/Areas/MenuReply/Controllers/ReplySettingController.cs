using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.MenuReply.Controllers
{
    public class ReplySettingController : AbpController
    {
        // GET: MenuReply/ReplySetting
        public ActionResult Index()
        {
            return View(new CommonParamsViewModel()
            {
                Title = "回复设置",
                ActivePageMenuName = "MenuReply",
                ActiveMenuName = "ReplySetting"
            });
        }
    }
}