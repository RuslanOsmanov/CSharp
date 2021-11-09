using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumi = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    count += 1;
                    sumi += i;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sumi);
        }
    }
}
