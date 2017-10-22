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
                    counter++;
                    if (input != "stop")
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
                }

            }
            var list = resources.Keys.ToList();

            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                foreach (var item in list)
                {
                    outputFile.WriteLine("{0} -> {1}", item, resources[item]);
                }

            }
        }
    }
}


