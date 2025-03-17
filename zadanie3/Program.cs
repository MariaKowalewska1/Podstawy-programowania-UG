using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb
            Double a, b, c;
            Console.WriteLine("Podaj liczbe a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.Write("Licbza a jest największa ");
            else if ((b > a) && (b >c))
                Console.Write("Liczba b jest najwieksza ");
            else
                Console.Write("Liczba c jest najwieksza ");
            if ((a < b) && (a < c))
                Console.Write("Liczba a jest najmniejsza ");
            else if ((b < a) && (b < c))
                Console.Write("Liczba b jest najmniejsza ");
            else
                Console.Write("Liczba c jest najmniejsza ");
           


                
            

        }
    }
}
