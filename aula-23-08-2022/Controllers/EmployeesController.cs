using aula_23_08_2022.Models;
using Microsoft.AspNetCore.Mvc;
using aula_23_08_2022.Repositorio;

namespace aula_23_08_2022.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View(EmployeeRepositorio.AllEmployees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeRepositorio.Create(employee);

            return View("Thanks", employee);
        }

        public IActionResult Update(string empname)
        {
            Employee employee = EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = EmployeeRepositorio.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            EmployeeRepositorio.Delete(employee);
            return RedirectToAction("Index");
        }
    }



}

