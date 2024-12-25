using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeProje2
{
    internal class BankaHesabi
    {
        string HesapNo;
        double Bakiye;


        public BankaHesabi(string hesapNo, double baslangicBakiyesi)
        {
            HesapNo = hesapNo;
            if(baslangicBakiyesi<0)
            {
                Console.WriteLine("Başlangıc Bakiyesi negatif Olamaz. Bakiye Sifir Olarak Ayarlandı.");
                this.Bakiye = 0;
            }
            else
            {
                this.Bakiye=baslangicBakiyesi;
            }
        }

        public void ParaYatir(double miktar)
        {
            if(miktar<0)
            {
                Console.WriteLine("Hata: Yatiralacak Miktar Negatif veya Sıfır Olamaz");

            }
            else
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL hesabınıza yatırıldı. Güncel Bakiye : {Bakiye} TL.");
            } 
        }

        public void ParaCek(double miktar)
        {
            if (miktar < 0)
            {
                Console.WriteLine("Hata: Yatiralacak Miktar Negatif veya Sıfır Olamaz");

            }
            else if(miktar > Bakiye)
            {
                Console.WriteLine("Hata: Hesap bakiyesi yetersiz. İşlem yapılamadı.");
            }
            else
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL hesabınızdan Çekildi. Güncel Bakiye : {Bakiye} TL.");
            }
        }

        public double GetBakiye()
        {
            return Bakiye; 
        }

       
    }
}
