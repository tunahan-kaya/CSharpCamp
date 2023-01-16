using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //class newlendiğinde constructor otomatik çalışır
        public MyList() //constructor 
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi, elemanlar kaybolmasın diye items'ın referans numarasını alıyor
            items=new T[items.Length+1]; //eleman sayısı bir arttı
            for (int i = 0; i < tempArray.Length; i++)
            {
                item = tempArray[i];
            }
            items[items.Length-1] = item;

           // ​-1 muhabbeti = diziler 0 dan başlıyor ama.length ile uzunluğunu alırsak 1 den başlıyor gibi düşünün.
           // 0,1,2 ise 3 döndürüyor çünkü length
        }
    }
}
