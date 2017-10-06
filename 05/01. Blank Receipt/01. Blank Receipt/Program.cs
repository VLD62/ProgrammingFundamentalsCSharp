namespace _1.Blank_Receipt
{
    using System;
    class Program
    {

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }


        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }



        static void PrintFotter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void PrintReciept()
        {
            PrintHeader();
            PrintBody();
            PrintFotter();
        }

        static void Main(string[] args)
        {
            PrintReciept();
        }
    }
}
