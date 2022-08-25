using aula_23_08_2022.Models;

namespace aula_23_08_2022.Repositorio
{
    public static class EmployeeRepositorio
    {
        private static List<Employee> allEmployees = new List<Employee>();

        private static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployees; }
        }
        
        public static void Create(Employee employee)
        {
            allEmployees.Add(employee);
        }
    }
}
