using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Ctoplam = 0;
            int Ttoplam = 0;
            int i = 0;
            int j = 0;
            while (true)
            {
                Console.WriteLine("Sayı gir: ");
                int girdi = Convert.ToInt32(Console.ReadLine());
                if (girdi % 2 == 0)
                {
                    if (girdi == 0)
                    {
                        break;
                    }
                    Ctoplam += girdi;
                    i++;
                }
                else if (girdi % 2 == 1)
                {
                    if (girdi == 0)
                    {
                        break;
                    }
                    Ttoplam += girdi;
                    j++;
                }
            }
            Console.WriteLine("Çift Sayı Toplamı: "+Ctoplam);
            Console.WriteLine("Çift Sayı Adet: "+i);
            Console.WriteLine("Tek Sayı Toplamı: "+Ttoplam);
            Console.WriteLine("Tek Sayı Adet: "+j);
            Console.ReadLine();
        }
    }
}
