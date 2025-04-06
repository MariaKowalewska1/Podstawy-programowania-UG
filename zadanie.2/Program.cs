using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do 
            potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            wartości wyrażenia użyj pętli for.*/

            int wynik = 1;//wynik musi sie rownac 2 bo wynik pierwszej iteracji to 1 - 2^0=1
            Console.WriteLine("Podaj n>=0: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine("n jest mniejsze od 0");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                wynik *= 2;//to jest wynik=wynik z poprzedniej iteracji * 2, czyli jak n=3 to it1=2*1=2, it2=2*2=4, it3=2*4=8
            }
            Console.WriteLine("2^{0}={1}", n, wynik);//musi byc poza petla zeby wypisalo tylko ostatni wynik
            Console.ReadKey(true);
        }
    }
}
