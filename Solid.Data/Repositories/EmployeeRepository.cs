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
            return await _dataEmployee.EmployeeList.Include(e => e.JobList).Where(e => e.Status).ToListAsync();
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
            employee.Id = id;

            _dataEmployee.Entry(existEmployee).CurrentValues.SetValues(employee);
            _dataEmployee.Entry(existEmployee).Collection(e => e.JobList).CurrentValue = employee.JobList;

            await _dataEmployee.SaveChangesAsync();
            return existEmployee;
        }

        public async Task RemoveAsync(int id)
        {
            Employee temp = await _dataEmployee.EmployeeList.FindAsync(id);
            Console.WriteLine(temp.FirstName);
            Console.WriteLine(temp.Status);
            if (temp == null)
                return;
            temp.Status = false;
            Console.WriteLine(temp.Status);
            await _dataEmployee.SaveChangesAsync();
        }

        public Employee GetByEmployeeNameAndPassword(string employeeFirstName, string employeeLastName, string employeePassword)
        {
            return _dataEmployee.EmployeeList.FirstOrDefault(e => e.FirstName == employeeFirstName && e.LastName == employeeLastName && e.Password == employeePassword);
        }

       
    }
}
