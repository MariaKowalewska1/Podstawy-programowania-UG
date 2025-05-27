using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowe4
{
    internal class Program
    {
        static bool czyjest(int[] tab, int liczba)
        {//Metoda sprawdzająca, czy liczba występuje w tablicy
            foreach (int x in tab)
            {
                if (x == liczba)
                    return true;
            }
                 return false;
        }

        

    }
}
