using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3_
{
    class Program
    {
        static void Main(string[] args)
        {   /*Napisz program wczytujący dwie liczby całkowite a oraz b (a<b) i obliczający sumę kolejnych
            liczb całkowitych począwszy od liczby a, a skończywszy na liczbie b. Obliczoną sumę wypisz
            na ekranie.Użyj pętli while.Np.dla a = -2 i b = 5 obliczamy sumę(-2)+(-1) + 0 + 1 + 2 + 3 + 4 + 5*/

            int a, b, i, suma;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe b, wieksza od a: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b<a)
            {
                Console.WriteLine("Liczba b jest mniejsza niz a");
                return;
            }
            i = a;//wartosc pierwszej iteracji jest rowny pierwszemu wyrazowi
            suma = a;//watosc pierwszej sumy bedzie rowna pierwszemu wyrazowi
            while (++i <= b)
            {
                suma += i;//suma kazdej kolejnej iteracji to suma poprzedniej sumy i kolejnej liczby
            }
            Console.WriteLine("Suma wyrazow od a do b wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
