using MacorattiCleanArchtecture.Application.Interfaces.Employee;
using MacorattiCleanArchtecture.Application.Service.Employee;
using Microsoft.AspNetCore.Mvc;

namespace MacorattiCleanArchtecture.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService employeeService)
        {
            service = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await service.SelectAllAsync();

            return View(employees);
        }
    }
}
