using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            string cevap="";
            cevap += sayi > 10 ? "sayi 10dan büyük" : "sayi 10dan kucuk";
            Console.WriteLine(cevap);
            Console.ReadKey();
            /*
             syntax yapısı:

             şart ? "ifade1" : "ifade2";
            şeklindedir.          */
        }
    }
}
