using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BeiDream.MetronicMpa.Areas.Admin.Controllers
{
    [AbpMvcAuthorize]
    public class DashboardController : AdminController
    {
        // GET: Admin/Index
        public ActionResult Index(string activePageMenu)
        {
            LayoutParamsViewModel.Title = "主页";
            LayoutParamsViewModel.ActivePageMenuName = activePageMenu;
            return View(LayoutParamsViewModel);
        }
    }
}