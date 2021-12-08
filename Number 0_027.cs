using System;

class Program

{
    //Дана строка, заканчивающаяся точкой.
    //Подсчитать, сколько слов в строке.
    static void Main(string[] args)
    {
        string rus = Convert.ToString(Console.ReadLine());
        int count = 1;
        if (rus.EndsWith('.'))
        {
            for (int i = 0; i < rus.Length; i++)
            {
                if (rus[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        else
        {
            Console.WriteLine("Строка не заканчивается на '.'");
        }
    }
}