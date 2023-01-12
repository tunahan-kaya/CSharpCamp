using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] names = new string[] {"ahmet","mehmet","tunahan","kemal","gazi" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.ReadKey();


        }
    }
}
