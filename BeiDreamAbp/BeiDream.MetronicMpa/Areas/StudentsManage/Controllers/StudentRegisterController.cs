using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;

namespace BeiDream.MetronicMpa.Areas.StudentsManage.Controllers
{

    public class StudentRegisterController : AdminController
    {
        // GET: StudentsManage/StudentRegister
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "学生注册";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }

    }
}