using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    class MyDictionary<T>
    {
        T[] _items;
        public MyDictionary()
        {
            _items= new T[0];
        }
        public void Add(T item)
        {
            T[] _tempItems = new T[_items.Length + 1];
            for (int i = 0; i < _tempItems.Length; i++)
            {
                _items[i] = _tempItems[i];
            }
           _items[_items.Length+1] = item;
        }
    }
}
