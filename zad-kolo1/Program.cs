using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_kolo1
{
    internal class Program
    {
        static int odejmowanie(int[,] tab1, int[,] tab2, int wiersz, int kolumna)
        {//napisz metode ktora pokazuje wynik odejmowania wartosci wskazanej komorki dwoch tablic dwuwymiarowych

            return tab1[wiersz, kolumna] - tab2[wiersz, kolumna];



        }
        static void Main(string[] args)
        {
            int[,] tablica1 =
            {
                { 1, 12, 32
                },
                { 23, 98, 76
                }
            };
            int[,] tablica2 =
            {
                { 45, 3, 98
                },
                { 22, 43, 91 }
                
            };
            Console.Write("Wynik odejmowania tych dwoch elementow tablicy wynosi {0}", odejmowanie(tablica1, tablica2, 0, 1));
                Console.ReadKey(true);
        }

    }
}
