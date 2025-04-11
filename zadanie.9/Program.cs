using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._9
{
    internal class Program
    {
        static void Main(string[] args)
        {//Wypisz tabliczkę mnożenia do 100 w formie tabelki

            int i,j ;
            for (i=1; i<=10; i++)//wiersze
            {
                for (j=1; j<=10; j++)//kolumny
                {
                    Console.Write("{0,3}", i * j);//wartosc wprowadzana do 0 ma zajac przynajmniej 3 znaki, wtedy rowno i ladnie
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey(true);

        }
    }
}
