using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllAsync();

        Task<Employee> GetById(int id);

        Task<Employee> AddAsync(Employee employee);

        Task<Employee> UpdateAsync(int id, Employee employee);
        Task RemoveAsync(int id);

        public Employee GetByEmployeeNameAndPassword(string employeeFirstName, string employeeLastName, string employeePassword);
    }
}
