using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._6
{
    class Program
    {
        static void Main(string[] args)
        {/*Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n=3 narysowany trójkąt powinien wyglądać:
             *
            ***
           ***** */
            Console.WriteLine("Podaj wysokosc trojkata, wieksza od 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<1)
            {
                Console.WriteLine("n jest mniejsze, lub rowne 1");
                return;
            }
            for (int i=1; i<=n; i++)
            {
                for (int k=1; k<=n-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j=2; j<=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey(true);
        }
    }
}
