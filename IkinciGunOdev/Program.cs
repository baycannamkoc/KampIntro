using System;

namespace IkinciGunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.UrunAdi = "Bardak";
            Urun1.UrunId = 1001;
            Urun1.UrunFiyat = 109.99;

            Urun Urun2 = new Urun();
            Urun2.UrunAdi = "Kaşık";
            Urun2.UrunId = 1002;
            Urun2.UrunFiyat = 159.99;

            Urun Urun3 = new Urun();
            Urun3.UrunAdi = "Çatal";
            Urun3.UrunId = 1003;
            Urun3.UrunFiyat = 259.99;

            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3 };
            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].UrunAdi + " : " + Urunler[i].UrunFiyat + " : " + Urunler[i].UrunId);
            }

            Console.WriteLine("for bitti");


            foreach (var urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyat + " : " + urun.UrunId);
            }


        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunId { get; set; }
        public double UrunFiyat { get; set; }
    }


}
