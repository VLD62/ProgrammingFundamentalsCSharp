namespace _3.A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IDictionary<string, int> resources = new Dictionary<string, int>();
            int counter = 1;
            while (input != "stop")
            {
                counter++;
                if (counter % 2 == 0)
                {
                    int value = int.Parse(Console.ReadLine());
                    if (resources.ContainsKey(input))
                    {
                        resources[input] += value;
                    }
                    else
                    {
                        resources.Add(input, value);
                    }
                }
                else
                {
                    if (counter > 1 ) { 
                    input = Console.ReadLine();
                        if (!resources.ContainsKey(input) && input != "stop")
                        {
                            resources.Add(input, 0);
                        }
                    }
                }
            }
            var list = resources.Keys.ToList();
            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item, resources[item]);
            }
        }
    }

}
