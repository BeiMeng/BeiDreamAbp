using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.SysManage.Controllers
{
    public class RoleController : AbpController
    {
        // GET: SysManage/Role
        public ActionResult Index()
        {
            return View(new CommonParamsViewModel()
            {
                Title = "角色管理",
                ActivePageMenuName = "SysManage",
                ActiveMenuName = "Role"
            });
        }
    }
}