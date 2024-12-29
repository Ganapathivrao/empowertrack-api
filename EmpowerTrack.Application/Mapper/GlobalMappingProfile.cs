using AutoMapper;
using EmpowerTrack.Core.Dto.Read;
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
            CreateMap<UserEntity, UserReadDto>().ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.EmployeeDb));

            CreateMap<UserReadDto, UserEntity>();

            CreateMap<MainModuleEntity, MainModReadDto>().ForMember(dest => dest.Forms, opt => opt.MapFrom(src => src.Forms));

            CreateMap<MainModReadDto, MainModuleEntity>();

            CreateMap<FormEntity, FormReadDto>();

            CreateMap<FormReadDto, FormEntity>();

            CreateMap<EmployeeEntity, EmployeeReadDto>().ForMember(dest=>dest.Role,opt=> opt.MapFrom(src => src.RoleDb));

            CreateMap<EmployeeReadDto, EmployeeEntity>();

            CreateMap<RoleEntity,RoleReadDto>();

            CreateMap<RoleReadDto, RoleEntity>();


        }
    }
}
