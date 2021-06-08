using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
   public class EmployeeManagement
    {
        private readonly List<Employee> employees;

        public EmployeeManagement()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DisplayInformation()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        public void SearchEmployeeByName(string name)
        {
            foreach (var employee in employees)
            {
                if (employee.FirstName.ToLower().Contains(name.ToLower()))
                {
                    employee.Display();
                    Console.WriteLine("----------------------------");
                }
            }
        }
    }
}
