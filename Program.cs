using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly_rekurze
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                Console.Write("Zadej první číslo 'x': ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadej druhé číslo 'n': ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------");
                try
                {
                    Console.WriteLine("Součet pomocí cyklu 'for':        " + SoucetFor(x, n));
                    Console.WriteLine("Součet pomocí cyklu 'while':      " + SoucetWhile(x, n));
                    Console.WriteLine("Součet pomocí cyklu 'do-while':   " + SoucetDoWhile(x, n));
                    Console.WriteLine("Součet pomocí rekurentní metody:  " + SoucetRekurent(x, n));
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                Console.WriteLine("--------------------");
                Console.WriteLine("Pro ukončení stiskněte 'k'. Jinak jedeme znovu ;)");
                cki = Console.ReadKey();
                
            } while (cki.Key != ConsoleKey.K);
        }

        private static int SoucetFor(int x, int n)
        {
            int soucet = 1;
            for (int i = 1; i <= n; i++)
            {
                soucet += x * i / Factorial(i);
            }
            return soucet;
        }

        private static int SoucetWhile(int x, int n)
        {
            int soucet = 1;
            while (0 != n)
            {
                soucet += x * n / Factorial(n);
                n--;
            }
            return soucet;
        }

        private static int SoucetDoWhile(int x, int n)
        {
            int soucet = 1;
            do
            {
                soucet += x * n / Factorial(n);
                n--;

            } while (0 != n);
            return soucet;
        }

        private static int SoucetRekurent(int x, int n, int soucet = 1)
        {
            if (n == 0) return soucet;
            else 
            {
                soucet += x * n / Factorial(n);
                return SoucetRekurent(x, n - 1, soucet); 
            }
        }

        private static int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }
    }
}
