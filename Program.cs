using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    148 строка While

            //нули и ряд-1 for 
            //мин из 2-х и високосный год if


            //int year = Convert.ToInt32(Console.ReadLine());
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите конец счетчика");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите начало счетчика");
            //int count = 0;
            //int n = Convert.ToInt32(Console.ReadLine());

            /*if (a > b)
            {
                Console.WriteLine($"a>b,{a}>{b}");
            }
            else
            {
                Console.WriteLine($"a<b,{a}<{b}");
            }
            */


            /*if (year % 4 == 0 && year % 100 != 0)
                {
                Console.WriteLine("YES");
                }
            else if (year% 400 == 0)
                {
                Console.WriteLine("YES");
                }
            else
                {
                Console.WriteLine("NO");
                }
            */


            /*for (int a = Convert.ToInt32(Console.ReadLine()); a < b ; a++ )
            {
                Console.WriteLine(a);
            }
            */


            /*for (int i = 1; i<=n ; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
            */


            /*if  ((a+b) % 2 == (c+d) % 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            */


            /*if ((a == c) || (b == d))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }*/


            /*if (Math.Abs(a-c)==Math.Abs(b-d))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            */

            // FOR ЗАДАЧИ 1-факториал 2 - сумма факториалов

            /*int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int sumf = 0;
            for (int i = 1; i<=n; i++)
            {
                fact *= i;
                sumf += fact;
            }
            Console.WriteLine(sumf);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=n ; i++ )
            {
                for (int j =1; j<=i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine( );
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            */



            // WHILE 

            /*int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(Math.Pow(i, 2));
                i++;
            }
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (n % i != 0)
            {
                i++;
            }
            Console.WriteLine(i);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (Math.Pow(2, i + 1) <= n)
            {
                i++;
            }
            Console.WriteLine(i);
            Console.WriteLine(Math.Pow(2, i));
            */


            /* double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (x < y)
            {
                double c = x / 10;
                x = (double) (x + c);
                i++;
                Console.WriteLine(x);
            }
            Console.WriteLine(i);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n!=0)
            {
                i += 1;
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(i);
            */


            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int maxi = 0;
            while (n != 0)
            {
                if (n > maxi)
                {
                    maxi = n;
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(maxi);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            if (n==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int a = 0;
                int b = 1;
                for (int i = 2; i < n + 1; i++)
                {
                    int z = a;
                    a = b;
                    b = z + b;
                }
                Console.WriteLine(b);
            }
            */


            /*long n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                long z = 0;
                long b = 1;
                for (long i = 2; i < 10000000000; i++)
                {
                    long a = z;
                    z = b;
                    b = a + b;
                    if (b == n)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    else if (z + b > n)
                    {
                        Console.WriteLine(-1);
                        break;
                    }
                }
            }
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            List<int> numb = new List<int>() {n};
            while (n != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                numb.Add(n);
            }
            for (int i = 1; i < numb.Count - 1; i++)
            {
                if (numb[i-1] < numb[i])
                {
                    m += 1;
                }
            }
            Console.WriteLine(m);
            */

            /*int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int sumi = 0;
            while (n != 0)
            {
                c += 1;
                sumi += n;
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine((double)sumi/c);
            */


            /*int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            while (n!=0)
            {
                if (n%2 ==0)
                {
                    c += 1; 
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(c);
            */

            /*int n = Convert.ToInt32(Console.ReadLine());
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
                    clas = "Ошибка: класса с номером " + n +  " не существует";
                    break;
            }
            Console.WriteLine(clas);
            Console.ReadLine();
            */
            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (1<=a && a <= 3)
            {
                count ++;
            }
            if (1 <= b && b <= 3)
            {
                    count++;
            }
            if (1 <= c && c <= 3)
            {
                count++;
            }
            Console.WriteLine(count);
            */
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 500 && n < 1000) 
            {
                Console.WriteLine(n - (n* 0.03));
            }
            else if (n > 1000) 
            {
                Console.WriteLine(n - (n * 0.05));
            }
        }
    }
}
