using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20: Console.WriteLine("number is 20");
                    break ;
                    case 30: Console.WriteLine("number is 30");
                    break;
                case 40: Console.WriteLine("number is 40"); break;
                default: Console.WriteLine("number not identified"); break;

            }

            Console.Read();
        }
    }
}
