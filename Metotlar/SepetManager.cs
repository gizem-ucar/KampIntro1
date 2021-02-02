using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)    // Parametre ekleriz.Bana ne ekleyeceğimi söyle demek istiyor.  //Urun : tipi  ----- urun ise aşağıda kullanırken vereceğimiz isim.
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }

    }
}
