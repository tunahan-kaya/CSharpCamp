using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("1.sayıyı giriniz:   ");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:   ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------");
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(sayi1, sayi2);
            dortIslem.Cıkar(sayi1,sayi2);
            dortIslem.Carp(sayi1, sayi2);
            dortIslem.Bol(sayi1, sayi2);

            Console.ReadLine();
        }
    }
}
