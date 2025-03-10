using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.
            Double a, b;
            Console.WriteLine("Podaj pierwsza liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Suma liczb wynosi {0}", a + b);
            Console.WriteLine("Roznica liczb wynosi {0}", a - b);
            Console.WriteLine("Iloczyn liczb wynosi {0}", a * b);
            Console.WriteLine("Iloraz liczb wynosi {0}", a / b);


        }
    }
}
