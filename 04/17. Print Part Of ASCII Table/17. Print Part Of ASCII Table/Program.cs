namespace _17.Print_Part_Of_ASCII_Table
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++) {
                Console.Write(Convert.ToChar(i)+ " ");
            }
        }
    }
}
