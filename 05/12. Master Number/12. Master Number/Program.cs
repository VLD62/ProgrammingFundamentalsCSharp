namespace _12.Master_Number
{
    using System;
    using System.Linq;
    class Program
    {
        static bool IsPalindrome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length / 2; i++)
            {
                if (sNum[i] != sNum[sNum.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckSumOfDigits(int num)
        {

            int digitSum = 0, r = 0;

            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                digitSum = digitSum + r;
            }

            if (digitSum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool ContainsEvenDigit(int num)
        {
            int[] digitArray = num.ToString().Select(o => Convert.ToInt32(o)).ToArray();
            bool check = false;
            for (int i = 0; i < digitArray.Length; i++)
            {
                if (digitArray[i] % 2 == 0)
                {
                    return true;
                }
            }
            return check;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && CheckSumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
