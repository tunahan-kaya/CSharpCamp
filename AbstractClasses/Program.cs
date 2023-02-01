using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MevzuatBase mevzuatBase = new BMevzuat();
            mevzuatBase.Kaydet();
            Console.Read();

        }
    }

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
        public abstract void Degerlendir();

        public void Kaydet()
        {       
            Console.WriteLine("Kaydedildi.");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }


    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }
}
