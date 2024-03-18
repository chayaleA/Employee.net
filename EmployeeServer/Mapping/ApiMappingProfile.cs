using AutoMapper;
using EmployeeServer.Models;
using Solid.Core.Entities;
namespace EmployeeServer.Mapping
{
    public class ApiMappingProfile: Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<EmployeePostModel, Employee>().ReverseMap();

            CreateMap<JobPostModel, Job>().ReverseMap();
        }
    }
}
