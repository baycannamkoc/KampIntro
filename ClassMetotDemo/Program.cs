using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri mus1 = new Musteri();

            mus1.AdiSoyadi = "Cafer Kuytul";
            mus1.Id = 1;
            mus1.TCKimlik = "11111111111";
            mus1.TelNo = "05325320532";

            Musteri mus2 = new Musteri();

            mus2.AdiSoyadi = "Murat Soydan";
            mus2.Id = 2;
            mus2.TCKimlik = "22222222222";
            mus2.TelNo = "05425420542";

            Musteri mus3 = new Musteri();

            mus3.AdiSoyadi = "Hakan Yılmaz";
            mus3.Id = 3;
            mus3.TCKimlik = "33333333333";
            mus3.TelNo = "05555550555";

            Musteri mus4 = new Musteri();

            mus4.AdiSoyadi = "Fatih Yılmaz";
            mus4.Id = 4;
            mus4.TCKimlik = "44444444444";
            mus4.TelNo = "09999999999";

            Musteri[] musteriler = new Musteri[] { mus1, mus2, mus3 };

            MusteriManager MusManager = new MusteriManager();
            MusManager.Listele(musteriler);

            Musteri[] musteri4 = new Musteri[] { mus4 };

            MusManager.Ekle(musteri4);
            MusManager.Sil(musteri4);







        }

    }

}

