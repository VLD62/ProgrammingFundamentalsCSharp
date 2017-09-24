namespace _05.Character_Stats
{
    using System;
    class Startup
    {
  
        static void Main(string[] args)
        {

            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());
            
            var overalHealth = new string('|', currentHealth) +  new string('.', maximumHealth - currentHealth);
            var overalEnergy = new string('|', currentEnergy) +  new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: |" + overalHealth + "|");
            Console.WriteLine("Energy: |" + overalEnergy + "|");


        }
    }
}
