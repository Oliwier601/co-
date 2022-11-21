using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //zad1
            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            //a
            if (s*5 >= k)
            {
                Console.WriteLine("a) TAK");
            }
            else Console.WriteLine("a) NIE");
            //b
            if (k > s)
            {
                Console.WriteLine("b) "+s / 5);
            }
            //c
            if (k <= s * 5)
            {
                Console.WriteLine("Tak, " + s * 5);
            }
            */
            
            /*
            //zad2
            int a = 1000;
            int wynik = 0;
            int j = 100;
            for (int i = 1000; i < 10000; i++)
            {
                if (i % 10 == 0) i = 2 * j;
                for (j = 100; j < 1000; j++)
                {
                    if (j % 100 == 0) j = 2 * a;
                }
                wynik += a + j + i;
            }
            Console.WriteLine(wynik);
            */
            
            //zad3
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i + j == n) Console.Write($"{i},{j} ;");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }
            
            
        }
    }
}
