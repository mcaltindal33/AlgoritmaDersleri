using System;
using System.Linq;

namespace DegiskenlerUygulamasi
{
    public static class Kutulama
    {
        public static void AnaKod()
        {
            //Kutulama - Boxing
            int i = 3;
            object o = i; // explicit boxing


            //Kutudan Çıkarma - Unboxing
            i *= 2; // i = i * 2;
            Console.WriteLine($"Değer Türü : {i}");
            i = (int)o; //cast
            Console.WriteLine($"Referans Türü : {o}");

        }
    }
}
