namespace Problem_3.Employee_Data
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {

            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var salary = Double.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Employee ID: {0:D8}", employeeID);
            Console.WriteLine("Salary: {0:0.00}", salary);
            
        }
    }
}
