using System;

class Program

{
    static void Main(string[] args)
    {
        string rus = Convert.ToString(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < rus.Length; i++)
        {
            if (rus[i] == ':')
            {
                counter++;
            }
        }
        Console.WriteLine(rus.Replace(':','%'));
        Console.WriteLine(counter);
    }
}