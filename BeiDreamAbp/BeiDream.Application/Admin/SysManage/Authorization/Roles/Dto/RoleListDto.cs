using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;

namespace BeiDream.Application.Admin.SysManage.Authorization.Roles.Dto
{
    [AutoMapFrom(typeof(Role))]
    public class RoleListDto : EntityDto, IHasCreationTime
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool IsStatic { get; set; }

        public bool IsDefault { get; set; }

        public DateTime CreationTime { get; set; }
    }
}