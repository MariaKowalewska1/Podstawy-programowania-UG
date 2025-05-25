using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_kolo1
{
    internal class Program
    {
        static void Main(string[] args)
        {//napisz metode ktora pokazuje wynik odejmowania wartosci wskazanej komorki dwoch tablic dwuwymiarowych


          int[,] tab1 = new int[2, 3] {//najpierw zadeklaruj rozmiar a potem wypisuj wyrazy
                { 1,2,3 },
                { 4,5,6 }
            };
            int[,] tab2 = new int[2, 3]
            {
                { 7, 8, 9 },
                { 10, 11, 12 }
            };
            Console.Write("Podaj indeks wiersza z pierwszej tablicy: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj indeks kolumny z pierwszej tablicy: ");
            int j1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj indeks wiersza z drugiej tablicy: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj indeks kolumny z drugiej tablicy: ");
            int j2 = Convert.ToInt32(Console.ReadLine());

           
            }
        }

    } 
