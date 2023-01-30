using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TempEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus : {1}",
                empJohn.ToString(),
                empJohn.CalculateBonas(1000).ToString()));            

            Console.WriteLine(string.Format("Employee {0} Bonus : {1}",
                empJason.ToString(),
                empJason.CalculateBonas(1000).ToString()));
            Console.ReadLine();
        }
    }
}
