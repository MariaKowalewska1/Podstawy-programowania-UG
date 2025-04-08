using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n) dla wczytanej z klawiatury 
liczby naturalnej n. Użyj pętli while. Np.: dla n=5 wypisz wynik 5!=120.*/

            int silnia=1;
            Console.Write("Podaj liczbe n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <=n)
            {
                silnia *= i;
                i++;//i++ jest dopiero tutaj, bo najpierw program sprawdza warunek, potem wykonuje petle, i dopiero potem zwieksza sie o 1, inaczej by liczylo od razu dla 2
            }
            Console.WriteLine("n!=1*...*{0}={1}", n, silnia);
            Console.ReadKey(true);
        }
    }
}
