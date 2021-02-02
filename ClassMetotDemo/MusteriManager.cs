using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteriler)
        {

            Console.WriteLine(musteriler.Ad + " " + musteriler.Soyad + " " + musteriler.Id + " eklendi.");

        }
        public void MusteriListeleme(Musteri[] musteriDetay)
        {
            foreach (var musteri in musteriDetay)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Müşteri adı: " + musteri.Ad);
                Console.WriteLine("Müşteri soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşteri hesap numarası: " + musteri.Id);
                Console.WriteLine("*****************************************");

            }
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " İsimli müşteri siliniyor...");


        }
    }
}
