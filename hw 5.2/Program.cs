using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минимальное значение массива: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение массива: ");
            int max = Convert.ToInt32(Console.ReadLine());

            double[] showArr = CreateArr(size, min, max);
            ShowArray(showArr);

            Console.WriteLine(SumNum(showArr));
            Console.ReadKey();
        }
        static double[] CreateArr(int size, int min, int max)
        {
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
                array[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);
            return array;
        }
        static double SumNum(double[] array)
        {
            double total = 0;
            for (int j = 1; j < array.Length; j += 2)
                total += array[j];
            return Math.Round(total, 2);
        }
        static void ShowArray(double[] array)
        {
            for (int l = 0; l < array.Length; l++)
                Console.Write(array[l] + " ");
            Console.WriteLine();
        }
    }
}
