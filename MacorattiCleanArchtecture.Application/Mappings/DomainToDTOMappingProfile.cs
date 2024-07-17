using AutoMapper;
using MacorattiCleanArchtecture.Application.DTOs;
using MacorattiCleanArchtecture.Domain.Entities.Company;
using MacorattiCleanArchtecture.Domain.Entities.Employee;

namespace MacorattiCleanArchtecture.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
