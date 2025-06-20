using System;
using System.IO;


namespace zadan3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = @"c:\tmp\liczby1.txt";
            double a, b, c, suma = 0;
            FileStream plik = new FileStream(nazwa,
                                FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);

            
            a = Convert.ToDouble(odczyt.ReadLine());
            b = Convert.ToDouble(odczyt.ReadLine());
            c = Convert.ToDouble(odczyt.ReadLine());
            suma = a + b + c;

            odczyt.Close();
            plik.Close();

            Console.WriteLine("Suma liczb w pliku wynosi {0}", suma);
            Console.ReadKey(true); 
        }
    }
}
