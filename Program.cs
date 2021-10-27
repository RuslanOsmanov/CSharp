using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string clas;
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    clas = "Младшие";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    clas = "Средние";
                    break;
                case 9:
                case 10:
                case 11:
                    clas = "Старшие";
                    break;
                default:
                    clas = "Ошибка: класса с номером " + n + " не существует";
                    break;
            }
            Console.WriteLine(clas);
            Console.ReadLine();
        }
    }
}
