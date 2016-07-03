using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BeiDream.Application.Authorization.Users.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;

namespace BeiDream.Application.Authorization.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<PagedResultOutput<UserListDto>> GetUsers(GetUsersInput input);
    }
}