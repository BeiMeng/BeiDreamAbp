using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Threading;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.Admin.Controllers
{
    public class LayoutController : AbpController
    {
        public PartialViewResult Sidebar()
        {
            var sidebarModel = new SidebarViewModel
            {
                Menu =new UserMenu(),
                CurrentPageName = ""
            };
            return PartialView("_Sidebar", sidebarModel);
        }
        public PartialViewResult NotificationMenu()
        {
            var notificationMenuModel = new NotificationMenuViewModel();
            return PartialView("_NotificationMenu", notificationMenuModel);
        }
        public PartialViewResult PageMenu()
        {
            var pageMenu = new PageMenuViewModel();
            return PartialView("_PageMenu", pageMenu);
        }
    }
}