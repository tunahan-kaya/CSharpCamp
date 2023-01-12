using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 5;

            Product product2 = new Product { Id = 2,CategoryId=5,UnitsInStock=100,UnitPrice=10,ProductName="Kalem" };

            ProductManager productManager = new ProductManager();
            productManager.Add();

        }
    }


    
}
