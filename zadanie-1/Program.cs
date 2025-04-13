using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Napisać program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację, 
do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/lub osi OY.*/

            int x, y;
            Console.Write("Podaj punkt x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj punkt y:");
            y = Convert.ToInt32(Console.ReadLine());
            if ((x > 0) && (y > 0)) Console.WriteLine("Punkt({0},{1}) nalezy do 1 cwiartki", x, y);
            else if ((x < 0) && (y > 0)) Console.WriteLine("Punkt ({0},{1}) nalezy do 2 cwiartki", x, y);
            else if ((x < 0) && (y < 0)) Console.WriteLine("Punkt({0},{1}) nalezy do 3 cwiartki", x, y);
            else if ((x > 0) && (y < 0)) Console.WriteLine("Punkt ({0},{1}) nalezy do 4 cwiartki", x, y);
            if (y == 0) Console.WriteLine("Punkt znajduje sie na osi OX");
            else if (x == 0) Console.WriteLine("Punkt znajduje sie na osi OY");


        }
    }
}
