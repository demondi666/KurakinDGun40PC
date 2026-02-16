using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");

            if (!int.TryParse(Console.ReadLine(), out int number1)){
                Console.WriteLine("Not a number");
                return;
            }

            Console.Write("Введите второе число: ");

            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Not a number");
                return;
            }

            Console.Write("Введите символ: ");

            string symbol = Console.ReadLine();

            int result = 0;

            switch (symbol) {
                case "&": result = number1 & number2;
                    GetResult(result);
                    return;
                case "|":
                    result = number1 | number2;
                    GetResult(result);
                    return;
                case "^": 
                    result = number1 ^ number2;
                    GetResult(result);
                    return;
                default:
                    Console.WriteLine("Not a symbol");
                    return;
            }
        }

        private static void GetResult(int result)
        {
            Console.WriteLine("Десятичная: " + Convert.ToString(result, 10));
            Console.WriteLine("Двоичная: " + Convert.ToString(result, 2));
            Console.WriteLine("Шестнадцатеричная: " + Convert.ToString(result, 16));
        }
    }
}
