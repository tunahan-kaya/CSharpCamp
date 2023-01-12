using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int adet = 0;
            for (int i = -50; i <= 50; i++)
            {
                if (i%7==0)
                {
                    x += i;
                    adet++;

                }
                
            }
            Console.WriteLine("toplam : "+x);
            int ort=x/adet; 
            Console.WriteLine("ortalama : "+ ort);
            Console.Read();
        }
    }
}
