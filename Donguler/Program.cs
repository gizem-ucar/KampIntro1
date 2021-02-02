using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yerleştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "C++";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yerleştirme kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java", "python" ,"C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            //dizi temelli yapıları tek tek dönmeye yarıyor.
            foreach (string kurs in kurslar)  //kurslar içinde dolaş
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer ");
        }
    }
}
