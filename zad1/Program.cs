using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static int suma(int a, int b)
        {//Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami 
            //całkowitymi.Napisz program wykorzystujący funkcję suma.
            return a + b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1+2={0}", suma(1, 2));
            Console.ReadKey(true);
        }
    }
}
