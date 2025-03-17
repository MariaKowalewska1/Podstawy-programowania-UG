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
            Double a, b, c,d,e,min,max;
            Console.WriteLine("Podaj liczbe a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b<min) min=b;
            if (c<min) min=c;
            if (d<min) min=d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest najwieksza", max);







        }
    }
}
