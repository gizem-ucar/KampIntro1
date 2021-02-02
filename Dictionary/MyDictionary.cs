using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Tk, Tv>
    {
        Tk[] Key;     //bir arrayin newlenme zorunluğu var. 
        Tv[] Value;

        public MyDictionary()       //bir class newlendiğinde çalışan bloğa constructor deniliyor.
        {
            Key = new Tk[0];
            Value = new Tv[0];

        }

        public void Add(Tk Tkey, Tv Tvalue)
        {
            Tk[] tempArray1 = Key;
            Tv[] tempArray2 = Value;
            Key = new Tk[Key.Length + 1];
            Value = new Tv[Value.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                Key[i] = tempArray1[i];
                Value[i] = tempArray2[i];

            }
            Key[Key.Length - 1] = Tkey;
            Value[Value.Length - 1] = Tvalue;

            Console.WriteLine("Sıra numarası " + Tkey + " İsmi " + Tvalue + " olan öğrenci sisteme eklendi. ");
        }
    }
}
