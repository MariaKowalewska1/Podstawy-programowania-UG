using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static double ile_cyfr(int liczba)
        {//Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako 
            //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
            int i = 0;
            while (liczba/10>0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfr", ile_cyfr(0));
            Console.WriteLine("Liczba 12345 ma {0} cyfr", ile_cyfr(12345));
            Console.ReadKey(true);
        }
    }
}
