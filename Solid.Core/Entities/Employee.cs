using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public enum Gender { male = 1, female = 2 }
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string IdNumber { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public bool Status { get; set; }

        public List<Job> JobList { get; set; }
    }
}
