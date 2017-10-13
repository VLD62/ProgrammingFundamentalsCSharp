using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comm = Console.ReadLine();

            while (!(comm.Equals("print")))
            {
                var command = comm.Split();

                if (command[0].Equals("add"))
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);

                    nums.Insert(index, element);
                }

                if (command[0].Equals("addMany"))
                {
                    int index = int.Parse(command[1]);
                    for (int i = 2; i < command.Length; i++)
                    {
                        nums.Insert(index, int.Parse(command[i]));
                        index++;
                    }
                }

                if (command[0].Equals("contains"))
                {
                    int index = nums.IndexOf(int.Parse(command[1]));
                    Console.WriteLine(index);
                }

                if (command[0].Equals("remove"))
                {
                    nums.RemoveAt(int.Parse(command[1]));
                }


                if (command[0].Equals("shift"))
                {
                    int positionsToMove = int.Parse(command[1]);
                    for (int j = 0; j < positionsToMove; j++)
                    {
                        int firstElement = nums[0];
                        for (int i = 1; i < nums.Count; i++)
                        {
                            nums[i - 1] = nums[i];
                        }
                        nums[nums.Count - 1] = firstElement;
                    }
                }

                if (command[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < nums.Count - 1; i += 2)
                    {
                        nums[i] += nums[i + 1];
                        nums[i + 1] = -1;
                    }
                    nums.RemoveAll(x => x == -1);
                }
                comm = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

    }
}
