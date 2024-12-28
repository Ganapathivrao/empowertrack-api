using AutoMapper;
using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerTrack.Application.Mapper
{
    public class GlobalMappingProfile : Profile
    {
        public GlobalMappingProfile()
        {
            CreateMap<UserEntity, UserDto>().ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.EmployeeDb));

            CreateMap<UserDto, UserEntity>();

            CreateMap<MainModuleEntity, MainModDto>().ForMember(dest => dest.Forms, opt => opt.MapFrom(src => src.Forms));

            CreateMap<MainModDto, MainModuleEntity>();

            CreateMap<FormEntity, FormDto>();

            CreateMap<FormDto, FormEntity>();

            CreateMap<EmployeeEntity, EmployeeDto>().ForMember(dest=>dest.Role,opt=> opt.MapFrom(src => src.RoleDb));

            CreateMap<EmployeeDto, EmployeeEntity>();

            CreateMap<RoleEntity,RoleDto>();

            CreateMap<RoleDto, RoleEntity>();


        }
    }
}
