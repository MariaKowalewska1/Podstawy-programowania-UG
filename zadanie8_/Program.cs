using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej. 
            Użyj pętli while.Np.: Dla liczby = 1342 trzeba obliczyć sumę 1 + 3 + 4 + 2.*/

            int liczba, suma=0;
            Console.Write("Podaj liczbe: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            while (liczba > 0)
            {
                suma += liczba % 10;//suma = reszta z liczby wprowadzonej, podzielonej przez 10 (jak sie wprowadzi 123 to to bedzie 3) + suma tych cyfr z poprzednich iteracji 
                liczba /= 10;//po wykonaniu, odciecie tej cyfry ktora byla reszta
            }
            Console.WriteLine("Suma cyfr tej liczby wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
