using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //tape safeyt = tip güvenliği
            //do not repeat yourself = kendini tekrarlama
            //değer tutucu,alias

            string kategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }



            //Console.WriteLine(kategoriEtiketi);


        }
    }
}