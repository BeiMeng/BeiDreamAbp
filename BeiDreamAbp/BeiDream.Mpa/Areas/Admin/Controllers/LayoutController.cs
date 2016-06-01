﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp;
using Abp.Application.Navigation;
using Abp.Collections.Extensions;
using Abp.Threading;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;
using Abp.Extensions;
using Abp.Localization;

namespace BeiDream.Mpa.Areas.Admin.Controllers
{
    public class LayoutController : AbpController
    {
        private readonly IUserNavigationManager _userNavigationManager;

        public LayoutController(IUserNavigationManager userNavigationManager)
        {
            _userNavigationManager = userNavigationManager;
        }

        #region 根据菜单名称获取左侧导航项
        public PartialViewResult Sidebar(string activePageMenu)
        {
            if (activePageMenu.IsNullOrEmpty())
            {
                activePageMenu = "MenuReply";
            }
            var sidebarModel = new SidebarViewModel
            {
                Menu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync(activePageMenu, GetNormalizedUserIdentifier(null, AbpSession.UserId))),
                ActivePageMenuName = activePageMenu
            };
            return PartialView("_Sidebar", sidebarModel);
        }
        private UserIdentifier GetNormalizedUserIdentifier(int? tenantId, long? userId)
        {
            if (userId == null)
            {
                //No identifier
                return null;
            }

            if (tenantId != null)
            {
                //known tenant id
                return new UserIdentifier(tenantId, userId.Value);
            }

            if (userId == AbpSession.UserId)
            {
                //normalized tenant id
                return new UserIdentifier(AbpSession.TenantId, userId.Value);
            }

            //assumed as host user
            return new UserIdentifier(null, userId.Value);
        } 
        #endregion

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