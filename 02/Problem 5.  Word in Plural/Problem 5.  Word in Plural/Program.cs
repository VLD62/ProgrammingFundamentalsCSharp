namespace Problem_5.Word_in_Plural
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            int flag = 0;

            string[] arr1 = new string[]
            {
            "o",
            "ch",
            "s",
            "sh",
            "x",
            "z"
            };

            // Loop through and test each string.
            foreach (string str in arr1)
            {
                if (word.EndsWith(str))
                {
                    flag = 1;
                    Console.WriteLine(word + "es");
                    return;
                    
                }
            }

            if (word.EndsWith("y"))
            {
                flag = 1;
                Console.WriteLine(word.Remove(word.Length - 1) + "ies");
                
            }

            if (flag == 0) {
                Console.WriteLine(word + "s");
            }

        }
    }
}
