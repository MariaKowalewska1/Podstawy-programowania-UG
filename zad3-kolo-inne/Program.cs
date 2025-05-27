using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_kolo_inne
{
    internal class Program
    {
        static int[]scalanie(int[]tab1,int[]tab2)
        {//napisz metode ktora zwraca dwie scalone tablice jednowymiarowe
            int[] wynik = new int[tab1.Length + tab2.Length];
            for (int i = 0; i < tab1.Length; i++)
                wynik[i] = tab1[i];
            for (int j = 0; j < tab2.Length; j++)
                wynik[tab1.Length + j] = tab2[j];
            return wynik;
        }
    }
}
