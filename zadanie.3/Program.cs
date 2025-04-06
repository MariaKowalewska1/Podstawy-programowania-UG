using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy 1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for. 

            int suma = 0;// suma musi sie zaczynac od 0 zeby nie wplywac z gory na wynik - jesli rownalaby sie 1, pierwsza iteracja = 1+1=2
            Console.Write("Podaj liczbe n>2: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<2)
            {
                Console.WriteLine("n jest mniejszy od 2");
                return;
            }
            for (int i = 0; i<=n; i++)
            {
                suma += i;//suma = suma z poprzedniej teracji + kolejna liczba
            }
            Console.WriteLine("1+...+{0}={1}", n, suma);
            Console.ReadKey(true);
            


        }
    }
}
