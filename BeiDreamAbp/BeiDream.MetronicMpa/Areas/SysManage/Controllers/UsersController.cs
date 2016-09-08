using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BeiDream.Application.Admin.SysManage.Authorization.Users;
using BeiDream.Application.Admin.SysManage.Authorization.Users.Dto;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;
using BeiDream.MetronicMpa.Areas.SysManage.Models;

namespace BeiDream.MetronicMpa.Areas.SysManage.Controllers
{
    public class UsersController : AdminController
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: SysManage/Users
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "用户管理";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }

        public async Task<JsonResult> GetUserDatas(UserQueryVm query)
        {
            GetUsersInput usersInput=new GetUsersInput();
            usersInput.UserName = query.UserName;
            usersInput.StartCreateTime = query.StartCreateTime;
            usersInput.Filter = query.Search.Value;
            usersInput.SkipCount = query.Start;
            usersInput.MaxResultCount = query.Length;
            usersInput.Sorting = query.OrderBy + " " + query.OrderDir;
            var users = await _userAppService.GetUsers(usersInput);
            return DataTablesJson(query.Draw, users.TotalCount, users.TotalCount, users.Items);
        }
        public async Task<PartialViewResult> CreateOrEditModal(long? id)
        {
            return PartialView("_CreateOrEditModal", id.ToString());
        }
    }
}