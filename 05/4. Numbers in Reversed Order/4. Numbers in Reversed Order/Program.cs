using System;
namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static double NumberReverser(double num) {

            char[] cArray = (Convert.ToString(num)).ToCharArray();
            string reverseString = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverseString += cArray[i];
            }
            return double.Parse(reverseString);
        }
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine(NumberReverser(num));
        }
    }
}
