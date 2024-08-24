using System;

namespace Samples.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Martin Marquez";
            employee.Salary = 300.49d;
            employee.BirthDate = DateTime.Parse("2011-11-04");

            Manager manager = new Manager();
            manager.Name = "Katharina Marquez";
            manager.Salary = 14000.89;
            manager.Departament = "Sales";
            

            Console.WriteLine("[ Employee details ]");
            Console.WriteLine("========================");
            Console.WriteLine(employee.GetDetails());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("[ Manager details ]");
            Console.WriteLine("========================");
            Console.WriteLine(manager.GetDetails());


        }
    }
}
