using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _dataEmployee;

        public EmployeeRepository(DataContext dataEmployee)
        {
            _dataEmployee = dataEmployee;
        }

        public async Task<List<Employee>> GetListAsync()
        {
            return await _dataEmployee.EmployeeList.Include(e => e.JobList).ToListAsync();
        }
        public async Task<Employee> GetById(int id)
        {
            return await _dataEmployee.EmployeeList.Include(e => e.JobList).FirstAsync(e => e.Id == id);
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            _dataEmployee.EmployeeList.AddAsync(employee);
            await _dataEmployee.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateAsync(int id, Employee employee)
        {
            var existEmployee = await GetById(id);
            _dataEmployee.Entry(existEmployee).CurrentValues.SetValues(employee);
            await _dataEmployee.SaveChangesAsync();
            return existEmployee;
        }
       
        public async Task RemoveAsync(int id)
        {
            Employee temp = _dataEmployee.EmployeeList.Find(id);
            if (temp == null)
                return;
            temp.Status = false;
            await _dataEmployee.SaveChangesAsync();
        }

        public Employee GetByEmployeeNameAndPassword(string employeeFirstName, string employeeLastName, string employeePassword)
        {
            return _dataEmployee.EmployeeList.FirstOrDefault(e => e.FirstName == employeeFirstName && e.LastName == employeeLastName && e.Password == employeePassword);
        }

       
    }
}
