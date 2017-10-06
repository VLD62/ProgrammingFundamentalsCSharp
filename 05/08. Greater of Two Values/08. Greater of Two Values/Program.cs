namespace _8.Greater_of_Two_Values
{
    using System;
    class Program
    {


        static int GetMax(int value1, int value2)
        {

            if (value1 >= value2)
            {

                return value1;
            }
            else
            {
                return value2;
            }
        }

        static char GetMax(char value1, char value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        static string GetMax(string value1, string value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        static void Main(string[] args)
        {

            var type = Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();

            if (type == "string")
            {
                Console.WriteLine(GetMax(value1, value2));
            }
            else if (type == "char")
            {

                Console.WriteLine(GetMax(char.Parse(value1), char.Parse(value2)));
            }
            else if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(value1), int.Parse(value2)));
            }


        }

    }
}
