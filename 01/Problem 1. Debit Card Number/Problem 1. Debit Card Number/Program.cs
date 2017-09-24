namespace Problem_1.Debit_Card_Number
{
    using System;
    public class Startup
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}");
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstNum, secondNum, thirdNum, fourthNum) ;
        }
    }
}
