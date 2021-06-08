using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; }
        public double WorkingHour { get; set; }

        public override void Display()
        {
            Console.WriteLine("Thong tin Hourly");
            base.Display();
            Console.WriteLine("Wage: " + Wage);
            Console.WriteLine("WorkingHour: " + WorkingHour);
        }

        public override double CalculateSalary()
        {
            return Wage * WorkingHour;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t| {Wage} \t|{WorkingHour}";
        }
    }
}
