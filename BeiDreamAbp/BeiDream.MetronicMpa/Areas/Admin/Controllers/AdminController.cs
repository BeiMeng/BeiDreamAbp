using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using BeiDream.MetronicMpa.Areas.Admin.Models.Layout;
using BeiDream.MetronicMpa.Models.UI.DataTables;
using Microsoft.AspNet.Identity;

namespace BeiDream.MetronicMpa.Areas.Admin.Controllers
{
    public abstract class AdminController:AbpController
    {
        protected LayoutParamsViewModel LayoutParamsViewModel { get; set; }

        protected AdminController()
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
        /// 后端接收输入参数验证(因为有前端验证,如果后端验证不通过,直接报出输入参数错误概要信息即可,不需要提供详细信息)
        /// </summary>
        protected virtual void CheckModelState()
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException("部分输入信息不符合要求，请检查并改正..");
            }
        }
        /// <summary>
        /// 登录错误信息的检查,Abp.Zero扩展
        /// </summary>
        /// <param name="identityResult"></param>
        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
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