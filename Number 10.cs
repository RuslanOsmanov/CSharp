using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапозон таблицы умножения");
            Console.WriteLine("Введите начало диапозона");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапозона");
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
