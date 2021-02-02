using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.TcNo = "21345346643";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "3235346547";
            musteri2.Id = 2;
            musteri2.SirketAdi = "gizem gizem";
            musteri2.VergiNo = "23257996";


            //SOLİD L harfidir.

            //Gerçek müşteri - tüzel müşteri bunlar sırf aynı diye birbirinin yerine kullanılamaz.


            Musteri musteri3 = new GercekMusteri();   //referans değer.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManeger musteriManeger = new MusteriManeger();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);


        }
    }
}
