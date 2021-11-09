using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 15)
                {
                    array[i] = array[i] * 2;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} элемент массива: " + array[i].ToString());
            }
        }
    }
}