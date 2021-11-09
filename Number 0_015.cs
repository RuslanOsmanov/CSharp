using System;
using System.Collections.Generic;
namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] D = new int[n];
            int sumi = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент массива");
                D[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i += 2)
            {
                sumi += D[i];
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} элемент массива: " + D[i].ToString());
            }
            Console.WriteLine("Сумма элементов с нечетными индексами: " + sumi.ToString());
        }
    }
}