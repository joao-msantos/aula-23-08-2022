using aula_23_08_2022.Models;
using Microsoft.AspNetCore.Mvc;
using aula_23_08_2022.Repositorio;

namespace aula_23_08_2022.Controllers
{
    public class Employees : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repositorio.Create(employee);

            return View("Thanks", employee);
        }
        
    }
}
