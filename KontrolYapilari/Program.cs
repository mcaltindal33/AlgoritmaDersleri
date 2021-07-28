using System;
using System.Collections.Generic;
using System.Linq;

namespace KontrolYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Categories c1 = new Categories(1, "Bilgisayar");
            Categories c2 = new Categories();
            c2.mid = 2;
            c2.name = "Notebook";
            Products p1 = new Products();
            p1.mid = 1;
            p1.name = "Lenovo V1";
            p1.unitPrice = 15250;
            p1.category = c2;
            Products p2 = new Products(2, "Lenovo V2", 25250.00, c1);
            Products p3 = new Products(3, "Lenovo V3", 35250, c1);
            Products p4 = new Products(4, "Lenovo V4", 45250, c1);
            Products p5 = new Products(5, "Lenovo V5", 55250, c1);
            Products p6 = new Products(6, "Lenovo V6", 65250, c1);
            Products p7 = new Products(7, "Lenovo V7", 75250, c1);
            Products p8 = new Products(8, "Lenovo V8", 85250, c1);

            Products[] products = { p1, p2, p3, p4, p5, p6, p7, p8 };

            Console.WriteLine("Ürün Siparişi 1");
            Console.WriteLine("Ürün Fiyat Listesi 2");
            UrunSiparis(products);

        }

        static void UrunSiparis(Products[] products)
        {
            bool flag = true;
            Console.WriteLine("--- Menü ---");
            Console.WriteLine("Ürün Siparişi 1");
            Console.WriteLine("Ürün Fiyat Listesi 2");
            Console.WriteLine("Çıkış 2");
            List<Products> products1 = new List<Products>();

            while (flag)
            {
                Console.Write("Lütfen İşem Seçin : ");
                int secilen = Convert.ToInt32(Console.ReadLine());
                switch (secilen)
                {
                    case 1:
                        Console.Write("Lütfen Ürün Seçin : ");
                        int urun = Convert.ToInt32(Console.ReadLine());
                        if (secilen > 0)
                        {
                            Products p = products.Where(x => x.mid == urun).FirstOrDefault();
                            Console.WriteLine($"{p.mid} - {p.name}  - {p.unitPrice} - {p.category.name}");
                            products1.Add(p);
                        }
                        break;
                    case 2:
                        foreach (Products item in products)
                        {
                            Console.WriteLine($"{item.mid} - {item.name}  - {item.unitPrice} - {item.category.name}");
                        }
                        break;
                    case 3:
                        flag = false;
                        break;
                    case 4:
                        foreach (Products item in products1)
                        {
                            Console.WriteLine($"{item.mid} - {item.name}  - {item.unitPrice} - {item.category.name}");
                        }
                        Console.WriteLine("Toplam Tutar:" + products1.Sum(x => x.unitPrice));
                        break;
                }
            }
        }

    }
}
