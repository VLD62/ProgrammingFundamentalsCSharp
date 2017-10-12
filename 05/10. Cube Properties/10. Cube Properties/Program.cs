namespace _10.Cube_Properties
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;
            switch (parameter) {

                  case "face":
                    result = Math.Sqrt(2 * (side * side));
                    break;

                case "space":
                    result = Math.Sqrt(3 * (side * side));
                    break;

                case "volume":
                    result = side * side * side;
                    break;

                case "area":
                    result = 6 * (side * side);
                    break;

            }
            Console.WriteLine("{0:0.00}",Math.Round(result, 2));
        }
    }
}
