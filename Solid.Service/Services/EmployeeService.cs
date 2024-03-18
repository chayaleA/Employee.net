using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
namespace Solid.Service.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<Employee> AddAsync(Employee employee)
        {

            return await _employeeRepository.AddAsync(employee);
        }

        public async Task<Employee> UpdateAsync(int id, Employee employee)
        {
            return await _employeeRepository.UpdateAsync(id, employee);
        }


        public async Task RemoveAsync(int id)
        {
            _employeeRepository.RemoveAsync(id);
        }

        public Employee GetByEmployeeNameAndPassword(string employeeFirstName, string employeeLastName, string employeePassword)
        {
            return _employeeRepository.GetByEmployeeNameAndPassword(employeeFirstName, employeeLastName, employeePassword);
        }
    }
}
