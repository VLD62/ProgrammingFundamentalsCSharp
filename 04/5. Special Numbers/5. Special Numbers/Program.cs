namespace _5.Special_Numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            bool special = false;
          
            for (int i = 1; i <= number; i++) {
                int sumOfDigits = 0;
                for (int n = i; n > 0; sumOfDigits += n % 10, n /= 10) ;
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    special = true;

                }
                else {
                    special = false;
                }
                Console.WriteLine(i + " -> " + special);
            }
        }
    }
}
