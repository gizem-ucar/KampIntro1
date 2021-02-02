using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };    //Dizi oluşturduk ama sadece string yazabiliriz onun için class kullanıyoruz.

            Urun urun1 = new Urun();     //Class tanımladık.Classın örneği deniyor.

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };   //Urun arrayi oluşturduk. Array : Bir veri tipinde istediğin kadar data eklersen tutan yapı.
                                                            //type-safe -- tip güvenli     

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("------------Metotlar---------------");
            //instance -örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();    //Classı çağırma.İnstance yaptık.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elme ", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}
//Dont repeat yoursalf - DRY - Clean code -Best Practice