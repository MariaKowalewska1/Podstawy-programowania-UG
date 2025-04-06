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
            Console.WriteLine("Podaj liczbe n>1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<1)
            {
                Console.WriteLine("n jest mniejsze od 1");
                return;
            }
            for (int i = 1; i<=n; i++)
            {
               for (int j=2; j<=i; j++)//XDD nie wiem czemu od 2 ale dziala
                {
                    Console.Write("*");

                }
                Console.WriteLine("*");
               
            }
            Console.ReadKey(true);

        }
    }
}
