using System;
using System.Collections.Generic;

namespace clases08._6
{
    abstract class Employee
    {
        public abstract double CalculateSalary();
        public abstract string GetRole();

        public void DisplayInfo()
        {
            Console.WriteLine($"Зарплата: {CalculateSalary()}");
            Console.WriteLine($"Посада: {GetRole()}");
        }

    }

    class FullTimeEmployee : Employee
    {
        public double MonthSalary { get; set; }

        public override double CalculateSalary()
        {
            return MonthSalary;
        }

        public override string GetRole()
        {
            return "Full-time";
        }
    }

    class PartTimeEmployee : Employee
    {
        public int HourRate { get; set; }
        public int HoursWork { get; set; }

        public override double CalculateSalary()
        {
            return HourRate * HoursWork;
        }

        public override string GetRole()
        {
            return "Part-time";
        }
    }

    class Contractor : Employee
    {
        public int Fixedsalary { get; set; }

        public override double CalculateSalary()
        {
            return Fixedsalary;
        }

        public override string GetRole()
        {
            return "Contractor";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee { MonthSalary = 100 });
            employees.Add(new PartTimeEmployee { HourRate = 100, HoursWork = 24 });
            employees.Add(new Contractor { Fixedsalary = 100 });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.CalculateSalary());
                employee.DisplayInfo();
            }

        }
    }
}
