using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;

        //bir class newlendiğinde çalışan blok constructor
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            //new dediğimiz zaman yeni referans numarası alır önceki elemanlar silinir. bu yüzden bu elemanlar silinmesin diye temparray e atadık

            items = new T[items.Length + 1];
            //mevcut eleman sayısını 1 arttırır

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
