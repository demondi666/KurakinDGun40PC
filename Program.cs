using System;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFiboncci();
            PrintEvenNumbers();
            PrintMultiplacationTable();
            GetPassword();
        }

        private static void PrintFiboncci()
        {
            int[] fibonacci = new int[10];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            foreach (var count in fibonacci)
            {
                Console.Write(count + " ");
            }

            Console.WriteLine();
        }

        private static void PrintEvenNumbers()
        {

            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintMultiplacationTable()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i*j +" ");
                }
                Console.WriteLine();
            }
        }

        private static void GetPassword()
        {
            string password = "qwerty";
            string line;
            int i = 0;
            int result;

            do
            {
                Console.Write("Enter password:");
                line = Console.ReadLine();

                result = string.Compare(line, password);

                if (result != 0)
                {
                    Console.WriteLine("Incorrect Password!");
                }

                i++;
            }
            while (result!=0);
            Console.WriteLine("Correct Password!");
        }
    }
}
