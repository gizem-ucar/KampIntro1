using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Gizem";
            musteri1.Soyad = "Uçar";
            musteri1.Id = 128;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "İrem";
            musteri2.Soyad = "Gazi";
            musteri2.Id = 274;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Yusuf";
            musteri3.Soyad = "Aksoy";
            musteri3.Id = 328;

            Musteri[] musteriDizisi = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Müşteriler ekleniyor...");

            foreach (var musteri in musteriDizisi)
            {
                musteriManager.MusteriEkleme(musteri);
            }

            musteriManager.MusteriListeleme(musteriDizisi);

            musteriManager.MusteriSilme(musteri2);

        }

    }
}
