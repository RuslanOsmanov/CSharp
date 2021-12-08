using System;

class Program

{
    static void Main(string[] args)
    {
        Perimeter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
    static void Perimeter(int a, int b, int c)
    {
        int per = a + b + c;
    }
}