using Solid.Core.Entities;

namespace EmployeeServer.Models
{
    public class JobPostModel
    {
        public string JobName { get; set; }

        public bool IsManager { get; set; }

        public DateTime startJob { get; set; }
    }
}
