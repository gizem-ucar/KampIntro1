using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Isimler = new MyDictionary<int, string>();
            Isimler.Add(1, "Gizem");
            Isimler.Add(2, "Selin");
            Isimler.Add(3, "İrem");



        }
    }
}
