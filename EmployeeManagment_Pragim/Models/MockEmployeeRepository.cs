using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary", Email="Mary@sample.com", Department = Department.HR },
                new Employee(){ Id = 2, Name = "John", Email = "John@sample.com", Department = Department.Payroll },
                new Employee(){ Id = 3, Name = "Sam", Email = "sam@sample.com", Department =Department.IT}
            };
           
        }

        
        public Employee AddEmploye(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id + 1);
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e=>e.Id==id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeList;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }

            return employee;
        }
    }
}
