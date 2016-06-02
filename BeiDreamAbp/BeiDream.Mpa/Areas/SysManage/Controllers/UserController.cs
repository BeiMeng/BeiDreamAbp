using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.SysManage.Controllers
{
    public class UserController : AbpController
    {
        // GET: SysManage/User
        public ActionResult Index()
        {
            return View(new CommonParamsViewModel()
            {
                Title = "用户管理",
                ActivePageMenuName = "SysManage",
                ActiveMenuName="User"
            });
        }
    }
}