using Solid.Core.Entities;

namespace EmployeeServer.Models
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string IdNumber { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public bool Status { get; set; }

        public List<JobPostModel> JobList { get; set; }
    }
}
