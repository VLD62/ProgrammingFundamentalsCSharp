namespace _04.Max_Sequence_of_Equal_Elements
{
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText("Input.txt");

            int[] arr1 = contents.Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int bestCount = 0;
            int bestIndex = 0;
            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                for (int i = 1; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr1[i - 1])
                    {
                        count++;

                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestIndex = i - count + 1;
                    }
                }
                for (int i = bestIndex; i < bestIndex + bestCount; i++)
                {
                    outputFile.Write(arr1[i] + " ");
                }
            }
        }
    }
}
