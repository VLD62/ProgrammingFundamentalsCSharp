namespace _06.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    class Program
    {

        static void Main(string[] args)
        {

            string input;
            int counter = 1;
            IDictionary<string, string> emails = new Dictionary<string, string>();
            using (var fileStream = File.OpenRead("Input.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {

                while ((input = streamReader.ReadLine()) != null) {

                    counter++;
                    if (input != "stop")
                    {
                            
                            string email = (streamReader.ReadLine());
                            if (emails.ContainsKey(input))
                            {
                                emails[input] += email;
                            }
                            else
                            {
                                emails.Add(input, email);
                            }
                    }
                }
            }
            var list = emails.Keys.ToList();

            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                foreach (var item in list)
                {
                    if (!emails[item].Substring(emails[item].Length - 2).Equals("us") && !emails[item].Substring(emails[item].Length - 2).Equals("uk"))
                    {
                        outputFile.WriteLine("{0} -> {1}", item, emails[item]);
                    }
                }
            }
        }
    }
}
