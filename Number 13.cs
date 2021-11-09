using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int [n];
            int mini = 10000000;
            int minic = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mini)
                {
                    mini = array[i];
                    minic = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент: " + mini.ToString());
            Console.WriteLine("Индекс минимального элемента: " + minic.ToString());
        }
    }
}
