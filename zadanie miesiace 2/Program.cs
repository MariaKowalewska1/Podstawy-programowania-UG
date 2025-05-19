using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_miesiace_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] miesiace = new string[] { "styczen", "luty", "marzec", "kwiecien","maj","czerwiec", "lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzien" };
            int i;
            for (i=0;i<miesiace.Length;i++)
            {
                Console.WriteLine(miesiace[i]);
            }
            Console.ReadKey(true);

        }
    }
}
