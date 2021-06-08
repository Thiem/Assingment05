using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public abstract class Employee
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //Phone
        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (Helper.CheckPhone(value))
                    phone = value;
                else
                    throw new ArgumentException("Phone is invalid format! (0123456)");
            }
        }

        //email
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (Helper.CheckEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email is invalid format!(abc@gmail.com)");
                }
            }
        }
        //Polymorphism - tính đa hình
        public virtual void Display()
        {
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("LastName: " + LastName);
            Console.WriteLine("Birth date: " + BirthDate);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Email: " + Email);
        }

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return $"{SSN} \t| {FirstName}\t|{LastName} \t|{BirthDate}\t|{Phone}\t|{Email}";
        }

    }

}
