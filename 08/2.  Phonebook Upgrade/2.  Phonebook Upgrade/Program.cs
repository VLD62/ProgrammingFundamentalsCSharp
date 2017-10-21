namespace _2.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            IDictionary<string, string> phoneBookDictionary = new Dictionary<string, string>();
            while (info[0] != "END") 
            {
                if (info[0] == "A")
                {
                    if (phoneBookDictionary.ContainsKey(info[1]))
                    {
                        phoneBookDictionary.Remove(info[1]);
                    }
                    phoneBookDictionary.Add(info[1], info[2]);
                }
                else
                {
                    if (info[0] == "ListAll")
                    {   // Acquire keys and sort  
                        var list = phoneBookDictionary.Keys.ToList();
                        list.Sort();
                        // For Display the sorted List  
                        foreach (var item in list)
                        {
                            Console.WriteLine("{0} -> {1}", item, phoneBookDictionary[item]);
                        }
                    }
                    else { 
                        if (phoneBookDictionary.ContainsKey(info[1]))
                        {
                            Console.WriteLine("{0} -> {1}", info[1], phoneBookDictionary[info[1]]);
                        }
                        else if (info[0] == "S")
                        {
                            Console.WriteLine("Contact {0} does not exist.", info[1]);
                        }
                    }
                }
                info = Console.ReadLine().Split();
            }
        }
    }
}
