namespace _02.Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            string comm = Console.ReadLine();

            while (!(comm.Equals("Odd") || comm.Equals("Even")))
            {
                var command = comm.Split();

                if (command[0].Equals("Delete"))
                {

                    double value = double.Parse(command[1]);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == value)
                        {
                            nums.RemoveAt(i);
                            i--;
                        }
                    }
                }

                if (command[0].Equals("Insert"))
                {
                    int element = int.Parse(command[1]);
                    int pos2 = int.Parse(command[2]);

                    nums.Insert(pos2, element);
                }


                comm = Console.ReadLine();

            }

            if (comm.Equals("Odd"))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 != 0)
                    {

                        Console.Write(nums[i] + " ");
                    }
                }
            }

            if (comm.Equals("Even"))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {

                        Console.Write(nums[i] + " ");
                    }
                }

            }

        }
    }
}
