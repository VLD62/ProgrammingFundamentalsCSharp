namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IDictionary<string, string> resources = new Dictionary<string, string>();
            int counter = 1;
            while (input != "stop")
            {
                counter++;
                if (counter % 2 == 0)
                {
                    string email = (Console.ReadLine());
                    if (resources.ContainsKey(input))
                    {
                        resources[input] += email;
                    }
                    else
                    {
                        resources.Add(input, email);
                    }
                }
                else
                {
                    if (counter > 1)
                    {
                        input = Console.ReadLine();
                        if (!resources.ContainsKey(input) && input != "stop")
                        {
                            resources.Add(input, null);
                        }
                    }
                }
                
            }
            var list = resources.Keys.ToList();
            foreach (var item in list)
            {
                if (!resources[item].Substring(resources[item].Length - 2).Equals("us") && !resources[item].Substring(resources[item].Length - 2).Equals("uk"))
                {
                    Console.WriteLine("{0} -> {1}", item, resources[item]);
                }
                    
            }
        }
    }
}
