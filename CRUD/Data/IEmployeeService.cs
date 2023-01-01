using System;
using System.Collections.Generic;
namespace CRUD.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        void UpdateEmployee(Employee employee);
    }
}
