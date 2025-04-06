using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._12
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. 
Oto wydruk dla wysokości h=6: 
1 
2 4   
3 6 9 
4 8 12 16 
5 10 15 20 25 
6 12 18 24 30 36*/

            int n;
            Console.Write("Podaj wysokosc trojkata: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)//i liczba wierszy
            {
                for (int j=1; j<=i; j++)//j liczba kolumn
                {
                    Console.Write(i * j + " ");// + " " żeby po każdej licznie była spacja
                }
                Console.WriteLine();//przejscie do kolejnego wiersza

            }
            Console.ReadKey(true);


        }
    }
}
