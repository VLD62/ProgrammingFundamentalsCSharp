namespace _7.Exchange_Variable_Values
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            int tmp = 0;
            Console.WriteLine("Before:");
            Console.WriteLine("a = " + num1);
            Console.WriteLine("b = " + num2);

            tmp = num1;
            num1 = num2;
            num2 = tmp;

            Console.WriteLine("After:");
            Console.WriteLine("a = " + num1);
            Console.WriteLine("b = " + num2);
        }
    }
}
