namespace _5.Compare_Char_Arrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] wordArray1 = Console.ReadLine().ToLower().Replace(" ", "").ToCharArray();
            char[] wordArray2 = Console.ReadLine().ToLower().Replace(" ", "").ToCharArray();


            if (wordArray1[0] == wordArray2[0])
            {
                if (wordArray1.Length > wordArray2.Length)
                {
                    for (int i = 0; i < wordArray2.Length; i++)
                    {
                        if (wordArray1[i] < wordArray2[i])
                        {
                            for (int j = 0; j < wordArray2.Length; j++)
                            {

                                Console.Write(wordArray1[j]);

                            }
                            Console.WriteLine();
                            for (int j = 0; j < wordArray2.Length; j++)
                            {

                                Console.Write(wordArray2[j]);

                            }

                            break;
                        }
                        else
                        {
                            for (int j = 0; j < wordArray2.Length; j++)
                            {

                                Console.Write(wordArray2[j]);

                            }
                            Console.WriteLine();
                            for (int j = 0; j < wordArray1.Length; j++)
                            {

                                Console.Write(wordArray1[j]);

                            }

                            break;

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < wordArray1.Length; i++)
                    {
                        if (wordArray1[i] < wordArray2[i])
                        {
                            for (int j = 0; j < wordArray2.Length; j++)
                            {

                                Console.Write(wordArray2[j]);

                            }
                            Console.WriteLine();
                            for (int j = 0; j < wordArray1.Length; j++)
                            {

                                Console.Write(wordArray1[j]);

                            }

                            break;
                        }
                        else
                        {
                            for (int j = 0; j < wordArray1.Length; j++)
                            {

                                Console.Write(wordArray1[j]);

                            }
                            Console.WriteLine();
                            for (int j = 0; j < wordArray2.Length; j++)
                            {

                                Console.Write(wordArray2[j]);

                            }

                            break;

                        }
                    }

                }


            }
            else
            {
                if (wordArray1[0] < wordArray2[0])
                {
                    for (int i = 0; i < wordArray1.Length; i++)
                    {

                        Console.Write(wordArray1[i]);

                    }
                    Console.WriteLine();
                    for (int i = 0; i < wordArray1.Length; i++)
                    {

                        Console.Write(wordArray2[i]);

                    }

                }
                else
                {
                    for (int i = 0; i < wordArray2.Length; i++)
                    {
                        Console.Write(wordArray2[i]);

                    }
                    Console.WriteLine();
                    for (int i = 0; i < wordArray1.Length; i++)
                    {
                        Console.Write(wordArray1[i]);

                    }


                }


            }
        }
    }
}
