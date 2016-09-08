using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Extensions;
using Abp.Linq.Extensions;
using BeiDream.Application.Admin.SysManage.Authorization.Roles.Dto;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;

namespace BeiDream.Application.Admin.SysManage.Authorization.Roles
{

    public class RoleAppService : AppServiceBase, IRoleAppService
    {
        private readonly RoleManager _roleManager;

        public RoleAppService(RoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<PagedResultOutput<RoleListDto>> GetRoles(GetRolesInput input)
        {
            var query = _roleManager.Roles.WhereIf(!input.Filter.IsNullOrWhiteSpace(), u => u.Name.Contains(input.Filter) ||
                        u.DisplayName.Contains(input.Filter))
                .WhereIf(!input.RoleName.IsNullOrWhiteSpace(), u => u.Name.Contains(input.Filter));
            var roleCount = await query.CountAsync();
            var roles = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var roleListDtos = roles.MapTo<List<RoleListDto>>();

            return new PagedResultOutput<RoleListDto>(
                roleCount,
                roleListDtos
                );
        }
    }
}
