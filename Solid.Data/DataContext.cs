using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext: DbContext
    {
        public readonly IConfiguration _configuration;

        public DbSet<Employee> EmployeeList { get; set; }
        public DbSet<Job> JobsList { get; set; }

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
            optionsBuilder.LogTo((message) => Debug.WriteLine(message));
        }
    }
}
