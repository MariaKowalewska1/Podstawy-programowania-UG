using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego miesiąca.Użyj instrukcji wyboru switch
            int miesiac=12;
            Console.Write("Podaj numer miesiaca");
            miesiac = Convert.ToInt32(Console.ReadLine());
           switch (miesiac)
            {
                case 1:  Console.WriteLine("Miesiac numer 1 to styczeń"); break;
                case 2: Console.WriteLine("Miesiac numer 2 to luty"); break;
                case 3: Console.WriteLine("Miesiac numer 3 to marzec"); break;
                case 4: Console.WriteLine("Miesiac numer 4 to kwiecień"); break;
                case 5: Console.WriteLine("Miesiac numer 5 to maj"); break;
                case 6: Console.WriteLine("Miesiac numer 6 to czerwiec"); break;
                case 7: Console.WriteLine("Miesiac numer 7 to lipiec"); break;
                case 8: Console.WriteLine("Miesiac numer 8 to sierpien"); break;
                case 9: Console.WriteLine("Miesiac numer 9 to wrzesien"); break;
                case 10: Console.WriteLine("Miesiac numer 10 to pazdziernik"); break;
                case 11: Console.WriteLine("Miesiac numer 11 to listopad"); break;
                case 12: Console.WriteLine("Miesiac numer 12 to grudzien"); break;
                default: Console.WriteLine("Nie ma takiego miesiaca"); break;
            }






        
        }
    }
}               