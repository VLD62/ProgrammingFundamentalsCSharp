namespace _18.Different_Integers_Size
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var M = Console.ReadLine();

            try

            {
                long N = long.Parse(M);
                Console.WriteLine(N + " can fit in:");

                if (-128 <= N && N <= 127)
                {
                    Console.WriteLine("* sbyte");
                }

                if (0 <= N && N <= 255)
                {
                    Console.WriteLine("* byte");
                }

                if (-32768 <= N && N <= 32767)
                {
                    Console.WriteLine("* short");
                }

                if (0 <= N && N <= 65535)
                {
                    Console.WriteLine("* ushort");
                }

                if (-2147483648 <= N && N <= 2147483647)
                {
                    Console.WriteLine("* int");
                }

                if (0 <= N && N <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }

                if (-9223372036854775808 <= N && N <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }
            catch
            {

                Console.WriteLine(M + " can't fit in any type");
            }

        }
    }
}
