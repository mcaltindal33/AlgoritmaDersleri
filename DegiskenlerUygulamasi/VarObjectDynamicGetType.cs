using System;
using System.Linq;

namespace DegiskenlerUygulamasi
{
    public class VarObjectDynamicGetType
    {

        public VarObjectDynamicGetType()
        {
            string[] meyveler = { "elma", "armut", "muz", "şeftali", "karpuz" };

            var tip = from m in meyveler
                where m[0] == 'a'
                select m;

            foreach(var m in tip)
                Console.WriteLine(m);
        }
    }
}
