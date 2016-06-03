using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace BeiDream.PnSpa.Areas.SysManage.Controllers
{
    public class RoleController : AbpController
    {
        // GET: SysManage/Role
        public ActionResult Index()
        {
            return View();
        }
    }
}