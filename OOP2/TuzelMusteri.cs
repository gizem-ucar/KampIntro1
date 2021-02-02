using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate demek
    //miras inheritance yaptık :Musteri ile   
    class TuzelMusteri : Musteri
    {

        public string SirketAdi { get; set; }
        //eğer bir veri üzerinde bir işlem yapmıyorsan(toplamıyorsan, bölmüyorsan) string kullanmak daha iyi olur. 

        public string VergiNo { get; set; }

    }
}
