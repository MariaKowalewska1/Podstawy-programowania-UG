using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._13
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta 
prostokątnego jak na poniższym przykładzie. Użyj pętli for. 
Dla n=5 powinien zostać narysowany trójkąt: 
X 
XX 
X X 
X  X 
XXXXX */
            Console.Write("Podaj liczbe n>4, oznaczajaca wysokosc trojkata: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 4)
            {
                Console.WriteLine("Liczba jest mniejsza od 4");
                return;
            }
            for (int i=1; i<=n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("X");//1 X w pierwszym wierszu
                }
                else if (i == n)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("X");// n X w ostatnim wierszu
                    }
                }
                else
                {
                    Console.Write("X");//pierwszy X dla srodkowych wierszy
                    for (int j = 1; j<= i - 2; j++)
                    {
                        Console.Write(" ");//spacje miedzy X - np dla i=4, liczba spacji to 4-2=2
                    }
                    Console.WriteLine("X");//ostatni X dla srodkowych wierszy
                }
                
            }
            Console.ReadKey(true);

        }
    }
}
