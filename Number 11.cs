using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int maxi = -1000000000;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i+1}-й элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = n-1; i >= 0; i--)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
                Console.Write($"{i+1}-й элемент массива: ");
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массива: " + maxi.ToString());
        }
    }
}
