using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Runtime.Session;
using Abp.UI;
using BeiDream.Application.Authorization.Users.Dto;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;
using BeiDream.Core.Admin.SysManage.Authorization.Users;
using Microsoft.AspNet.Identity;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;

namespace BeiDream.Application.Authorization.Users
{
    public class UserAppService : AppServiceBase, IUserAppService
    {
        public async Task<PagedResultOutput<UserListDto>> GetUsers(GetUsersInput input)
        {
            var query = UserManager.Users
                .Include(u => u.Roles)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    u =>
                        u.Name.Contains(input.Filter) ||
                        u.Surname.Contains(input.Filter) ||
                        u.UserName.Contains(input.Filter) ||
                        u.EmailAddress.Contains(input.Filter)
                );

            var userCount = await query.CountAsync();
            var users = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var userListDtos = users.MapTo<List<UserListDto>>();

            return new PagedResultOutput<UserListDto>(
                userCount,
                userListDtos
                );
        }
    }
}
