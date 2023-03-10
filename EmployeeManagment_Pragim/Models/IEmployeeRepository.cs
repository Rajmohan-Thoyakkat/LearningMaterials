using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetEmployees();
        Employee AddEmploye(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int id);

    }
}
