using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> sehirler = new MyList<string>(); 
            //sehirler.Add("Bursa");
            //sehirler.Add("İstanbul");
            //Console.WriteLine(sehirler.Count);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("elma", 1);
            dic.Add("armut", 2);
            dic.Add("muz", 3);

            foreach (var item in dic)
            {
                Console.WriteLine("adı: "+item.Key+", sırası: "+item.Value);
            }



            Console.Read();
        }
    }

    //class MyList<T> //generic class
    //{
    //    T[] _array;
    //    T[] _tempArray; //geçici array
    //    public MyList()
    //    {
    //        _tempArray=_array;
    //        _array = new T[0];
    //    }
    //    public void Add(T item)
    //    {
    //        _array = new T[_array.Length + 1];
    //    }

        
    //    public int Count
    //    {
    //        get { return _array.Length; }
    //    }

    //}
}
