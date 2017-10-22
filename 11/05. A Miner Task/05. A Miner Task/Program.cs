using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
          
            int counter = 1;
            IDictionary<string, int> resources = new Dictionary<string, int>();
            using (var fileStream = File.OpenRead("Input.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {

                while ((input = streamReader.ReadLine()) != null)
                {
                    //input = streamReader.ReadLine();
                    //Console.WriteLine(input);
      
                    if (input != "stop")
                    {
                        counter++;
                        if (counter % 2 == 0)
                        {
                            int value = int.Parse(streamReader.ReadLine());
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
                            if (counter > 1)
                            {
                                input = streamReader.ReadLine();
                                if (!resources.ContainsKey(input) && input != "stop")
                                {
                                    resources.Add(input, 0);
                                }
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
}

