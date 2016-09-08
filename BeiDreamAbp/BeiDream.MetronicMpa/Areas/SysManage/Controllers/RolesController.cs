using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BeiDream.Application.Admin.SysManage.Authorization.Roles;
using BeiDream.Application.Admin.SysManage.Authorization.Roles.Dto;
using BeiDream.MetronicMpa.Areas.Admin.Controllers;
using BeiDream.MetronicMpa.Areas.SysManage.Models;

namespace BeiDream.MetronicMpa.Areas.SysManage.Controllers
{
    public class RolesController : AdminController
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        // GET: SysManage/Roles
        public ActionResult Index()
        {
            LayoutParamsViewModel.Title = "角色管理";
            WrapLayoutParams(this.HttpContext);
            return View(LayoutParamsViewModel);
        }
        public async Task<JsonResult> GetRoleDatas(RoleQueryVm query)
        {
            GetRolesInput rolesInput = new GetRolesInput();
            rolesInput.RoleName = query.RoleName;
            rolesInput.Filter = query.Search.Value;
            rolesInput.SkipCount = query.Start;
            rolesInput.MaxResultCount = query.Length;
            rolesInput.Sorting = query.OrderBy + " " + query.OrderDir;
            var roles = await _roleAppService.GetRoles(rolesInput);
            return DataTablesJson(query.Draw, roles.TotalCount, roles.TotalCount, roles.Items);
        }
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
            return PartialView("_CreateOrEditModal", id.ToString());
        }
    }
}