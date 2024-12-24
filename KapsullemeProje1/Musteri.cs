using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeProje1
{
    internal class Musteri
    {
        private string Ad;
        private string Soyad;
        private int yas;

        public Musteri(string ad, string soyad, int yas)
        {
           this.Ad = ad;
           this.Soyad = soyad;
            SetYas(yas);
        }

        public string GetAdSoyad()
        {
            return $"{Ad} {Soyad}";
        }

        public void SetYas(int yeniYas)
        {
            if(yeniYas < 0)
            {
                Console.WriteLine("Yaş Negatif Olamaz! Yaş Sıfır Olarak Ayarlandı");
                yas = 0;
            }
            else
            {
                yas = yeniYas;
            }
        }

        public int GetYas()
        {
            return yas;
        }


    }
}
