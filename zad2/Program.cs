using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static int max(int a, int b)
        {
            //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
            //zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.

            if (a > b) return a;
            else return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("max z 1 i 2 = {0}", max(1, 2));
            Console.ReadKey(true);
        }
    }
}
