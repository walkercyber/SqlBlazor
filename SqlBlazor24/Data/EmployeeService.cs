
using Microsoft.EntityFrameworkCore;
using SqlBlazor24.Models;

namespace SqlBlazor24.Data
{
    public class EmployeeService
    {
        private readonly EmployeeDbContext _Context;

        public EmployeeService(EmployeeDbContext context)
        {
            _Context = context;
        }

        public async Task AddEmployee(Employee employee)
        {
            _Context.Employees.Add(employee);
            await _Context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _Context.Employees.ToListAsync();
        }
    }
}
