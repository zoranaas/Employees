using Demo.Controllers.Repository;
using Demo.Controllers.Repository.IRepository;
using Demo.Models;
using LiveCharts.WinForms;
using Microsoft.AspNetCore.Mvc;
using LiveCharts;
using System;


namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employee;

        public EmployeeController()
        {
            _employee = new EmployeeService();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await _employee.GetEmployees();
           
            var grouped = employees.GroupBy(obj => obj.EmployeeName)
                                   .Select(group =>
                                   {
                                       double totalHours = group.Sum(obj => (obj.EndTimeUtc - obj.StarTimeUtc).TotalHours);
                                       return new Employee
                                       {
                                           EmployeeName = group.Key,
                                           TotalTimeWorked = totalHours,

                                       };
                                   }).ToList();
            return View(grouped);
        }

      
    }
}
