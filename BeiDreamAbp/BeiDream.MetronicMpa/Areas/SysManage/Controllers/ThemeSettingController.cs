using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BeiDream.Application.Admin.Configuration.Host;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;

namespace BeiDream.MetronicMpa.Areas.SysManage.Controllers
{
    public class ThemeSettingController : AdminController
    {
        private readonly IHostSettingsAppService _hostSettingsAppService;

        public ThemeSettingController(IHostSettingsAppService hostSettingsAppService)
        {
            _hostSettingsAppService = hostSettingsAppService;
        }

        // GET: SysManage/Users
        public async Task<ActionResult> Index()
        {
            LayoutParamsViewModel.Title = "主题设置";
            var themeSetting = await _hostSettingsAppService.GetAllThemeSettings();
            LayoutParamsViewModel.PageDatas = themeSetting;
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
    }
}