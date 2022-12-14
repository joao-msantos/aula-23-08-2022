using aula_23_08_2022.Models;

namespace aula_23_08_2022.Repositorio
{
    public static class EmployeeRepositorio
    {
        private static List<Employee> allEmployees = new List<Employee>();

        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployees; }
        }
        
        public static void Create(Employee employee)
        {
            allEmployees.Add(employee);
        }

        public static void Delete(Employee employee)
        {
            allEmployees.Remove(employee);
        }
    }
}
