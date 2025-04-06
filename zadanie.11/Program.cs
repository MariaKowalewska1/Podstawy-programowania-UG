using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._11
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać 
od użytkownika. Przykładowo dla n=3 należy obliczyć sumę 1+3+5. 
Do obliczenia wartości sumy użyj pętli for.*/

            int suma = 0;
            Console.Write("Podaj ilosc liczb nieparzystych, ktore chcesz zsumowac: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int liczba = 2 * i - 1;
                suma += liczba;// suma+=suma+liczba - do kazdej kolejnej sumy, dodaje nowa liczbe
                Console.Write(liczba);
                if (i < n)
                    Console.Write(",");
                else
                    Console.Write("");    
            }
            Console.WriteLine();//przejscie do kolejnego wiersza
            Console.WriteLine("Suma = " +suma);
            Console.ReadKey(true);
        }
    }
}
