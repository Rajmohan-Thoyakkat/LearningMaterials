using EmployeeManagment_Pragim.Models;
using EmployeeManagment_Pragim.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment_Pragim.controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            IEnumerable<Employee>  employeeList = _employeeRepository.GetEmployees();
            return View(employeeList);
        }

        public ViewResult Details(int id)
        {
            //Employee model = _employeeRepository.GetEmployee(1);
            //ViewData["PageTitle"] = "Employee Details";           
            //return View(model);

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Empoyee Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.AddEmploye(employee);
                return RedirectToAction("Details", new { newEmployee.Id });
            }
            return View();

        }
    }
}
