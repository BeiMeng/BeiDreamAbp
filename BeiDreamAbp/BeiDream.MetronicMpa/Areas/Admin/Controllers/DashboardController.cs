using System.Web.Mvc;

namespace BeiDream.MetronicMpa.Areas.Admin.Controllers
{
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