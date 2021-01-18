using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Kızılkaya";
            musteri1.HesapNo = "4550-94";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Gamze";
            musteri2.Soyad = "Yıldız";
            musteri2.HesapNo = "8974-32";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Selim";
            musteri3.Soyad = "Mutlu";
            musteri3.HesapNo = "6258-71";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler) 
            {
                musteriManager.Ekle(musteri.Ad, musteri.Soyad, musteri.HesapNo);
            }

            Console.WriteLine("**************************************************");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listele(musteri.Ad, musteri.Soyad, musteri.HesapNo);
            }
            
            Console.WriteLine("**************************************************");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Sil(musteri.Ad, musteri.Soyad, musteri.HesapNo);
            }
        }
    }
}
