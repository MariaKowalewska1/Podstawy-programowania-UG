using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static int czy_pierwsza(int liczba)
        {//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja 
         //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie tworzonej funkcji
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("czy 10 jest liczba pierwsza: {0}", czy_pierwsza(10));
            Console.WriteLine("czy 2 jest liczba pierwsza: {0}", czy_pierwsza(2));
        }
    }
}
