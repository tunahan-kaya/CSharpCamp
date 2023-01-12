using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler= new string[] { };


            Product urun1 = new Product();
            urun1.ProductId = 1;
            urun1.ProductName = "elma";
            urun1.UnitPrice = 10;
            urun1.ProductComment = "amasya elması";


            Product urun2 = new Product();
            urun2.ProductId = 2;
            urun2.ProductName = "şeftali";
            urun2.UnitPrice = 15;
            urun2.ProductComment = "Bursa Şeftalisi";

            Product[] products = new Product[]
            {
                urun1, urun2
            };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName);
            }
            //encapsulation
            Console.WriteLine("---------------METOTLAR-----------");
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun2);
            sepet.Ekle(urun1);


        }
    }
}


