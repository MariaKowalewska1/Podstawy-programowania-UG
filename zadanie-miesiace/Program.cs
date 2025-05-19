using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_miesiace
{
    internal class Program
    {
        static void Main(string[] args)
        {//zadeklaruj tablice z nazwami miesiecy
            string[] miesiace = new string[] { "styczen", "luty", "marzec", "kwiecien", "maj", "czerwiec", "lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzien" };
            Console.Write(string.Join(", ", miesiace));
            Console.ReadKey(true);
        }
    }
}
