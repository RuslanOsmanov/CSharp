using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапозон таблицы умножения");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (n <= m)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} * {i} = {n * i}");
                }
                n++;
                Console.WriteLine();
            }
        }
    }
}
