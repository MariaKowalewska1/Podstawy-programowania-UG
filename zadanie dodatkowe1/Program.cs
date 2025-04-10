using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_dodatkowe1
{
    internal class Program
    {
        static void Main(string[] args)
        {//oblicz n-tą liczbę pierwszą (n – podane jako parametr)

            Console.Write("Podaj numer liczby pierwszej (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int licznik = 0;
            int liczba = 2;

            while (licznik < n)
            {
                if (CzyPierwsza(liczba))
                {
                    licznik++;
                }

                if (licznik < n)
                    liczba++;
            }

            Console.WriteLine($"{n}-ta liczba pierwsza to: {liczba}");
            Console.ReadKey(true);
        }

        static bool CzyPierwsza(int x)
        {
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return x > 1;

        }//napisane przez chatgpt
    }
}
