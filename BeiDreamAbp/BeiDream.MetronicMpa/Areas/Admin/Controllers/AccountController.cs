using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Authorization.Users;
using Abp.Web.Mvc.Models;
using BeiDream.Application.Admin.SysManage.Authorization;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;
using BeiDream.Core.Admin.SysManage.Authorization.Users;
using BeiDream.Core.Admin.SysManage.MultiTenancy;
using BeiDream.MetronicMpa.Areas.Admin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace BeiDream.MetronicMpa.Areas.Admin.Controllers
{
    public class AccountController : AdminController
    {
        private readonly UserManager _userManager;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public AccountController(UserManager userManager, AbpLoginResultTypeHelper abpLoginResultTypeHelper)
        {
            _userManager = userManager;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
        }

        // GET: Admin/Account
        public ActionResult Login(string returnUrl="")
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = Url.Action("Index", "Dashboard");
            }

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public virtual async Task<JsonResult> Login(LoginVm loginVm, string returnUrl = "")
        {
            CheckModelState();
            var loginResult = await GetLoginResultAsync(loginVm.UsernameOrEmailAddress, loginVm.Password);
            await SignInAsync(loginResult.User, loginResult.Identity, loginVm.RememberMe);

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = Url.Action("Index", "Dashboard");
            }

            return Json(new MvcAjaxResponse { TargetUrl = returnUrl });
        }
        private async Task SignInAsync(User user, ClaimsIdentity identity = null, bool rememberMe = false)
        {
            if (identity == null)
            {
                identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = rememberMe }, identity);
        }
        private async Task<AbpUserManager<Tenant, Role, User>.AbpLoginResult> GetLoginResultAsync(string usernameOrEmailAddress, string password)
        {
            var loginResult = await _userManager.LoginAsync(usernameOrEmailAddress, password, null);
            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, null);
            }
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Login");
        }
    }
}