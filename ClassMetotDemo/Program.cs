using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.CustomerFirstname = "Tunahan";
            musteri1.CustomerLastname = "Kaya";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.CustomerFirstname = "Kemal Tahir";
            musteri2.CustomerLastname = "Ayaz";


            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.CustomerFirstname = "Batuhan";
            musteri3.CustomerLastname = "Altıntaş";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteriler[0]);
            musteriManager.Delete(musteriler[2]);
            musteriManager.List(musteriler);
            Console.ReadLine();
            
        }

    }
}
