using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!
            string imie;
            Console.Write("Podaj imie: ");
            imie = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Witaj {0}!", imie);
        }
    }
}
