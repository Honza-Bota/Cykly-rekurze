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
                Console.WriteLine("Součet pomocí cyklu 'for':        " + SoucetFor(x, n));
                Console.WriteLine("Součet pomocí cyklu 'while':      " + SoucetWhile(x, n));
                Console.WriteLine("Součet pomocí cyklu 'do-while':   " + SoucetDoWhile(x, n));
                Console.WriteLine("Součet pomocí rekurentní metody:  " + SoucetRekurent(x, n));
                Console.WriteLine("--------------------");
                Console.WriteLine("Pro ukončení stiskněte 'k'. Jinak jedeme znovu ;)");
                cki = Console.ReadKey();
                
            } while (cki.Key != ConsoleKey.K);
        }

        private static string SoucetFor(int x, int n)
        {
            return "Hi";
        }

        private static string SoucetWhile(int x, int n)
        {
            return "Hi";
        }

        private static string SoucetDoWhile(int x, int n)
        {
            return "Hi";
        }

        private static string SoucetRekurent(int x, int n)
        {
            return "Hi";
        }
    }
}
