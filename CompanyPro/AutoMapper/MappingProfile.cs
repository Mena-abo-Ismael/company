using AutoMapper;
using CompanyPro.Models;
using CompanyPro.ViewModels;

namespace CompanyPro.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, GetAllEmployeesViewModel>()
                .ForMember(dest => dest.EmpName, op => op.MapFrom(src => src.Name))
                .ForMember(dest => dest.DeptName, op => op.MapFrom(src => src.Department.Name))
                //.ForMember(dest => dest.Address, op => op.MapFrom(src => src.Address))
                .ForMember(dest => dest.Eid, op => op.MapFrom(src => src.EId))
                //.ForMember(dest => dest.Salary, op => op.MapFrom(src => src.Salary))
                .ReverseMap();

            CreateMap<Department, GetAllDepartmentsViewModel>()
                .ForMember(dest=>dest.DepartmentName, opt=>opt.MapFrom(src=>src.Name))
                .ForMember(dest=>dest.DepartmentLocation, opt=>opt.MapFrom(src=>src.Location))
                .ReverseMap();
        }
    }
}
