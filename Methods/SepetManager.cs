using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    internal class SepetManager
    {
        //naming convention (isimlendirme kuralı)
        public void Ekle(Product product)
        {
            Console.WriteLine("sepete eklendi: "+product.ProductName);
        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("spete eklendi:  "+urunAdi);
        }
    }
}
