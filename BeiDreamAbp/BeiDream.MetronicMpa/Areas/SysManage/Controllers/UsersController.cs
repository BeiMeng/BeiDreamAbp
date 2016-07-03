using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;

namespace BeiDream.MetronicMpa.Areas.SysManage.Controllers
{
    public class UsersController : AdminController
    {
        // GET: SysManage/Users
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "用户管理";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
    }
}