using System.Web;
using Abp.Web.Mvc.Controllers;
using BeiDream.MetronicMpa.Areas.Admin.Models.Layout;

namespace BeiDream.MetronicMpa.Areas.Admin.Controllers
{
    public class AdminController:AbpController
    {
        protected LayoutParamsViewModel LayoutParamsViewModel { get; set; }
        public AdminController()
        {
            LayoutParamsViewModel = new LayoutParamsViewModel();
        }

        protected void WrapLayoutParams(HttpContextBase httpContext)
        {
            LayoutParamsViewModel.ActivePageMenuName =
                httpContext.Request.RequestContext.RouteData.DataTokens["area"].ToString();
            LayoutParamsViewModel.ActiveMenuName =
                httpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
        }
    }
}