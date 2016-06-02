using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Mpa.Areas.Admin.Models.Layout;

namespace BeiDream.Mpa.Areas.Admin.Controllers
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