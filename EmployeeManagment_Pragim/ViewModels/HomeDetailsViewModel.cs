using EmployeeManagment_Pragim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employee employee { get; set; }
        public string PageTitle { get; set; }
    }
}
