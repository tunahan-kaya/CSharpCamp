using System;

namespace ClassMetotDemo
{
    class MusteriManager :Musteri
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi: "+ musteri.CustomerFirstname);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi: " + musteri.CustomerFirstname);
        }

        public void List(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler:");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].CustomerFirstname+" "+CustomerLastname);
            }
        }
    }
}
