using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.AdvanceHistory;
using AdvanceAPI.DTOs.BusinessUnit;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.DTOs.Title;
using AdvanceAPI.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<EmployeeRegisterDTO, Employee>()
               .ForMember(dest => dest.Id, opt => opt.Ignore()) 
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore()) 
               .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore()) 
               .ForMember(dest => dest.BusinessUnit, opt => opt.Ignore())
               .ForMember(dest => dest.Title, opt => opt.Ignore()) 
               .ForMember(dest => dest.UpperEmployee, opt => opt.Ignore());

            CreateMap<Employee, EmployeeSelectDTO>().ReverseMap();
            CreateMap<Title, TitleSelectDTO>().ReverseMap();
            CreateMap<BusinessUnit, BusinessUnitSelectDTO>().ReverseMap();
            CreateMap<Advance, AdvanceInsertDTO>().ReverseMap();
            CreateMap<AdvanceHistory, AdvanceHistoryInsertDTO>().ReverseMap();

        }
    }
}
