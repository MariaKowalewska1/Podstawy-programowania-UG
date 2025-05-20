using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static double pole_kola(double r)
        {//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca 
         // obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.

            return Math.PI * r * r;//math.pi to zmienna typu double
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Pole kola o promieniu 5 = {0}", pole_kola(5));
            Console.ReadKey(true);
        }
    }
}
