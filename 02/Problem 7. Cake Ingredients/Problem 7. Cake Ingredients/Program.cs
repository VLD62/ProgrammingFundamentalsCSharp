


namespace Problem_7.Cake_Ingredients
{
    using System;
    class Program
    {

        static void Main(string[] args)
        {
            string ingredient = "ofca";
            int counter = 0;
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    counter++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
               
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
