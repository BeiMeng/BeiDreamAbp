using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BeiDream.Application.Admin.SysManage.Authorization.Users.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<PagedResultOutput<UserListDto>> GetUsers(GetUsersInput input);
    }
}