namespace _14.Integer_to_Hex_and_Binary
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int remainder = 0;
            string binary = "";
            Console.WriteLine(num.ToString("X"));
            while (num > 0) {

                remainder = num % 2;
                num /= 2;
                binary = remainder + binary;

            }
            Console.WriteLine(binary);
        }
    }
}
