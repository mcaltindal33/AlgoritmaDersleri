using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolYapilari
{
    public class Products
    {
        public Products(int mid, string name, double unitPrice, Categories category)
        {
            this.mid = mid;
            this.name = name;
            this.unitPrice = unitPrice;
            this.category = category;
        }

        public Products()
        {
            Console.WriteLine("Ben Çalıştım.");
        }

        public int mid;
        public string name;
        public double unitPrice;
        public Categories category;

    }
    public class Categories
    {
        public Categories()
        {
            Console.WriteLine("Ben Çalıştım.");
        }
        public Categories(int mid, string name)
        {
            this.mid = mid;
            this.name = name;
        }
        public int mid;
        public string name;
    }
}
