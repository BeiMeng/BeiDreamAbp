using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BeiDream.Application.Admin.SysManage.Authorization.Roles.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Roles
{
    /// <summary>
    /// 角色管理应用服务
    /// </summary>
    public interface IRoleAppService : IApplicationService
    {
        /// <summary>
        /// 获取可分页的角色列表信息
        /// </summary>
        /// <returns></returns>
        Task<PagedResultOutput<RoleListDto>> GetRoles(GetRolesInput input);
    }
}