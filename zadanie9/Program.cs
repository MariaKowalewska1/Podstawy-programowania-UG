using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki 
funkcji kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich 
braku. 
Wskazówka: Zbadaj deltę, wyznacz miejsca zerowe. 
            */
            double a, b, c, delta,pzd;
            Console.WriteLine("Podaj wspolczynnik a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Funkcja nie ma miejsc zerowych");
            }
            else
            {
                pzd = Math.Sqrt(delta);
                Console.WriteLine("Pierwsze miejsce zerowe rowna sie {0}", (-b - pzd) / (2 * a));
                Console.WriteLine("Drugie miejsce zerowe rowna sie {0}", (-b + pzd) / (2 * a));
            }



        }
    }
}
