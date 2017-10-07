namespace _05.Rounding_Numbers
{
    using System;
    using System.Linq;
    class Program
    {

        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] arr2 = arr;
      
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i],
                arr2[i] = Math.Round(arr2[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
