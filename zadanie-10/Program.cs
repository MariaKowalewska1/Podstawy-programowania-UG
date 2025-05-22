using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie 
         //informację ile liczb jest dodatnich, ujemnych i równych zero. 
            int[] tab = new int[1000];
            int n, i, dodatnie = 0, ujemne = 0, zero = 0;
            Console.Write("Podaj liczbe wyrazow ciagu, mniejsza lub rowna 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (tab[i] > 0) dodatnie += 1;
                else if (tab[i] < 0) ujemne += 1;
                else 
                    zero += 1;
            }
            Console.WriteLine("Wyrazy dodatnie: {0}, wyrazy ujemne: {1}, wyrazy rowne 0: {2}", dodatnie, ujemne, zero);

                    

        }
    }
}
