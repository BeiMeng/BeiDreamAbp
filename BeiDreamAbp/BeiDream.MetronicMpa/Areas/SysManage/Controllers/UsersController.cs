using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BeiDream.Application.Authorization.Users;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;

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
        public async Task<ActionResult> Index()
        {
            var users =await _userAppService.GetUsers(new GetUsersInput());
            LayoutParamsViewModel.Title = "用户管理";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
    }
}