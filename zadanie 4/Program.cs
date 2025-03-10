using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            Double a, b;
            Console.WriteLine("Podaj długosc pierwzego boku prostokata: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj dlugosc drugiego boku prostokata: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole prostokata wynosi {0}", a * b);
            Console.WriteLine("Obwod prostokata wynosi {0}", 2 * a + 2 * b);
        }
    }
}
