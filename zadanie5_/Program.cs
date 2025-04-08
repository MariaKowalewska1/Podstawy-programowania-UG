using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5_
{
    class Program
    {
        static void Main(string[] args)
        {/*Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
ekranie. Użyj pętli do-while*/

            int x;
            do
            {
                Console.Write("Podaj liczbe rzeczywista: ");
                x = Convert.ToInt32(Console.ReadLine());

            }
            while (x <= 0);//gdy wpisze sie liczbe dodatnia, ten warunek przestanie byc prawdziwy - petla sie zakonczy
            Console.WriteLine("Wczytano liczbe rzeczywista dodatnia: {0}",x);
            Console.ReadKey(true);
        }
    }
}
