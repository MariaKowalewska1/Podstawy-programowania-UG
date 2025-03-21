using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt powinien wyglądać:
            *
            ** 
            ***/
            double n;
            Console.WriteLine("Podaj liczbe naturalna n wieksza od 1: ");
            n = Convert.ToDouble(Console.ReadLine());
            int i, j;
            for (i = 1; i <= n; i++) 
            {
                for (j = 1; j<= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);


        }
    }
}
