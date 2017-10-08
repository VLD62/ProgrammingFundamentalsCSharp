namespace _04.Sieve_of_Eratosthenes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            arr[1] = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    for (int a = 2; (a * i) <= n; a++)
                    {
                        arr[a * i] = false;
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (arr[j] == true)
                { Console.Write(j + " "); }
            }
            Console.WriteLine();



        }
    }
}
