﻿using AutoMapper;
using LinCms.Application.Contracts.Cms.Permissions;
using LinCms.Core.Entities;

namespace LinCms.Application.AutoMapper.Cms
{
    public class PermissionProfile : Profile
    {
        public PermissionProfile()
        {
            CreateMap<LinPermission,PermissionDto>();
        }
    }
}
