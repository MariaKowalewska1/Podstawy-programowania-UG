using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny czy też nie
            Double rok;
            Console.WriteLine("Podaj rok: ");
            rok = Convert.ToDouble(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
                Console.WriteLine("Rok {0} jest przestępny", rok);
            else
                Console.WriteLine("Rok {0} nie jest przestepny", rok);

                
        }
    }
}
