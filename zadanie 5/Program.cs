using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
            Double r, h,l;
            Console.WriteLine("Podaj promien podstawy stozka: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc stozka: ");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(h*h+r*r);
            Console.WriteLine("Objetosc stozka wynosi {0}", 1.0/3*Math.PI*r*r*h );
            Console.WriteLine("Pole calkowite stozka wynosi {0}", Math.PI * r * r + Math.PI * r*l);

        }
    }
}
