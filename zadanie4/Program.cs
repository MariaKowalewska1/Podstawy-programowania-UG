using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej i największej z tych liczb
            int a, b, c, d, e, min, max;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe e: ");
            e = Convert.ToInt32(Console.ReadLine());
            min = a;//zakladam ze a jest najmniejsze i potem porownuje je kolejno do innych wartosci
            if (b < min) min = b;//jesli b bedzie mniejsze od a, stanie sie min, jesli nie to przetestowane zostana inne wprowadzone liczby
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Najwieksza liczba to {0}", max);
            Console.WriteLine("Najmniejsza liczba to {0}", min);






        }
    }
}
