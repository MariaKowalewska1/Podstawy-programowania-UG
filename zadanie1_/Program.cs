using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1_
{
    class Program
    {
        static void Main(string[] args)
        {//Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z przedziału [a, b].Użyj pętli while

            int a, b, i;
            Console.WriteLine("Podaj liczbe a, wieksza od 0: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.Write("Liczba a jest mniejsza od 0");
                return;
            }
            Console.WriteLine("Podaj liczbe b, wieksza od a: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < a)
            {
                Console.Write("Liczba b jest mniejsza od liczby a");
                return;
            }
            i = a;//wartosc pierwszej iteracji to a 
            while (i <= b)
            {
                if (i == 2) Console.Write("" + i);
                else if
                    (i % 2 == 0) Console.Write(", "+i);
                i++;
            }
            Console.ReadKey(true);   
        }
    }
}
