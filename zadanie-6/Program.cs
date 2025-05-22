using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach.
            string[] dnitygodnia = new string[] { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            foreach (string elem in dnitygodnia)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true);



        }
    }
}
