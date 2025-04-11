using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb
            int a, b, c;
            Console.Write("Podaj pierwsza liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj trzecia liczbe: ");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c)) Console.WriteLine("Liczba a jest najwieksza z podanych");
            else if ((b > c) && (b > a)) Console.WriteLine("Liczba b jest najwieksza z podanych");
            else  Console.WriteLine("Liczba c jest najwieksza z podanych");
            if ((a < b) && (a < c)) Console.WriteLine("Liczba a jest najmniejsza z podanych");
            else if ((b < a) && (b < c)) Console.WriteLine("Liczba b jest najmniejsza z podanych");
            else Console.WriteLine("Liczba c jest najmniejsza z podanych");
            Console.ReadKey(true);





        }
    }
}
