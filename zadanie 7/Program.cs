using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia
            Double a, b;
            Console.WriteLine("Podaj pierwsza liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iloraz liczb wynosi {0}, Reszta wynosi {1}", a/b,a%b);

        }
    }
}
