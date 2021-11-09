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
            int[] array = new int[n];
            int posit = 0;
            int other = 0;
            List<int> posnum = new List<int>() { };
            List<int> negnum = new List<int>() { };
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент массива");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > 0)
                {
                    posit += 1;
                }
                else
                {
                    other += 1;
                }
            }
            int[] positive = new int[posit];
            int[] negative = new int[other];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    posnum.Add(array[i]);
                }
                else
                {
                    negnum.Add(array[i]);
                }
            }
            for (int i = 0; i < posit; i++)
            {
                positive[i] = posnum[i];
            }
            for (int i = 0; i < other; i++)
            {
                negative[i] = negnum[i];
            }
            Console.WriteLine();
            for (int i = 0; i < posit; i++)
            {
                Console.WriteLine($"{i+1} элемент положительного массива: " + positive[i].ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < other; i++)
            {
                Console.WriteLine($"{i+1} элемент массива с остальными числами: " + negative[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
