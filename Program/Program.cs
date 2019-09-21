using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Employee employee1;
            Employee employee2 = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();
            
            IncreaseSalary(employee2);

            employee1 = DataStorage.Load("Inigo", "Montoya");

//            employee1.FirstName = "Inigo";
//            employee1.LastName = "Montoya";
//            employee1.Salary = "Too Little";
//            employee1.SetName("Inigo", "Montoya");
//            IncreaseSalary(employee1);
//            Console.WriteLine("{0} {1}: {2}", employee1.FirstName, employee1.LastName, employee1.Salary);

            Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}