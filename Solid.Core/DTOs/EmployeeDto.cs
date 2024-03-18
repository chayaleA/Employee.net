using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string IdNumber { get; set; }

        public DateTime StartWork { get; set; }

        public bool Status { get; set; }

        public List<JobDto> JobList { get; set; }
    }
}
