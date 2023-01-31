using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.Models
{
    public class SQLRepository : IEmployeeRepository
    {
        private readonly AppDBContext _context;
        
        public SQLRepository(AppDBContext context)
        {
            this._context = context;
        }
        public Employee AddEmploye(Employee employee)
        {
            _context.Emplyees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _context.Emplyees.Find(id);
            if(employee !=null)
            {
                _context.Emplyees.Remove(employee);
                _context.SaveChanges();
            }          
            return employee;  
        }

        public Employee GetEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
