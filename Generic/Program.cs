using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
        MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Bursa");
            sehirler.Add("Eskisehir");
            Console.WriteLine(sehirler.Count);
            Console.ReadKey();
        }
    class MyList<T> //generic Class
        {
            T[] _array;
            T[] _tempArray; 
            public MyList()
            {
                _array= new T[0];
            }

            public void Add(T item)
            {
                _tempArray = _array;
                _array=new T[_array.Length+1];
            }

            

            public int Count
            {
                get { return _array.Length; }
              
            }

        }
    }
}
