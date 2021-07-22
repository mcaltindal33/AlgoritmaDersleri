using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerUygulamasi
{
    class Sabitler
    {
        public readonly decimal cap;
        public const decimal pi = 3.1428m;
        public Sabitler(decimal _cap)
        {
            cap = _cap;
        }

        public void AlanHesap()
        {
            decimal alan = decimal.Zero;
            alan = pi * cap * cap;
            Console.WriteLine($"Çap \t:{cap}\n\rAlan \t:{alan}");
        }
    }
}
