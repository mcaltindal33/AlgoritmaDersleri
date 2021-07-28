using System;

namespace DegerTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sayilar1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            sayilar = sayilar1;
            sayilar1[0] = 200;
            Console.WriteLine(sayilar[0]);
        }
    }
}
