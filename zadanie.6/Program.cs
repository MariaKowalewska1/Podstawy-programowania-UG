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
            if (n < 1)
            {
                Console.WriteLine("n jest mniejsze, lub rowne 1");
                return;
            }
            for (int i = 1; i<=n; i++)
            {
                for (int j = 1; j <= n - i; j++) Console.Write(" ");//spacje, np. dla n=4, w pierwszym wierszu bedzie 4-1=3 - 3 spacje przed 1 gwiazdka, i po niej
                for (int j = 1; j <= 2 * i - 1; j++) Console.Write("*");
                
                Console.WriteLine(" ");
            }
        }
    }
}
