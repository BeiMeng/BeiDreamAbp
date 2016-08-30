using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.MetronicMpa.Areas.Admin.Models.Layout;
using BeiDream.MetronicMpa.Models.UI.DataTables;

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
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="draw">请求次数计数器</param>
        /// <param name="recordsTotal">总共记录数</param>
        /// <param name="recordsFiltered">过滤后的记录数</param>
        /// <param name="data">数据</param>
        /// <param name="error">服务器错误信息</param>
        public JsonResult DataTablesJson<TEntity>(int draw, int recordsTotal, int recordsFiltered,
            IReadOnlyList<TEntity> data, string error = null)
        {
            var result = new DataTablesResult<TEntity>(draw, recordsFiltered, recordsFiltered, data);
            var jsonResult = new JsonResult
            {
                Data = result
            };
            return jsonResult;
        }
    }
}