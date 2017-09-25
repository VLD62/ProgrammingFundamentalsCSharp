

namespace Problem_8.Calories_Counter
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string ingredient = "Balon";
            int totalCalories = 0;

            for (int i = 0; i < n; i++) {

                ingredient = Console.ReadLine().ToLower();

                switch (ingredient) {
                    case "cheese":
                        totalCalories = totalCalories + 500;
                        break;
                    case "tomato sauce":
                        totalCalories = totalCalories + 150;
                        break;
                    case "salami":
                        totalCalories = totalCalories + 600;
                        break;
                    case "pepper":
                        totalCalories = totalCalories + 50;
                        break;
                }

               
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
