using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id=Guid.NewGuid(),
                Name = "Employee 1"
            },
            new Employee
            {
                Id=Guid.NewGuid(),
                Name = "Employee 2"
            }
        };

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var getOldEmployee = GetEmployee(employee.Id);
            getOldEmployee.Name = employee.Name;
        }
    }
}
