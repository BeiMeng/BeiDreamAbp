using System;
using Abp.Authorization.Users;
using Abp.Dependency;
using Abp.UI;
using BeiDream.Core;

namespace BeiDream.Application.Admin.SysManage.Authorization
{
    public class AbpLoginResultTypeHelper : BeiDreamServiceBase, ITransientDependency
    {
        public Exception CreateExceptionForFailedLoginAttempt(AbpLoginResultType result, string usernameOrEmailAddress, string tenancyName)
        {
            switch (result)
            {
                case AbpLoginResultType.Success:
                    return new ApplicationException("登陆成功,禁止调用此方法！");
                case AbpLoginResultType.InvalidUserNameOrEmailAddress:
                case AbpLoginResultType.InvalidPassword:
                    return new UserFriendlyException("登陆失败", "用户名或密码错误");
                case AbpLoginResultType.InvalidTenancyName:
                    return new UserFriendlyException("登陆失败", "租户验证失败");
                case AbpLoginResultType.TenantIsNotActive:
                    return new UserFriendlyException("登陆失败", "当前租户已禁用");
                case AbpLoginResultType.UserIsNotActive:
                    return new UserFriendlyException("登陆失败", "用户已禁用,无法登陆");
                case AbpLoginResultType.UserEmailIsNotConfirmed:
                    return new UserFriendlyException("登陆失败", "用户邮箱未认证,无法登陆");
                default: //Can not fall to default actually. But other result types can be added in the future and we may forget to handle it
                    Logger.Warn("Unhandled login fail reason: " + result);
                    return new UserFriendlyException("登陆失败");
            }
        }
    }
}
