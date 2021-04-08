using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {


            Console.WriteLine("      ------Müşteriler Listelendi------" + " \n ");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.AdiSoyadi + " - " + musteri.TCKimlik + " - " + musteri.TelNo + " \n ");

            }

        }
        public void Ekle(Musteri[] musteri4)
        {
            Console.WriteLine("         ------Müşteri Eklendi------" + " \n ");

            foreach (var musteri in musteri4)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.AdiSoyadi + " - " + musteri.TCKimlik + " - " + musteri.TelNo + " \n ");

            }





        }
        public void Sil(Musteri[] musteri4)
        {
            Console.WriteLine("         ------Müşteri Silindi------" + " \n ");

            foreach (var musteri in musteri4)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.AdiSoyadi + " - " + musteri.TCKimlik + " - " + musteri.TelNo + " \n ");

            }


        }



    }






}
