using System;
using Abp.Runtime.Validation;
using BeiDream.Application.Dto;

namespace BeiDream.Application.Admin.SysManage.Authorization.Users.Dto
{
    public class GetUsersInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string UserName { get; set; }
        public DateTime StartCreateTime { get; set; }
        public DateTime EndCreateTime { get; set; }
        public string Filter { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name,Surname";
            }
        }
    }
}