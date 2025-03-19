using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy da się z tych odcinków zbudować trójkąt, czy też nie.
            Wskazówka: Z trzech odcinków można zbudować trójkąt, jeżeli suma długości dowolnych dwóch odcinków jest większa od długości trzeciego odcinka.
            */
            double a, b, c;
            Console.Write("Podaj dlugosc pierwszego boku trojkata: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc drugiego boku trojkata: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc trzeciegi boku trojkata: ");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a)) 
            Console.WriteLine("Z tych odcinkow da sie zbudowac trojkat");
            else Console.WriteLine("Z tych odcinkow nie da sie zbudowac trojkata");

            
             
            
            

            
        }
    }
}
