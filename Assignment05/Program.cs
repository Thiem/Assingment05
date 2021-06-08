using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {
       static void Main(string[] args)
        {
            InputHourlyEmployee();
            InputSalariedEmployee();

            Console.WriteLine("Display employee list:");
            management.DisplayInformation();
            Console.ReadKey();
        }
        static EmployeeManagement management = new EmployeeManagement();
        static void InputHourlyEmployee()
        {
            Console.Write("Input Snn: ");
            string ssn = Console.ReadLine();

            Console.Write("Input firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Input lastname: ");
            string lastname = Console.ReadLine();

            DateTime birthDate;
            do
            {
                Console.Write("Input birth date: (mm/dd/yyy)");
            } while (!DateTime.TryParse(Console.ReadLine(), out birthDate));

            string phone = string.Empty;
            do
            {

                Console.WriteLine("Input phone (mininum 7 digits): ");
                phone = Console.ReadLine();
            } while (!Helper.CheckPhone(phone));

            string email = string.Empty;
            do
            {
                Console.WriteLine("Input email: ");
                email = Console.ReadLine();
            } while (!Helper.CheckEmail(email));

            double wage;
            do
            {
                Console.Write("Input wage: ");
            } while (!double.TryParse(Console.ReadLine(), out wage));

            double workingHour;
            do
            {
                Console.Write("Input workinghour: ");
            } while (!double.TryParse(Console.ReadLine(), out workingHour));

            management.AddEmployee(new HourlyEmployee()
            {
                SSN = ssn,
                FirstName = firstName,
                LastName = lastname,
                BirthDate = birthDate,
                Phone = phone,
                Email = email,
                Wage = wage,
                WorkingHour = workingHour
            });
        }


        static void InputSalariedEmployee()
        {
            Console.Write("Input Snn: ");
            string ssn = Console.ReadLine();

            Console.Write("Input firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Input lastname: ");
            string lastname = Console.ReadLine();

            DateTime birthDate;
            do
            {
                Console.Write("Input birth date: (mm/dd/yyy)");
            } while (!DateTime.TryParse(Console.ReadLine(), out birthDate));

            string phone = string.Empty;
            do
            {

                Console.WriteLine("Input phone (mininum 7 digits): ");
                phone = Console.ReadLine();
            } while (!Helper.CheckPhone(phone));

            string email = string.Empty;
            do
            {
                Console.WriteLine("Input email: ");
                email = Console.ReadLine();
            } while (!Helper.CheckEmail(email));

            double commissionRate;
            do
            {
                Console.WriteLine("Input commissionRate: ");
            } while (!double.TryParse(Console.ReadLine(), out commissionRate));

            double grossSales;
            do
            {
                Console.WriteLine("Input grossSales: ");
            } while (!double.TryParse(Console.ReadLine(), out grossSales));

            double basicSalary;
            do
            {
                Console.WriteLine("Input basicSalary: ");
            } while (!double.TryParse(Console.ReadLine(), out basicSalary));

            management.AddEmployee(new SalariedEmployee()
            {
                SSN = ssn,
                FirstName = firstName,
                LastName = lastname,
                BirthDate = birthDate,
                Phone = phone,
                Email = email,
                CommissionRate = commissionRate,
                GrossSales = grossSales,
                BasicSalary = basicSalary
            });
        }
    }
}
