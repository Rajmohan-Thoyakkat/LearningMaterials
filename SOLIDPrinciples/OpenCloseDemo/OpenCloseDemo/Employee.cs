using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseDemo
{
    //public class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string EmployeeType { get; set; }

    //    public Employee()
    //    {
    //    }

    //    public Employee(int id , string name, string employeeType)
    //    {
    //        this.Id = id;
    //        this.Name = name;
    //        this.EmployeeType = employeeType;
    //    }

    //    public decimal CalculateBonas(decimal salary)
    //    {
    //        if (EmployeeType == "Permenant")
    //            return salary * 3;
    //        else
    //            return salary * 2;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("ID : {0} Name : {1}", this.Id, this.Name);
    //    }

    //}

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }      

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;           
        }

        public abstract decimal CalculateBonas(decimal salary);
       

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.Id, this.Name);
        }

    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
        }

        public PermanentEmployee(int id, string name):base(id,name)
        {
            
        }
        public override decimal CalculateBonas(decimal salary)
        {
            return salary * 3;
        }
    }

    public class TempEmployee : Employee
    {
        public TempEmployee()
        {
        }

        public TempEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonas(decimal salary)
        {
            return salary * 2;
        }
    }
}
