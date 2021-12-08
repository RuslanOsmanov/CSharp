using System;

class Program

{
    static void Main(string[] args)
    {
        string rus = Convert.ToString(Console.ReadLine());
        int counter = 0;

        foreach (string word in rus.ToLower().Split(" "))
        {
            if (word.StartsWith("о"))
            {
                counter++;
            }
        }
        Console.WriteLine($"Количество слов, которые пишутся с \"о\": {counter}");
    }
}