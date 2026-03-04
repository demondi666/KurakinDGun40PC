using System;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFiboncci();
            PrintMonths();
            PrintArray();
            PrintPolylineArray();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            var result = CopyArrays(array, array2, 3);

            ResizeArray(ref result);
        }

        private static void PrintFiboncci()
        {
            int[] fibonacci = new int[8];

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

        private static void PrintMonths()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (var month in months)
            {
                Console.Write(month + " ");
            }

            Console.WriteLine();
        }

        private static void PrintArray()
        {
            int[][] array = { new int[] { 2, 3, 4 }, new int[] { 2, 3, 4 }, new int[] { 2, 3, 4 }, };
            int[][] result = new int[array.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = new int[array[i].Length];

                for (int j = 0; j < array[i].Length; j++)
                {
                    result[i][j] = (int)(Math.Pow(array[i][j], (i+1)));
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintPolylineArray()
        {
            double[][] polylineArray = new double[3][];
            polylineArray[0] = new double[5];

            for (int i = 0; i < polylineArray[0].Length; i++)
            {
                polylineArray[0][i] = i + 1;
            }

            polylineArray[1] = new double[]{Math.E, Math.PI};

            polylineArray[2] = new double[4];

            for (int i = 0, j = 1; i < polylineArray[2].Length; i++, j = j * 10)
            {
                polylineArray[2][i] = Math.Log10(j);
            }

            foreach (double[] array in polylineArray)
            {
                foreach (double count in array)
                {
                    Console.Write(count+" ");
                }
                Console.WriteLine();
            }
        }

        private static int[] CopyArrays(int[] array1, int[] array2 , int length)
        {

            Array.Copy(array1, array2,length);

            foreach (var item in array2)
            {
                Console.Write(item+ " ");
            }

            Console.WriteLine();
            return array1;
        }

        private static void ResizeArray(ref int[] array)
        {
            Array.Resize(ref array, array.Length * 2);

            Console.WriteLine(array.Length);

        }
    }
}
