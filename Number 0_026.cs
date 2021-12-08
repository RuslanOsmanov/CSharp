using System;

class Program

{
    //В строке заменить все заглавные буквы строчными.
    static void Main(string[] args)
    {
        string rus = Convert.ToString(Console.ReadLine());
        Console.WriteLine(rus.ToLower());
    }
}