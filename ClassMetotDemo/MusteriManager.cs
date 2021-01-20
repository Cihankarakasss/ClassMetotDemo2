using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{


    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri Eklendi:" + musteri.Id + "  +   " + musteri.Adi + "    +   " + musteri.Soyadi);

        }

        public void Listele(Musteri musteri)

        {
            Console.WriteLine("Müşteriler Listelendi:" + musteri.Id + "  /   " + musteri.Adi + "  /    " + musteri.Soyadi);


        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Üzgünüz.Müşteri Silindi! :   " + musteri.Id + "  -  " + musteri.Adi + "   -  " + musteri.Soyadi);
        }
    }
}
