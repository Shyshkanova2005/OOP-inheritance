using System.Reflection;

namespace Clases08._7
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private decimal Salary { get; set; }
        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public virtual void Work()
        {
            Console.WriteLine($"Імя: {Name}, посада : {Position}, зарплата {Salary}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, decimal salary)
            : base(name, "Manager", salary)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"{Name} керує командою.");
        }

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} ефективно керує командою.");
        }
    }

    class Engineer : Employee
    {
        public Engineer(string name, decimal salary)
            : base(name, "Engineer", salary)
        {

        }

        public override void Work()
        {
            Console.WriteLine($"{Name} пише код.");
        }
        public void WriteCode()
        {
            Console.WriteLine($"{Name} добре пише код.");
        }
    }

    class Intern : Employee
    {
        public Intern(string name, decimal salary)
            : base(name, "Intern", salary)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"{Name} допомагає з завданням.");
        }
        public void Assist()
        {
            Console.WriteLine($"{Name} допомагає команді.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
                new Manager("Катя", 80000),
                new Engineer("Боб", 9000),
                new Intern("Чарльз", 2000)
            };

            foreach (Employee employee in emp)
            {
                employee.Work();
            }
        }
    }
}
