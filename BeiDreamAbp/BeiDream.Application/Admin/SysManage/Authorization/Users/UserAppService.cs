using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Linq.Extensions;
using BeiDream.Application.Admin.SysManage.Authorization.Users.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Users
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
