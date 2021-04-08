using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI";
            string kurs2 = "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS";
            string kurs3 = "JAVA";
            string kurs4 = "PYTHON";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI",
                "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS",
                "JAVA", "PYHTON", "C++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
