using System;


namespace _3.English_Name_оf_the_Last_Digit
{
    class Program
    {

        static string DigitNameExtractor(long num)
        {

            long lastdigit = (num % 10);
            string digitName = "";
            switch (lastdigit)
            {

                case 0:
                    digitName = "zero";
                    break;
                case 1:
                    digitName = "one";
                    break;
                case 2:
                    digitName = "two";
                    break;
                case 3:
                    digitName = "three";
                    break;
                case 4:
                    digitName = "four";
                    break;
                case 5:
                    digitName = "five";
                    break;
                case 6:
                    digitName = "six";
                    break;
                case 7:
                    digitName = "seven";
                    break;
                case 8:
                    digitName = "eight";
                    break;
                case 9:
                    digitName = "nine";
                    break;
                default:
                    break;
            }
            return digitName;
        }
        static void Main(string[] args)
        {
            var num = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(DigitNameExtractor(num));
        }
    }
}
