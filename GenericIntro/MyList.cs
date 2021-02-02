using System;
using System.Collections.Generic;
using System.Text;

namespace GenericInto
{
    class MyList<T>     // Kullanıcı tipini girecek.
    {
        T[] items;
        //constructor   : classı newlersen bu otomatik çalışacak.
        public MyList()
        {
            items = new T[0];   // itemsi burada newleriz daha rahat olur.
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //geçici array oluşturdu bıraktıklarımız kaybolmasın diye.Aşağıda arttırdığımızda silinmesin diye.
            items = new T[items.Length + 1];   //Eleman sayısını bir arttırdığımızda
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];    //tempArraydaki değerleri kendine alıyor.


            }//itemsın son değeri == yukardan gelen item
            items[items.Length - 1] = item;   //Şu an eklenmek istenen eleman eklendi. 

        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
