﻿using System;
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

            int n;
            Console.WriteLine("Podaj wartość liczby naturalnej n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0) 
            {
                Console.WriteLine("To nie jest liczba naturalna");
                return;
            }
            
            int wynik = 1;
            for (int i = 0; i < n; i++) 
            {
                wynik = wynik * 2;
            }
            Console.WriteLine("2^{0}={1}",n,wynik);
            Console.ReadKey(true);

        }
    }
}
