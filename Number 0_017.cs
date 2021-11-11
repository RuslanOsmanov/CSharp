using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер");
            Console.WriteLine("Введите номер единицы измерения");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу");
            double M = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (n == 1)
            {
                Console.WriteLine(M .ToString() + " кг");
            } else if (n == 2)
            {
                Console.WriteLine((M / 100000).ToString() + " кг");
            } else if (n == 3)
            {
                Console.WriteLine((M / 1000).ToString() + " кг");
            } else if (n == 4)
            {
                Console.WriteLine((M * 1000).ToString() + " кг");
            }
            else if (n == 5)
            {
                Console.WriteLine((M * 100).ToString() + " кг");
            } else
            {
                Console.WriteLine("Вы ввели число не входящее в номера единиц измерения");
            }
        }
    }
}