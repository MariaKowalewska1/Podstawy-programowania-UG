using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość.
            Double n;
            Console.WriteLine("Podaj liczbe n: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} wyraz ciagu rowna sie {1}", n, 3.0 * n - 1.0);
        }
    }
}
