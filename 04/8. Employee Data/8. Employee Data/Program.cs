namespace _8.Employee_Data
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            var gender = Convert.ToChar(Console.ReadLine());
            var personalId = double.Parse(Console.ReadLine());
            var uniqueEmployeeNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + personalId);
            Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);

        }
    }
}
