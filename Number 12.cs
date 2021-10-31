using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double [] array = new double [n];
            double sumi = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i+1}-й элемент массива");
                array[i] = double.Parse(Console.ReadLine());
                sumi += array[i];
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = sumi / n;
                }
                Console.WriteLine($"{i+1} элемент массива равен: " + array[i].ToString());
            }

        }
    }
}
