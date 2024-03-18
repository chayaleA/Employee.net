using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;

namespace Solid.Core.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
