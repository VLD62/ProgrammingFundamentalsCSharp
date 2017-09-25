namespace Problem_10.Triangle_of_Numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i);
               // Console.Write(i+1);  
                for (int j  = 1; j <= i; j++)
                {
                   Console.Write(i+1);
                }
                
            }
        }
    }
}
