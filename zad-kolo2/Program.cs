using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_kolo2
{
    internal class Program
    {
        static void odwrotnosc(int[]tab)
        {//napisz metode ktora pokazuje zawartosc tablicy jednowymiarowej w odwrotnej kolejnosci
            for (int i = tab.Length-1;i>=0;i--)
                Console.Write(tab[i]);
        }
        static void Main(string[] args)
        {
            int[] tablica = { 1, 4, 7, 8 };
            Console.Write("Elementy tablicy odwrotnie: ");
            odwrotnosc(tablica);
                }
    }
}
