using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
   public class SalariedEmployee : Employee
    {
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        public override double CalculateSalary()
        {
            return (CommissionRate * BasicSalary) + GrossSales;
        }

        public override void Display()
        {
            Console.WriteLine("Thoong tin nhanh salary");
            base.Display();
            Console.WriteLine("CommissionRate: " + CommissionRate);
            Console.WriteLine("GrossSales: " + GrossSales);
            Console.WriteLine("BasicSalary: " + BasicSalary);
        }

        public override string ToString()
        {
            return base.ToString() + $"\t|{CommissionRate}\t|{GrossSales}\t|{BasicSalary}\t| {CalculateSalary()}";

        }
    }
}
