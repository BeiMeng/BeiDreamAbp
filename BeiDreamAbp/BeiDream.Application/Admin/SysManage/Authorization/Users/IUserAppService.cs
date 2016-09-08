using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BeiDream.Application.Admin.SysManage.Authorization.Users.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Users
{
    /// <summary>
    /// 用户管理应用服务
    /// </summary>
    public interface IUserAppService : IApplicationService
    {
        /// <summary>
        /// 获取可分页用户列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultOutput<UserListDto>> GetUsers(GetUsersInput input);
    }
}