using Abp.Runtime.Validation;
using BeiDream.Application.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Roles.Dto
{
    public class GetRolesInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string RoleName { get; set; }
        public string Filter { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "CreationTime";
            }
        }
    }
}