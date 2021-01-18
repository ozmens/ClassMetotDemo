using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string Ad, string Soyad, string HesapNo) 
        {

            Console.WriteLine(Ad + " " + Soyad + " adlı müşteri için " + HesapNo + " nolu hesap açılmıştır.");
        }

        public void Listele(string Ad, string Soyad, string HesapNo) 
        {
            Console.WriteLine(Ad + " " + Soyad + " bankamızın müşterisidir ve " + HesapNo + " nolu hesaba sahiptir.");
        }




        public void Sil(string Ad, string Soyad, string HesapNo) 
        {
            Console.WriteLine(Ad + " " + Soyad + " adlı müşterinin " + HesapNo + " nolu hesabı silinmiştir.");
        }
    }
}
